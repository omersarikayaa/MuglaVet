using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace evcilHayvanSaglikTakibi
{
    public partial class panelKayit : Form
    {
        public panelKayit()
        {
            InitializeComponent();

            // Şifre TextBox'ını zorla düzelt
            txtSifre.Multiline = false;
            txtSifre.AutoSize = false;
            txtSifre.Size = new Size(210, 34);
            txtSifre.PasswordChar = '*';

            // Şifre Tekrar için de aynısı
            txtSifreTekrar.Multiline = false;
            txtSifreTekrar.AutoSize = false;
            txtSifreTekrar.Size = new Size(210, 34);
            txtSifreTekrar.PasswordChar = '*';
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }


        private void panelKayit_Load(object sender, EventArgs e)
        {
            // Form yüklenince yapılacak bir şey yok
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string sifreTekrar = txtSifreTekrar.Text.Trim();

            if (kullaniciAdi == "" || sifre == "" || sifreTekrar == "")
            {
                MessageBox.Show("Tüm alanları doldurun.");
                return;
            }

            if (sifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler eşleşmiyor!");
                return;
            }

            if (!checkOnayliyorum.Checked)
            {
                MessageBox.Show("Lütfen şartları onaylayın.");
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(
                @"Data Source=DESKTOP-QI04ERP\SQLEXPRESS;Initial Catalog=EvcilHayvanSaglikSistemiDB;Integrated Security=True;"))
            {
                baglanti.Open();

                SqlCommand kontrol = new SqlCommand(
                    "SELECT COUNT(*) FROM KullaniciGirisi WHERE kullaniciAdi=@kullaniciAdi", baglanti);

                kontrol.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);

                int varMi = (int)kontrol.ExecuteScalar();

                if (varMi > 0)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten var!");
                    return;
                }

                SqlCommand ekle = new SqlCommand(
                    "INSERT INTO KullaniciGirisi (kullaniciAdi, sifre) VALUES (@kullaniciAdi, @sifre)", baglanti);

                ekle.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                ekle.Parameters.AddWithValue("@sifre", sifre);

                ekle.ExecuteNonQuery();

                MessageBox.Show("Kayıt başarılı!");
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            txtSifre.Size = new Size(210, 34);

        }
 
    }
}

