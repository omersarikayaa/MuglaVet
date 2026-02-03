using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace evcilHayvanSaglikTakibi
{
    public partial class hastaKayit : Form
    {
        public hastaKayit()
        {
            InitializeComponent();

            // 🔥 PANEL İÇİN GEREKLİ AYARLAR
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }

        // ❌ ARTIK FORM KAPATILMIYOR
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Formdan değerleri çekiyoruz
            string chipNo = textBox1.Text.Trim();
            string hayvanAdi = textBox2.Text.Trim();
            string tur = comboBox1.SelectedItem?.ToString();
            string irk = textBox3.Text.Trim();
            string cinsiyet = radioButton1.Checked ? "Erkek" :
                              radioButton2.Checked ? "Dişi" : "";
            DateTime dogumTarihi = dateTimePicker1.Value;

            string sahipAdi = textBox5.Text.Trim();
            string telefon = textBox5.Text.Trim();
            string adres = textBox6.Text.Trim();
            string notlar = textBox7.Text.Trim();

            double agirlik;
            if (!double.TryParse(textBox4.Text.Trim(), out agirlik))
            {
                MessageBox.Show("Ağırlık sayısal bir değer olmalıdır!");
                return;
            }

            if (chipNo == "" || hayvanAdi == "" || tur == null ||
                cinsiyet == "" || sahipAdi == "" || telefon == "")
            {
                MessageBox.Show("Lütfen zorunlu alanları doldurun!");
                return;
            }

            string connStr = @"Data Source=DESKTOP-QI04ERP\SQLEXPRESS;
                               Initial Catalog=EvcilHayvanSaglikSistemiDB;
                               Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    string kontrolSql = "SELECT COUNT(*) FROM Hayvanlar WHERE chipNo = @chipNo";
                    using (SqlCommand kontrolCmd = new SqlCommand(kontrolSql, conn))
                    {
                        kontrolCmd.Parameters.AddWithValue("@chipNo", chipNo);
                        int adet = (int)kontrolCmd.ExecuteScalar();

                        if (adet > 0)
                        {
                            MessageBox.Show("Bu çip numarasına kayıt zaten var!");
                            return;
                        }
                    }

                    string insertSql = @"
                        INSERT INTO Hayvanlar
                        (chipNo, hayvanAdi, tur, irk, cinsiyet, dogumTarihi, agirlik,
                         sahipAdiSoyadi, telefon, adres, notlar)
                        VALUES
                        (@chipNo, @hayvanAdi, @tur, @irk, @cinsiyet, @dogumTarihi, @agirlik,
                         @sahipAdiSoyadi, @telefon, @adres, @notlar)";

                    using (SqlCommand cmd = new SqlCommand(insertSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@chipNo", chipNo);
                        cmd.Parameters.AddWithValue("@hayvanAdi", hayvanAdi);
                        cmd.Parameters.AddWithValue("@tur", tur);
                        cmd.Parameters.AddWithValue("@irk", irk);
                        cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
                        cmd.Parameters.AddWithValue("@dogumTarihi", dogumTarihi);
                        cmd.Parameters.AddWithValue("@agirlik", agirlik);
                        cmd.Parameters.AddWithValue("@sahipAdiSoyadi", sahipAdi);
                        cmd.Parameters.AddWithValue("@telefon", telefon);
                        cmd.Parameters.AddWithValue("@adres", adres);
                        cmd.Parameters.AddWithValue("@notlar", notlar);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kayıt başarıyla eklendi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void hastaKayit_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Kedi");
            comboBox1.Items.Add("Köpek");
            comboBox1.SelectedIndex = 0;
        }
    }
}
