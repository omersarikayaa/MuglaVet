using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace evcilHayvanSaglikTakibi
{
    public partial class RaporIstatistikForm : Form
    {
        private const string ConnStr =
            @"Data Source=DESKTOP-QI04ERP\SQLEXPRESS;
              Initial Catalog=EvcilHayvanSaglikSistemiDB;
              Integrated Security=True;";

        public RaporIstatistikForm()
        {
            InitializeComponent();

            // Panel içine gömülmesi için
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        private void RaporIstatistikForm_Load(object sender, EventArgs e)
        {
            dtBaslangic.Value = DateTime.Today.AddDays(-7);
            dtBitis.Value = DateTime.Today;

            VerileriGetir();
        }

        // ================= VERİ GETİR =================
        void VerileriGetir()
        {
            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                string query = @"
                SELECT 
                    H.hayvanAdi,
                    U.IslemAdi,
                    U.Tutar,
                    U.Tarih
                FROM Ucretler U
                INNER JOIN Hayvanlar H ON U.ChipNo = H.ChipNo
                WHERE 
                    CAST(U.Tarih AS DATE) >= @baslangic
                    AND CAST(U.Tarih AS DATE) <= @bitis";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@baslangic", SqlDbType.Date).Value = dtBaslangic.Value.Date;
                cmd.Parameters.Add("@bitis", SqlDbType.Date).Value = dtBitis.Value.Date;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewRapor.DataSource = dt;

                OzetHesapla(dt);
            }
        }

        // ================= ÖZET =================
        void OzetHesapla(DataTable dt)
        {
            decimal toplamKazanc = 0;
            int islemSayisi = dt.Rows.Count;

            foreach (DataRow row in dt.Rows)
                toplamKazanc += Convert.ToDecimal(row["Tutar"]);

            lblToplamKazanc.Text = $"Toplam Kazanç: {toplamKazanc:N2} ₺";
            lblToplamIslem.Text = $"Toplam İşlem: {islemSayisi}";
            lblToplamHasta.Text = $"Toplam Hasta: {dt.DefaultView.ToTable(true, "hayvanAdi").Rows.Count}";
            lblBugunKazanc.Text = $"Bugünkü Kazanç: {BugunKazanc():N2} ₺";
        }

        decimal BugunKazanc()
        {
            decimal toplam = 0;

            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                SqlCommand cmd = new SqlCommand(
                    @"SELECT SUM(Tutar)
                      FROM Ucretler
                      WHERE CAST(Tarih AS DATE) = CAST(GETDATE() AS DATE)", con);

                con.Open();
                object sonuc = cmd.ExecuteScalar();

                if (sonuc != DBNull.Value)
                    toplam = Convert.ToDecimal(sonuc);
            }

            return toplam;
        }

        // ================= FİLTRE =================
        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        // ================= KAPAT =================
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
