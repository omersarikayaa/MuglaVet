using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace evcilHayvanSaglikTakibi
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(
                 @"Data Source=DESKTOP-QI04ERP\SQLEXPRESS;Initial Catalog=EvcilHayvanSaglikSistemiDB;Integrated Security=True;"
             );


                baglanti.Open();

                SqlCommand komut = new SqlCommand(
                    "SELECT * FROM KullaniciGirisi WHERE kullaniciAdi=@kullaniciAdi AND sifre=@sifre",
                    baglanti
                );

                komut.Parameters.AddWithValue("@kullaniciAdi", textBox1.Text);
                komut.Parameters.AddWithValue("@sifre", textBox2.Text);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Giriş başarılı!");
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlış kullanıcı adı veya parola.");
                }

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("HATA: " + ex.Message, "SQL Hatası");
            }
        }


        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelKayit kayitFormu = new panelKayit();
            kayitFormu.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

