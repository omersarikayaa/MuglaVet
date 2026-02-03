namespace evcilHayvanSaglikTakibi
{
    partial class UcretTakipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcretTakipForm));
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            btnKapat = new Button();
            button1 = new Button();
            label1 = new Label();
            button6 = new Button();
            dataGridViewUcret = new DataGridView();
            cmbChipNo = new ComboBox();
            txtIslemAdi = new TextBox();
            txtTutar = new TextBox();
            chkOdendi = new CheckBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblGunluk = new Label();
            lblAylik = new Label();
            lblYillik = new Label();
            chkOdenenler = new CheckBox();
            dtBaslangic = new DateTimePicker();
            dtBitis = new DateTimePicker();
            btnFiltrele = new Button();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUcret).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(btnKapat);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button6);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1397, 68);
            panel1.TabIndex = 2;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(305, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(68, 62);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // btnKapat
            // 
            btnKapat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKapat.BackColor = Color.SteelBlue;
            btnKapat.Cursor = Cursors.Hand;
            btnKapat.FlatAppearance.BorderSize = 0;
            btnKapat.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKapat.Location = new Point(1322, 0);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(75, 68);
            btnKapat.TabIndex = 5;
            btnKapat.Text = "X";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Crimson;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(2320, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 68);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold);
            label1.ForeColor = Color.NavajoWhite;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(296, 40);
            label1.TabIndex = 3;
            label1.Text = "Ücret Takip Paneli";
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.BackColor = Color.Crimson;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.Font = new Font("Times New Roman", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.Location = new Point(3510, 0);
            button6.Name = "button6";
            button6.Size = new Size(80, 80);
            button6.TabIndex = 2;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            // 
            // dataGridViewUcret
            // 
            dataGridViewUcret.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUcret.BackgroundColor = Color.Silver;
            dataGridViewUcret.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUcret.Location = new Point(41, 359);
            dataGridViewUcret.Name = "dataGridViewUcret";
            dataGridViewUcret.ReadOnly = true;
            dataGridViewUcret.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUcret.Size = new Size(1250, 270);
            dataGridViewUcret.TabIndex = 3;
            dataGridViewUcret.CellClick += dataGridViewUcret_CellClick;
            // 
            // cmbChipNo
            // 
            cmbChipNo.FormattingEnabled = true;
            cmbChipNo.Location = new Point(41, 54);
            cmbChipNo.Name = "cmbChipNo";
            cmbChipNo.Size = new Size(162, 23);
            cmbChipNo.TabIndex = 4;
            // 
            // txtIslemAdi
            // 
            txtIslemAdi.Location = new Point(41, 222);
            txtIslemAdi.Name = "txtIslemAdi";
            txtIslemAdi.Size = new Size(162, 23);
            txtIslemAdi.TabIndex = 5;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(41, 143);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(162, 23);
            txtTutar.TabIndex = 6;
            // 
            // chkOdendi
            // 
            chkOdendi.AutoSize = true;
            chkOdendi.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkOdendi.ForeColor = Color.WhiteSmoke;
            chkOdendi.Location = new Point(41, 262);
            chkOdendi.Name = "chkOdendi";
            chkOdendi.Size = new Size(100, 34);
            chkOdendi.TabIndex = 7;
            chkOdendi.Text = "Ödendi";
            chkOdendi.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.NavajoWhite;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnEkle.ForeColor = SystemColors.ActiveCaptionText;
            btnEkle.Location = new Point(259, 47);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(128, 38);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.NavajoWhite;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnGuncelle.Location = new Point(259, 128);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(128, 38);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.NavajoWhite;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnSil.ForeColor = Color.Red;
            btnSil.Location = new Point(259, 207);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(128, 38);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(41, 185);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 11;
            label2.Text = "İşlem Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(41, 16);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 12;
            label3.Text = "Çip No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Underline);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(41, 97);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 13;
            label4.Text = "İşlem Tutarı";
            // 
            // lblGunluk
            // 
            lblGunluk.AutoSize = true;
            lblGunluk.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGunluk.ForeColor = Color.Black;
            lblGunluk.Location = new Point(0, 16);
            lblGunluk.Name = "lblGunluk";
            lblGunluk.Size = new Size(176, 25);
            lblGunluk.TabIndex = 14;
            lblGunluk.Text = "Günlük Kazanç: 0 ₺";
            // 
            // lblAylik
            // 
            lblAylik.AutoSize = true;
            lblAylik.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAylik.ForeColor = Color.Black;
            lblAylik.Location = new Point(0, 132);
            lblAylik.Name = "lblAylik";
            lblAylik.Size = new Size(158, 25);
            lblAylik.TabIndex = 15;
            lblAylik.Text = "Aylık Kazanç: 0 ₺";
            // 
            // lblYillik
            // 
            lblYillik.AutoSize = true;
            lblYillik.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYillik.ForeColor = Color.Black;
            lblYillik.Location = new Point(0, 78);
            lblYillik.Name = "lblYillik";
            lblYillik.Size = new Size(156, 25);
            lblYillik.TabIndex = 16;
            lblYillik.Text = "Yıllık Kazanç: 0 ₺";
            // 
            // chkOdenenler
            // 
            chkOdenenler.AutoSize = true;
            chkOdenenler.Location = new Point(965, 165);
            chkOdenenler.Name = "chkOdenenler";
            chkOdenenler.Size = new Size(122, 19);
            chkOdenenler.TabIndex = 17;
            chkOdenenler.Text = "Ödenenleri Filtrele";
            chkOdenenler.UseVisualStyleBackColor = true;
            // 
            // dtBaslangic
            // 
            dtBaslangic.Location = new Point(559, 62);
            dtBaslangic.Name = "dtBaslangic";
            dtBaslangic.Size = new Size(200, 23);
            dtBaslangic.TabIndex = 18;
            // 
            // dtBitis
            // 
            dtBitis.Location = new Point(559, 140);
            dtBitis.Name = "dtBitis";
            dtBitis.Size = new Size(200, 23);
            dtBitis.TabIndex = 19;
            // 
            // btnFiltrele
            // 
            btnFiltrele.BackColor = Color.NavajoWhite;
            btnFiltrele.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnFiltrele.Location = new Point(559, 196);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(90, 38);
            btnFiltrele.TabIndex = 20;
            btnFiltrele.Text = "Filtrele";
            btnFiltrele.UseVisualStyleBackColor = false;
            btnFiltrele.Click += btnFiltrele_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnFiltrele);
            panel2.Controls.Add(dtBitis);
            panel2.Controls.Add(btnEkle);
            panel2.Controls.Add(dtBaslangic);
            panel2.Controls.Add(btnSil);
            panel2.Controls.Add(chkOdenenler);
            panel2.Controls.Add(btnGuncelle);
            panel2.Controls.Add(cmbChipNo);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtIslemAdi);
            panel2.Controls.Add(dataGridViewUcret);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtTutar);
            panel2.Controls.Add(chkOdendi);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(25, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(1347, 675);
            panel2.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(559, 100);
            label6.Name = "label6";
            label6.Size = new Size(101, 22);
            label6.TabIndex = 24;
            label6.Text = "Bitiş Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(559, 19);
            label5.Name = "label5";
            label5.Size = new Size(144, 22);
            label5.TabIndex = 23;
            label5.Text = "Başlangıç Tarihi";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightCyan;
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(lblYillik);
            panel3.Controls.Add(lblAylik);
            panel3.Controls.Add(lblGunluk);
            panel3.Location = new Point(921, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(370, 172);
            panel3.TabIndex = 22;
            // 
            // panel7
            // 
            panel7.BackColor = Color.SteelBlue;
            panel7.Location = new Point(0, 103);
            panel7.Name = "panel7";
            panel7.Size = new Size(367, 10);
            panel7.TabIndex = 21;
            panel7.Paint += panel7_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.SteelBlue;
            panel6.Location = new Point(0, 160);
            panel6.Name = "panel6";
            panel6.Size = new Size(370, 10);
            panel6.TabIndex = 20;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SteelBlue;
            panel4.Location = new Point(0, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(367, 10);
            panel4.TabIndex = 18;
            panel4.Paint += panel4_Paint;
            // 
            // UcretTakipForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 810);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UcretTakipForm";
            Text = "UcretTakipForm";
            Load += UcretTakipForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUcret).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button button6;
        private Button btnKapat;
        private DataGridView dataGridViewUcret;
        private ComboBox cmbChipNo;
        private TextBox txtIslemAdi;
        private TextBox txtTutar;
        private CheckBox chkOdendi;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblGunluk;
        private Label lblAylik;
        private Label lblYillik;
        private CheckBox chkOdenenler;
        private DateTimePicker dtBaslangic;
        private DateTimePicker dtBitis;
        private Button btnFiltrele;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox6;
        private Panel panel4;
        private Panel panel7;
        private Panel panel6;
        private Label label6;
        private Label label5;
    }
}