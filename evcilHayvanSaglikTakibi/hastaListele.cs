using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace evcilHayvanSaglikTakibi
{
    public partial class hastaListele : Form
    {
        string connStr = @"Data Source=DESKTOP-QI04ERP\SQLEXPRESS;
                           Initial Catalog=EvcilHayvanSaglikSistemiDB;
                           Integrated Security=True;";

        public hastaListele()
        {
            InitializeComponent();

            // Panel içine gömülme
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        // ================= LOAD =================
        private void hastaListele_Load(object sender, EventArgs e)
        {
            cmbFiltreTur.Items.Clear();
            cmbFiltreTur.Items.Add("Tümü");
            cmbFiltreTur.Items.Add("Kedi");
            cmbFiltreTur.Items.Add("Köpek");
            cmbFiltreTur.SelectedIndex = 0;

            cmbTur.Items.Clear();
            cmbTur.Items.Add("Kedi");
            cmbTur.Items.Add("Köpek");

            ChipleriDoldur();
            HayvanlariListele();
        }

        // ================= CHIP DOLDUR =================
        private void ChipleriDoldur()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT chipNo FROM Hayvanlar ORDER BY chipNo", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbChipNo.DataSource = dt;
                cmbChipNo.DisplayMember = "chipNo";
                cmbChipNo.ValueMember = "chipNo";
                cmbChipNo.SelectedIndex = -1;
            }
        }

        // ================= LİSTELE =================
        private void HayvanlariListele()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT chipNo, hayvanAdi, tur, irk, cinsiyet,
                             sahipAdiSoyadi, telefon, adres, notlar
                      FROM Hayvanlar", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHayvanlar.DataSource = dt;
            }
        }

        // ================= GRID SEÇ =================
        private void dgvHayvanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvHayvanlar.Rows[e.RowIndex];

            cmbChipNo.SelectedValue = row.Cells["chipNo"].Value.ToString();
            txtHayvanAdi.Text = row.Cells["hayvanAdi"].Value.ToString();
            cmbTur.Text = row.Cells["tur"].Value.ToString();
            txtIrk.Text = row.Cells["irk"].Value.ToString();

            string cinsiyet = row.Cells["cinsiyet"].Value.ToString();
            rbErkek.Checked = cinsiyet == "Erkek";
            rbDisi.Checked = cinsiyet == "Dişi";

            txtSahip.Text = row.Cells["sahipAdiSoyadi"].Value.ToString();
            mskTelefon.Text = row.Cells["telefon"].Value.ToString();
            txtAdres.Text = row.Cells["adres"].Value.ToString();
            txtNotlar.Text = row.Cells["notlar"].Value.ToString();
        }

        // ================= GÜNCELLE =================
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (cmbChipNo.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Chip No seçin.");
                return;
            }

            string chip = cmbChipNo.SelectedValue.ToString();
            string cinsiyet = rbErkek.Checked ? "Erkek" : "Dişi";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(@"
                    UPDATE Hayvanlar SET
                        hayvanAdi=@adi,
                        tur=@tur,
                        irk=@irk,
                        cinsiyet=@cins,
                        sahipAdiSoyadi=@sahip,
                        telefon=@tel,
                        adres=@adres,
                        notlar=@notlar
                    WHERE chipNo=@chip", conn);

                cmd.Parameters.AddWithValue("@adi", txtHayvanAdi.Text);
                cmd.Parameters.AddWithValue("@tur", cmbTur.Text);
                cmd.Parameters.AddWithValue("@irk", txtIrk.Text);
                cmd.Parameters.AddWithValue("@cins", cinsiyet);
                cmd.Parameters.AddWithValue("@sahip", txtSahip.Text);
                cmd.Parameters.AddWithValue("@tel", mskTelefon.Text);
                cmd.Parameters.AddWithValue("@adres", txtAdres.Text);
                cmd.Parameters.AddWithValue("@notlar", txtNotlar.Text);
                cmd.Parameters.AddWithValue("@chip", chip);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Güncellendi.");
            HayvanlariListele();
        }

        // ================= SİL =================
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (cmbChipNo.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Chip No seçin.");
                return;
            }

            if (MessageBox.Show("Bu hasta silinsin mi?", "Onay",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Hayvanlar WHERE chipNo=@chip", conn);

                cmd.Parameters.AddWithValue("@chip", cmbChipNo.SelectedValue);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Hasta silindi.");
            cmbChipNo.SelectedIndex = -1;
            HayvanlariListele();
        }

        // ================= ARA =================
        private void btnAra_Click(object sender, EventArgs e)
        {
            string chip = cmbChipNo.SelectedIndex >= 0 ? cmbChipNo.SelectedValue.ToString() : "";
            string tur = cmbFiltreTur.Text;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "SELECT * FROM Hayvanlar WHERE 1=1";

                if (!string.IsNullOrEmpty(chip))
                    sql += " AND chipNo = @chip";

                if (tur != "Tümü")
                    sql += " AND tur = @tur";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                if (!string.IsNullOrEmpty(chip))
                    da.SelectCommand.Parameters.AddWithValue("@chip", chip);

                if (tur != "Tümü")
                    da.SelectCommand.Parameters.AddWithValue("@tur", tur);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHayvanlar.DataSource = dt;
            }
        }

        // ================= KAPAT =================
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
