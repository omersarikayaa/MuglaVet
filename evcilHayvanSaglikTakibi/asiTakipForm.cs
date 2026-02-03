using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace evcilHayvanSaglikTakibi
{
    public partial class asiTakipForm : Form
    {
        SqlConnection baglanti = new SqlConnection(
            @"Data Source=DESKTOP-QI04ERP\SQLEXPRESS;
              Initial Catalog=EvcilHayvanSaglikSistemiDB;
              Integrated Security=True");

        int secilenAsiId = 0;

        public asiTakipForm()
        {
            InitializeComponent();

            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            cmbGun.Items.Clear();
            cmbGun.Items.Add(7);
            cmbGun.Items.Add(15);
            cmbGun.Items.Add(30);
            cmbGun.SelectedIndex = 0;

            ChipleriDoldur();
            AsilariGetir();
        }

        // ================= CHIP DOLDUR =================
        private void ChipleriDoldur()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT chipNo FROM Hayvanlar ORDER BY chipNo", baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbChipNo.DataSource = dt;
            cmbChipNo.DisplayMember = "chipNo";
            cmbChipNo.ValueMember = "chipNo";
            cmbChipNo.SelectedIndex = -1;
        }

        // ================= AŞI EKLE =================
        private void button3_Click(object sender, EventArgs e)
        {
            if (cmbChipNo.SelectedIndex == -1 || txtAsiAdi.Text.Trim() == "")
            {
                MessageBox.Show("Chip No ve Aşı Adı boş olamaz.");
                return;
            }

            SqlCommand cmd = new SqlCommand(@"
                INSERT INTO Asilar
                (ChipNo, AsiAdi, AsiTarihi, SonrakiAsiTarihi, Aciklama)
                VALUES
                (@chip, @asiAdi, @asiTarihi, @sonrakiTarih, @aciklama)", baglanti);

            cmd.Parameters.AddWithValue("@chip", cmbChipNo.SelectedValue);
            cmd.Parameters.AddWithValue("@asiAdi", txtAsiAdi.Text);
            cmd.Parameters.AddWithValue("@asiTarihi", dtpAsiTarihi.Value.Date);
            cmd.Parameters.AddWithValue("@sonrakiTarih", dtpSonrakiAsiTarihi.Value.Date);
            cmd.Parameters.AddWithValue("@aciklama", rtxtAciklama.Text);

            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Aşı başarıyla kaydedildi.");
            Temizle();
            AsilariGetir();
        }

        // ================= LİSTE =================
        private void AsilariGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                @"SELECT AsiId, ChipNo, AsiAdi, AsiTarihi, SonrakiAsiTarihi, Aciklama
                  FROM Asilar
                  ORDER BY AsiTarihi DESC", baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAsilar.DataSource = dt;
        }

        // ================= GRID TIK =================
        private void dgvAsilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvAsilar.Rows[e.RowIndex];

            secilenAsiId = Convert.ToInt32(row.Cells["AsiId"].Value);
            cmbChipNo.SelectedValue = row.Cells["ChipNo"].Value;
            txtAsiAdi.Text = row.Cells["AsiAdi"].Value.ToString();
            dtpAsiTarihi.Value = Convert.ToDateTime(row.Cells["AsiTarihi"].Value);
            dtpSonrakiAsiTarihi.Value = Convert.ToDateTime(row.Cells["SonrakiAsiTarihi"].Value);
            rtxtAciklama.Text = row.Cells["Aciklama"].Value.ToString();
        }

        // ================= YAKLAŞAN AŞILAR =================
        private void btnYaklasanAsilar_Click(object sender, EventArgs e)
        {
            if (cmbGun.SelectedItem == null)
            {
                MessageBox.Show("Gün seçiniz.");
                return;
            }

            int gun = Convert.ToInt32(cmbGun.SelectedItem);

            SqlDataAdapter da = new SqlDataAdapter(@"
                SELECT AsiId, ChipNo, AsiAdi, SonrakiAsiTarihi, Aciklama
                FROM Asilar
                WHERE CAST(SonrakiAsiTarihi AS DATE)
                BETWEEN CAST(GETDATE() AS DATE)
                AND DATEADD(DAY, @gun, CAST(GETDATE() AS DATE))
                ORDER BY SonrakiAsiTarihi", baglanti);

            da.SelectCommand.Parameters.AddWithValue("@gun", gun);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvYaklasanAsilar.DataSource = dt;
        }

        // ================= SİL =================
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenAsiId == 0)
            {
                MessageBox.Show("Silinecek kayıt seçin.");
                return;
            }

            if (MessageBox.Show("Silmek istiyor musunuz?", "Onay",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            SqlCommand cmd = new SqlCommand(
                "DELETE FROM Asilar WHERE AsiId=@id", baglanti);

            cmd.Parameters.AddWithValue("@id", secilenAsiId);

            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Silindi.");
            Temizle();
            AsilariGetir();
        }

        private void Temizle()
        {
            cmbChipNo.SelectedIndex = -1;
            txtAsiAdi.Clear();
            rtxtAciklama.Clear();
            dtpAsiTarihi.Value = DateTime.Today;
            dtpSonrakiAsiTarihi.Value = DateTime.Today;
            secilenAsiId = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
