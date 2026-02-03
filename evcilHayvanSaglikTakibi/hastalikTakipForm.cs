using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace evcilHayvanSaglikTakibi
{
    public partial class hastalikTakipForm : Form
    {
        string connectionString =
            @"Data Source=DESKTOP-QI04ERP\SQLEXPRESS;
              Initial Catalog=EvcilHayvanSaglikSistemiDB;
              Integrated Security=True";

        int secilenHastalikId = 0;

        public hastalikTakipForm()
        {
            InitializeComponent();

            // Panel içi kullanım
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            DurumlariDoldur();
            ChipleriDoldur();
            HastaliklariGetir();
        }

        // ================= CHIP DOLDUR =================
        private void ChipleriDoldur()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
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

        // ================= DURUMLAR =================
        private void DurumlariDoldur()
        {
            cmbDurum.Items.Clear();
            cmbDurum.Items.Add("Devam Ediyor");
            cmbDurum.Items.Add("Kontrolde");
            cmbDurum.Items.Add("İyileşti");
            cmbDurum.SelectedIndex = 0;
        }

        // ================= KAYDET =================
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbChipNo.SelectedIndex == -1 || txtTeshis.Text == "")
            {
                MessageBox.Show("Chip No ve Teşhis boş olamaz.");
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO HastalikKayitlari
                    (ChipNo, Teshis, Tedavi, MuayeneTarihi, KontrolTarihi,
                     Veteriner, Aciklama, Durum)
                    VALUES
                    (@chip, @teshis, @tedavi, @muayene, @kontrol,
                     @vet, @aciklama, @durum)",
                    baglanti);

                cmd.Parameters.AddWithValue("@chip", cmbChipNo.SelectedValue);
                cmd.Parameters.AddWithValue("@teshis", txtTeshis.Text);
                cmd.Parameters.AddWithValue("@tedavi", rtxtTedavi.Text);
                cmd.Parameters.AddWithValue("@muayene", dtpMuayeneTarihi.Value);
                cmd.Parameters.AddWithValue("@kontrol", dtpKontrolTarihi.Value);
                cmd.Parameters.AddWithValue("@vet", txtVeteriner.Text);
                cmd.Parameters.AddWithValue("@aciklama", rtxtAciklama.Text);
                cmd.Parameters.AddWithValue("@durum", cmbDurum.Text);

                baglanti.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Hastalık kaydı eklendi.");
            Temizle();
            HastaliklariGetir();
        }

        // ================= GÜNCELLE =================
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenHastalikId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek kayıt seçin.");
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    @"UPDATE HastalikKayitlari SET
                        ChipNo=@chip,
                        Teshis=@teshis,
                        Tedavi=@tedavi,
                        MuayeneTarihi=@muayene,
                        KontrolTarihi=@kontrol,
                        Veteriner=@vet,
                        Aciklama=@aciklama,
                        Durum=@durum
                      WHERE HastalikId=@id",
                    baglanti);

                cmd.Parameters.AddWithValue("@chip", cmbChipNo.SelectedValue);
                cmd.Parameters.AddWithValue("@teshis", txtTeshis.Text);
                cmd.Parameters.AddWithValue("@tedavi", rtxtTedavi.Text);
                cmd.Parameters.AddWithValue("@muayene", dtpMuayeneTarihi.Value);
                cmd.Parameters.AddWithValue("@kontrol", dtpKontrolTarihi.Value);
                cmd.Parameters.AddWithValue("@vet", txtVeteriner.Text);
                cmd.Parameters.AddWithValue("@aciklama", rtxtAciklama.Text);
                cmd.Parameters.AddWithValue("@durum", cmbDurum.Text);
                cmd.Parameters.AddWithValue("@id", secilenHastalikId);

                baglanti.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Hastalık güncellendi.");
            Temizle();
            HastaliklariGetir();
        }

        // ================= SİL =================
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenHastalikId == 0)
            {
                MessageBox.Show("Lütfen kayıt seçin.");
                return;
            }

            if (MessageBox.Show("Silmek istiyor musunuz?", "Onay",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM HastalikKayitlari WHERE HastalikId=@id", baglanti);

                cmd.Parameters.AddWithValue("@id", secilenHastalikId);
                baglanti.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Kayıt silindi.");
            Temizle();
            HastaliklariGetir();
        }

        // ================= LİSTE =================
        private void HastaliklariGetir()
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT HastalikId, ChipNo, Teshis, Tedavi,
                             MuayeneTarihi, KontrolTarihi,
                             Veteriner, Aciklama, Durum
                      FROM HastalikKayitlari
                      ORDER BY MuayeneTarihi DESC",
                    baglanti);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHastaliklar.DataSource = dt;
                dgvHastaliklar.Columns["HastalikId"].Visible = false;
            }
        }

        // ================= GRID SEÇ =================
        private void dgvHastaliklar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvHastaliklar.Rows[e.RowIndex];

            secilenHastalikId = Convert.ToInt32(row.Cells["HastalikId"].Value);

            cmbChipNo.SelectedValue = row.Cells["ChipNo"].Value;
            txtTeshis.Text = row.Cells["Teshis"].Value.ToString();
            rtxtTedavi.Text = row.Cells["Tedavi"].Value.ToString();
            txtVeteriner.Text = row.Cells["Veteriner"].Value.ToString();
            rtxtAciklama.Text = row.Cells["Aciklama"].Value.ToString();
            cmbDurum.Text = row.Cells["Durum"].Value.ToString();

            dtpMuayeneTarihi.Value = Convert.ToDateTime(row.Cells["MuayeneTarihi"].Value);
            dtpKontrolTarihi.Value = Convert.ToDateTime(row.Cells["KontrolTarihi"].Value);
        }

        // ================= TEMİZLE =================
        private void Temizle()
        {
            cmbChipNo.SelectedIndex = -1;
            txtTeshis.Clear();
            txtVeteriner.Clear();
            rtxtTedavi.Clear();
            rtxtAciklama.Clear();
            dtpMuayeneTarihi.Value = DateTime.Now;
            dtpKontrolTarihi.Value = DateTime.Now;
            cmbDurum.SelectedIndex = 0;
            secilenHastalikId = 0;
        }

        // ================= KAPAT =================
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void hastalikTakipForm_Load(object sender, EventArgs e)
        {

        }
    }
}

