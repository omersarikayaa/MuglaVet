using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace evcilHayvanSaglikTakibi
{
    public partial class UcretTakipForm : Form
    {
        private const string ConnStr =
            @"Data Source=DESKTOP-QI04ERP\SQLEXPRESS;
              Initial Catalog=EvcilHayvanSaglikSistemiDB;
              Integrated Security=True;";

        public UcretTakipForm()
        {
            InitializeComponent();
        }

        private void UcretTakipForm_Load(object sender, EventArgs e)
        {
            GridAyarla();
            ChipleriGetir();

            dtBaslangic.Value = DateTime.Today.AddDays(-7);
            dtBitis.Value = DateTime.Today;

            VerileriGetir();
        }

        // ================= GRID =================
        void GridAyarla()
        {
            dataGridViewUcret.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUcret.MultiSelect = false;
            dataGridViewUcret.ReadOnly = true;
            dataGridViewUcret.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ================= CHIPLER =================
        void ChipleriGetir()
        {
            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT ChipNo FROM Hayvanlar", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbChipNo.DataSource = dt;
                cmbChipNo.DisplayMember = "ChipNo";
            }
        }

        // ================= VERİLERİ GETİR =================
        void VerileriGetir()
        {
            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                string query = @"
        SELECT 
            U.UcretID,
            U.ChipNo,
            H.hayvanAdi,
            U.IslemAdi,
            U.Tutar,
            U.OdemeDurumu,
            U.Tarih
        FROM Ucretler U
        INNER JOIN Hayvanlar H ON U.ChipNo = H.ChipNo
        WHERE 
            U.Tarih >= @baslangic 
            AND U.Tarih < @bitis";

                if (chkOdenenler.Checked)
                    query += " AND U.OdemeDurumu = 1";

                SqlCommand cmd = new SqlCommand(query, con);

                // 🔥 BURASI ÖNEMLİ
                cmd.Parameters.AddWithValue("@baslangic", dtBaslangic.Value.Date);
                cmd.Parameters.AddWithValue("@bitis", dtBitis.Value.Date.AddDays(1));

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewUcret.DataSource = dt;
            }

            KazancHesapla();
        }


        // ================= EKLE =================
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!FormGecerli(out decimal tutar)) return;

            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Ucretler 
                      (ChipNo, IslemAdi, Tutar, OdemeDurumu, Tarih)
                      VALUES (@chip,@islem,@tutar,@odeme,GETDATE())", con);

                cmd.Parameters.AddWithValue("@chip", cmbChipNo.Text);
                cmd.Parameters.AddWithValue("@islem", txtIslemAdi.Text);
                cmd.Parameters.AddWithValue("@tutar", tutar);
                cmd.Parameters.AddWithValue("@odeme", chkOdendi.Checked);

                cmd.ExecuteNonQuery();
            }

            Temizle();
            VerileriGetir();
        }

        // ================= SATIR SEÇ =================
        private void dataGridViewUcret_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridViewUcret.Rows[e.RowIndex];

            cmbChipNo.Text = row.Cells["ChipNo"].Value.ToString();
            txtIslemAdi.Text = row.Cells["IslemAdi"].Value.ToString();
            txtTutar.Text = row.Cells["Tutar"].Value.ToString();
            chkOdendi.Checked = Convert.ToBoolean(row.Cells["OdemeDurumu"].Value);
        }

        // ================= GÜNCELLE =================
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!SeciliVar(out int id)) return;
            if (!FormGecerli(out decimal tutar)) return;

            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Ucretler 
                      SET ChipNo=@chip, IslemAdi=@islem, 
                          Tutar=@tutar, OdemeDurumu=@odeme
                      WHERE UcretID=@id", con);

                cmd.Parameters.AddWithValue("@chip", cmbChipNo.Text);
                cmd.Parameters.AddWithValue("@islem", txtIslemAdi.Text);
                cmd.Parameters.AddWithValue("@tutar", tutar);
                cmd.Parameters.AddWithValue("@odeme", chkOdendi.Checked);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }

            Temizle();
            VerileriGetir();
        }

        // ================= SİL =================
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (!SeciliVar(out int id)) return;

            if (MessageBox.Show("Silmek istiyor musun?", "Onay",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            using (SqlConnection con = new SqlConnection(ConnStr))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Ucretler WHERE UcretID=@id", con);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            Temizle();
            VerileriGetir();
        }

        // ================= FİLTRE =================
        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        // ================= KAZANÇ =================
        void KazancHesapla()
        {
            decimal gunluk = 0, aylik = 0, yillik = 0;
            DateTime bugun = DateTime.Today;

            foreach (DataGridViewRow row in dataGridViewUcret.Rows)
            {
                if (row.IsNewRow) continue;
                if (!Convert.ToBoolean(row.Cells["OdemeDurumu"].Value)) continue;

                decimal tutar = Convert.ToDecimal(row.Cells["Tutar"].Value);
                DateTime tarih = Convert.ToDateTime(row.Cells["Tarih"].Value);

                if (tarih.Date == bugun) gunluk += tutar;
                if (tarih.Month == bugun.Month && tarih.Year == bugun.Year) aylik += tutar;
                if (tarih.Year == bugun.Year) yillik += tutar;
            }

            lblGunluk.Text = $"Günlük: {gunluk:N2} ₺";
            lblAylik.Text = $"Aylık: {aylik:N2} ₺";
            lblYillik.Text = $"Yıllık: {yillik:N2} ₺";
        }

        // ================= YARDIMCILAR =================
        bool SeciliVar(out int id)
        {
            id = 0;
            if (dataGridViewUcret.SelectedRows.Count == 0)
            {
                MessageBox.Show("Kayıt seçiniz.");
                return false;
            }

            id = Convert.ToInt32(dataGridViewUcret.SelectedRows[0].Cells["UcretID"].Value);
            return true;
        }

        bool FormGecerli(out decimal tutar)
        {
            tutar = 0;

            if (string.IsNullOrWhiteSpace(txtIslemAdi.Text) ||
                string.IsNullOrWhiteSpace(txtTutar.Text))
            {
                MessageBox.Show("Alanları doldurun.");
                return false;
            }

            return decimal.TryParse(txtTutar.Text.Replace(",", "."),
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out tutar);
        }

        void Temizle()
        {
            txtIslemAdi.Clear();
            txtTutar.Clear();
            chkOdendi.Checked = false;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
