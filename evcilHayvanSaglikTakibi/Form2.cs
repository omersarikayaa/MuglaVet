using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace evcilHayvanSaglikTakibi
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        private void FormAc(Form frm)
        {
            panelIcerik.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelIcerik.Controls.Add(frm);
            frm.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FormAc(new hastaKayit());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAc(new hastaListele());
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAc(new UcretTakipForm());
        }

        private void IcerikYukle(Form frm)
        {
            panelIcerik.Controls.Clear();   // Önce eskiyi temizle

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            panelIcerik.Controls.Add(frm);
            frm.Show();
        }


        private void panelIcerik_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAsiTakip_Click(object sender, EventArgs e)
        {
            FormAc(new asiTakipForm());
        }


        private void button4_Click(object sender, EventArgs e)
        {
            FormAc(new hastalikTakipForm());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAc(new RaporIstatistikForm());
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {

        }

        private void panelIcerik_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
