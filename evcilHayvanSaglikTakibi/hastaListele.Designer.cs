namespace evcilHayvanSaglikTakibi
{
    partial class hastaListele
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            btnKapat = new Button();
            button1 = new Button();
            label1 = new Label();
            button6 = new Button();
            grpArama = new GroupBox();
            cmbChipNo = new ComboBox();
            dataGridView1 = new DataGridView();
            cmbFiltreTur = new ComboBox();
            btnAra = new Button();
            label2 = new Label();
            grpListe = new GroupBox();
            dgvHayvanlar = new DataGridView();
            grpHastaBilgileri = new GroupBox();
            btnSil = new Button();
            btnGuncelle = new Button();
            Irk = new Label();
            txtIrk = new TextBox();
            txtNotlar = new TextBox();
            label10 = new Label();
            txtAdres = new TextBox();
            label9 = new Label();
            mskTelefon = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtSahip = new TextBox();
            rbDisi = new RadioButton();
            rbErkek = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            cmbTur = new ComboBox();
            label4 = new Label();
            txtHayvanAdi = new TextBox();
            txtChipNo = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grpArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHayvanlar).BeginInit();
            grpHastaBilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnKapat);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button6);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1396, 68);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.responsive;
            pictureBox3.Location = new Point(598, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 65);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // btnKapat
            // 
            btnKapat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKapat.BackColor = Color.SteelBlue;
            btnKapat.Cursor = Cursors.Hand;
            btnKapat.FlatAppearance.BorderSize = 0;
            btnKapat.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKapat.ForeColor = SystemColors.InfoText;
            btnKapat.Location = new Point(1321, 0);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(75, 68);
            btnKapat.TabIndex = 4;
            btnKapat.Text = "X";
            btnKapat.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Crimson;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(2114, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 68);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.NavajoWhite;
            label1.Location = new Point(0, 15);
            label1.Name = "label1";
            label1.Size = new Size(592, 40);
            label1.TabIndex = 3;
            label1.Text = "Hasta Görüntüleme ve Yönetim Paneli";
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.BackColor = Color.Crimson;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.Font = new Font("Times New Roman", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.Location = new Point(3301, 0);
            button6.Name = "button6";
            button6.Size = new Size(80, 80);
            button6.TabIndex = 2;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            // 
            // grpArama
            // 
            grpArama.BackColor = Color.SteelBlue;
            grpArama.Controls.Add(cmbChipNo);
            grpArama.Controls.Add(dataGridView1);
            grpArama.Controls.Add(cmbFiltreTur);
            grpArama.Controls.Add(btnAra);
            grpArama.Controls.Add(label2);
            grpArama.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            grpArama.ForeColor = Color.NavajoWhite;
            grpArama.Location = new Point(18, 74);
            grpArama.Name = "grpArama";
            grpArama.Size = new Size(1338, 71);
            grpArama.TabIndex = 3;
            grpArama.TabStop = false;
            grpArama.Text = "Arama Ve Filtreleme";
            // 
            // cmbChipNo
            // 
            cmbChipNo.FormattingEnabled = true;
            cmbChipNo.Location = new Point(155, 30);
            cmbChipNo.Name = "cmbChipNo";
            cmbChipNo.Size = new Size(200, 30);
            cmbChipNo.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(910, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 4;
            // 
            // cmbFiltreTur
            // 
            cmbFiltreTur.FormattingEnabled = true;
            cmbFiltreTur.Location = new Point(388, 30);
            cmbFiltreTur.Name = "cmbFiltreTur";
            cmbFiltreTur.Size = new Size(121, 30);
            cmbFiltreTur.TabIndex = 3;
            // 
            // btnAra
            // 
            btnAra.ForeColor = Color.Black;
            btnAra.Location = new Point(561, 27);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(84, 34);
            btnAra.TabIndex = 2;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(48, 33);
            label2.Name = "label2";
            label2.Size = new Size(73, 22);
            label2.TabIndex = 0;
            label2.Text = "Çip No:";
            // 
            // grpListe
            // 
            grpListe.BackColor = Color.SteelBlue;
            grpListe.Controls.Add(dgvHayvanlar);
            grpListe.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            grpListe.ForeColor = Color.NavajoWhite;
            grpListe.Location = new Point(18, 151);
            grpListe.Name = "grpListe";
            grpListe.Size = new Size(1338, 298);
            grpListe.TabIndex = 4;
            grpListe.TabStop = false;
            grpListe.Text = "Hasta Listesi";
            // 
            // dgvHayvanlar
            // 
            dgvHayvanlar.AllowUserToAddRows = false;
            dgvHayvanlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHayvanlar.BackgroundColor = Color.Silver;
            dgvHayvanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHayvanlar.Location = new Point(6, 38);
            dgvHayvanlar.MultiSelect = false;
            dgvHayvanlar.Name = "dgvHayvanlar";
            dgvHayvanlar.ReadOnly = true;
            dgvHayvanlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHayvanlar.Size = new Size(1275, 236);
            dgvHayvanlar.TabIndex = 0;
            dgvHayvanlar.CellClick += dgvHayvanlar_CellClick;
            // 
            // grpHastaBilgileri
            // 
            grpHastaBilgileri.BackColor = Color.SteelBlue;
            grpHastaBilgileri.Controls.Add(btnSil);
            grpHastaBilgileri.Controls.Add(btnGuncelle);
            grpHastaBilgileri.Controls.Add(Irk);
            grpHastaBilgileri.Controls.Add(txtIrk);
            grpHastaBilgileri.Controls.Add(txtNotlar);
            grpHastaBilgileri.Controls.Add(label10);
            grpHastaBilgileri.Controls.Add(txtAdres);
            grpHastaBilgileri.Controls.Add(label9);
            grpHastaBilgileri.Controls.Add(mskTelefon);
            grpHastaBilgileri.Controls.Add(label8);
            grpHastaBilgileri.Controls.Add(label7);
            grpHastaBilgileri.Controls.Add(txtSahip);
            grpHastaBilgileri.Controls.Add(rbDisi);
            grpHastaBilgileri.Controls.Add(rbErkek);
            grpHastaBilgileri.Controls.Add(label6);
            grpHastaBilgileri.Controls.Add(label5);
            grpHastaBilgileri.Controls.Add(cmbTur);
            grpHastaBilgileri.Controls.Add(label4);
            grpHastaBilgileri.Controls.Add(txtHayvanAdi);
            grpHastaBilgileri.Controls.Add(txtChipNo);
            grpHastaBilgileri.Controls.Add(label3);
            grpHastaBilgileri.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            grpHastaBilgileri.ForeColor = Color.NavajoWhite;
            grpHastaBilgileri.Location = new Point(18, 455);
            grpHastaBilgileri.Name = "grpHastaBilgileri";
            grpHastaBilgileri.Size = new Size(1338, 343);
            grpHastaBilgileri.TabIndex = 4;
            grpHastaBilgileri.TabStop = false;
            grpHastaBilgileri.Text = "Hasta Bilgileri";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.NavajoWhite;
            btnSil.ForeColor = Color.Red;
            btnSil.Location = new Point(751, 284);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(137, 40);
            btnSil.TabIndex = 27;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.NavajoWhite;
            btnGuncelle.ForeColor = Color.Black;
            btnGuncelle.Location = new Point(437, 284);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(137, 40);
            btnGuncelle.TabIndex = 26;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // Irk
            // 
            Irk.AutoSize = true;
            Irk.ForeColor = Color.WhiteSmoke;
            Irk.Location = new Point(42, 225);
            Irk.Name = "Irk";
            Irk.Size = new Size(41, 22);
            Irk.TabIndex = 25;
            Irk.Text = "Irk:";
            // 
            // txtIrk
            // 
            txtIrk.Location = new Point(155, 225);
            txtIrk.Name = "txtIrk";
            txtIrk.Size = new Size(200, 29);
            txtIrk.TabIndex = 24;
            // 
            // txtNotlar
            // 
            txtNotlar.Location = new Point(1001, 44);
            txtNotlar.Multiline = true;
            txtNotlar.Name = "txtNotlar";
            txtNotlar.Size = new Size(280, 105);
            txtNotlar.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(900, 44);
            label10.Name = "label10";
            label10.Size = new Size(68, 22);
            label10.TabIndex = 17;
            label10.Text = "Notlar:";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(1001, 168);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(280, 105);
            txtAdres.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(905, 171);
            label9.Name = "label9";
            label9.Size = new Size(63, 22);
            label9.TabIndex = 14;
            label9.Text = "Adres:";
            // 
            // mskTelefon
            // 
            mskTelefon.Location = new Point(580, 106);
            mskTelefon.Name = "mskTelefon";
            mskTelefon.Size = new Size(180, 29);
            mskTelefon.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(461, 106);
            label8.Name = "label8";
            label8.Size = new Size(104, 22);
            label8.TabIndex = 12;
            label8.Text = "Telefon No:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(461, 50);
            label7.Name = "label7";
            label7.Size = new Size(93, 22);
            label7.TabIndex = 11;
            label7.Text = "Sahip Adı:";
            // 
            // txtSahip
            // 
            txtSahip.Location = new Point(580, 47);
            txtSahip.Name = "txtSahip";
            txtSahip.Size = new Size(180, 29);
            txtSahip.TabIndex = 10;
            // 
            // rbDisi
            // 
            rbDisi.AutoSize = true;
            rbDisi.ForeColor = Color.WhiteSmoke;
            rbDisi.Location = new Point(269, 284);
            rbDisi.Name = "rbDisi";
            rbDisi.Size = new Size(60, 26);
            rbDisi.TabIndex = 9;
            rbDisi.TabStop = true;
            rbDisi.Text = "Dişi";
            rbDisi.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.ForeColor = Color.WhiteSmoke;
            rbErkek.Location = new Point(155, 284);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(80, 26);
            rbErkek.TabIndex = 8;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(42, 284);
            label6.Name = "label6";
            label6.Size = new Size(81, 22);
            label6.TabIndex = 7;
            label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(42, 165);
            label5.Name = "label5";
            label5.Size = new Size(46, 22);
            label5.TabIndex = 6;
            label5.Text = "Tür:";
            // 
            // cmbTur
            // 
            cmbTur.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTur.FormattingEnabled = true;
            cmbTur.Location = new Point(155, 160);
            cmbTur.Name = "cmbTur";
            cmbTur.Size = new Size(200, 30);
            cmbTur.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(42, 106);
            label4.Name = "label4";
            label4.Size = new Size(109, 22);
            label4.TabIndex = 4;
            label4.Text = "Hayvan Adı:";
            // 
            // txtHayvanAdi
            // 
            txtHayvanAdi.Location = new Point(155, 103);
            txtHayvanAdi.Name = "txtHayvanAdi";
            txtHayvanAdi.Size = new Size(200, 29);
            txtHayvanAdi.TabIndex = 4;
            // 
            // txtChipNo
            // 
            txtChipNo.Location = new Point(155, 44);
            txtChipNo.Name = "txtChipNo";
            txtChipNo.ReadOnly = true;
            txtChipNo.Size = new Size(200, 29);
            txtChipNo.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(42, 47);
            label3.Name = "label3";
            label3.Size = new Size(73, 22);
            label3.TabIndex = 4;
            label3.Text = "Çip No:";
            // 
            // hastaListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 810);
            Controls.Add(grpHastaBilgileri);
            Controls.Add(grpListe);
            Controls.Add(grpArama);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "hastaListele";
            Text = "hastaListele";
            Load += hastaListele_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            grpArama.ResumeLayout(false);
            grpArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHayvanlar).EndInit();
            grpHastaBilgileri.ResumeLayout(false);
            grpHastaBilgileri.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button button6;
        private Button btnKapat;
        private GroupBox grpArama;
        private Label label2;
        private GroupBox grpListe;
        private GroupBox grpHastaBilgileri;
        private ComboBox cmbFiltreTur;
        private Button btnAra;
        private DataGridView dgvHayvanlar;
        private Label label4;
        private TextBox txtHayvanAdi;
        private TextBox txtChipNo;
        private Label label3;
        private RadioButton rbDisi;
        private RadioButton rbErkek;
        private Label label6;
        private Label label5;
        private TextBox txtAdres;
        private Label label9;
        private TextBox mskTelefon;
        private Label label8;
        private Label label7;
        private TextBox txtSahip;
        private Label label10;
        private TextBox txtNotlar;
        private Label Irk;
        private TextBox txtIrk;
        private Button btnSil;
        private Button btnGuncelle;
        private ComboBox cmbTur;
        private DataGridView dataGridView1;
        private PictureBox pictureBox3;
        private ComboBox cmbChipNo;
    }
}