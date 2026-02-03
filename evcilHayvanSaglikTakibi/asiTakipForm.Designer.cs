namespace evcilHayvanSaglikTakibi
{
    partial class asiTakipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(asiTakipForm));
            panelUst = new Panel();
            pictureBox4 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            button6 = new Button();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtAsiAdi = new TextBox();
            dtpAsiTarihi = new DateTimePicker();
            dtpSonrakiAsiTarihi = new DateTimePicker();
            label4 = new Label();
            rtxtAciklama = new TextBox();
            label5 = new Label();
            dgvAsilar = new DataGridView();
            btnAsiKaydet = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            dgvYaklasanAsilar = new DataGridView();
            cmbGun = new ComboBox();
            btnYaklasanAsilar = new Button();
            panel1 = new Panel();
            cmbChipNo = new ComboBox();
            panel2 = new Panel();
            panelUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAsilar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvYaklasanAsilar).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelUst
            // 
            panelUst.Anchor = AnchorStyles.Top;
            panelUst.BackColor = Color.SteelBlue;
            panelUst.Controls.Add(pictureBox4);
            panelUst.Controls.Add(button2);
            panelUst.Controls.Add(button1);
            panelUst.Controls.Add(label1);
            panelUst.Controls.Add(button6);
            panelUst.Location = new Point(-1, 0);
            panelUst.Name = "panelUst";
            panelUst.Size = new Size(1398, 68);
            panelUst.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(270, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(69, 62);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.SteelBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(1323, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 68);
            button2.TabIndex = 5;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Crimson;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(2116, 0);
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
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(261, 40);
            label1.TabIndex = 3;
            label1.Text = "Aşı Takip Paneli";
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.BackColor = Color.Crimson;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.Font = new Font("Times New Roman", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.Location = new Point(3303, 0);
            button6.Name = "button6";
            button6.Size = new Size(80, 80);
            button6.TabIndex = 2;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(410, 35);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(95, 22);
            label8.TabIndex = 29;
            label8.Text = "Aşı Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(108, 97);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(73, 22);
            label3.TabIndex = 24;
            label3.Text = "Aşı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(108, 33);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(73, 22);
            label2.TabIndex = 23;
            label2.Text = "Çip No:";
            // 
            // txtAsiAdi
            // 
            txtAsiAdi.Location = new Point(187, 99);
            txtAsiAdi.Name = "txtAsiAdi";
            txtAsiAdi.Size = new Size(200, 23);
            txtAsiAdi.TabIndex = 16;
            // 
            // dtpAsiTarihi
            // 
            dtpAsiTarihi.Location = new Point(582, 34);
            dtpAsiTarihi.Name = "dtpAsiTarihi";
            dtpAsiTarihi.Size = new Size(200, 23);
            dtpAsiTarihi.TabIndex = 30;
            // 
            // dtpSonrakiAsiTarihi
            // 
            dtpSonrakiAsiTarihi.Location = new Point(582, 100);
            dtpSonrakiAsiTarihi.Name = "dtpSonrakiAsiTarihi";
            dtpSonrakiAsiTarihi.Size = new Size(200, 23);
            dtpSonrakiAsiTarihi.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(410, 100);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(166, 22);
            label4.TabIndex = 32;
            label4.Text = "Gelecek Aşı Tarihi:";
            // 
            // rtxtAciklama
            // 
            rtxtAciklama.BackColor = SystemColors.Window;
            rtxtAciklama.Location = new Point(955, 31);
            rtxtAciklama.Multiline = true;
            rtxtAciklama.Name = "rtxtAciklama";
            rtxtAciklama.Size = new Size(267, 113);
            rtxtAciklama.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(847, 31);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(93, 22);
            label5.TabIndex = 34;
            label5.Text = "Açıklama:";
            // 
            // dgvAsilar
            // 
            dgvAsilar.Anchor = AnchorStyles.None;
            dgvAsilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsilar.BackgroundColor = Color.Silver;
            dgvAsilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsilar.Location = new Point(99, 161);
            dgvAsilar.Name = "dgvAsilar";
            dgvAsilar.ReadOnly = true;
            dgvAsilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsilar.Size = new Size(1123, 209);
            dgvAsilar.TabIndex = 35;
            dgvAsilar.CellClick += dgvAsilar_CellClick;
            // 
            // btnAsiKaydet
            // 
            btnAsiKaydet.BackColor = Color.NavajoWhite;
            btnAsiKaydet.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnAsiKaydet.Location = new Point(187, 395);
            btnAsiKaydet.Name = "btnAsiKaydet";
            btnAsiKaydet.Size = new Size(137, 40);
            btnAsiKaydet.TabIndex = 36;
            btnAsiKaydet.Text = "AŞI KAYDET";
            btnAsiKaydet.UseVisualStyleBackColor = false;
            btnAsiKaydet.Click += button3_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.NavajoWhite;
            btnSil.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnSil.ForeColor = Color.Red;
            btnSil.Location = new Point(1015, 395);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(137, 40);
            btnSil.TabIndex = 37;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.NavajoWhite;
            btnGuncelle.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnGuncelle.Location = new Point(582, 395);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(137, 40);
            btnGuncelle.TabIndex = 38;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // dgvYaklasanAsilar
            // 
            dgvYaklasanAsilar.Anchor = AnchorStyles.None;
            dgvYaklasanAsilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvYaklasanAsilar.BackgroundColor = Color.Silver;
            dgvYaklasanAsilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYaklasanAsilar.Location = new Point(99, 16);
            dgvYaklasanAsilar.Name = "dgvYaklasanAsilar";
            dgvYaklasanAsilar.ReadOnly = true;
            dgvYaklasanAsilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYaklasanAsilar.Size = new Size(872, 189);
            dgvYaklasanAsilar.TabIndex = 39;
            // 
            // cmbGun
            // 
            cmbGun.FormattingEnabled = true;
            cmbGun.Items.AddRange(new object[] { "7", "15", "30" });
            cmbGun.Location = new Point(1022, 46);
            cmbGun.Name = "cmbGun";
            cmbGun.Size = new Size(130, 23);
            cmbGun.TabIndex = 40;
            // 
            // btnYaklasanAsilar
            // 
            btnYaklasanAsilar.BackColor = Color.NavajoWhite;
            btnYaklasanAsilar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnYaklasanAsilar.Location = new Point(1022, 111);
            btnYaklasanAsilar.Name = "btnYaklasanAsilar";
            btnYaklasanAsilar.Size = new Size(137, 57);
            btnYaklasanAsilar.TabIndex = 41;
            btnYaklasanAsilar.Text = "Yaklaşan Aşılar";
            btnYaklasanAsilar.UseVisualStyleBackColor = false;
            btnYaklasanAsilar.Click += btnYaklasanAsilar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(cmbChipNo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtAsiAdi);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnSil);
            panel1.Controls.Add(btnGuncelle);
            panel1.Controls.Add(dtpAsiTarihi);
            panel1.Controls.Add(dtpSonrakiAsiTarihi);
            panel1.Controls.Add(btnAsiKaydet);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dgvAsilar);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(rtxtAciklama);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(31, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(1323, 458);
            panel1.TabIndex = 42;
            // 
            // cmbChipNo
            // 
            cmbChipNo.FormattingEnabled = true;
            cmbChipNo.Location = new Point(187, 34);
            cmbChipNo.Name = "cmbChipNo";
            cmbChipNo.Size = new Size(200, 23);
            cmbChipNo.TabIndex = 39;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(cmbGun);
            panel2.Controls.Add(btnYaklasanAsilar);
            panel2.Controls.Add(dgvYaklasanAsilar);
            panel2.Location = new Point(31, 567);
            panel2.Name = "panel2";
            panel2.Size = new Size(1323, 219);
            panel2.TabIndex = 43;
            // 
            // asiTakipForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 810);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelUst);
            FormBorderStyle = FormBorderStyle.None;
            Name = "asiTakipForm";
            Text = "asiTakipForm";
            panelUst.ResumeLayout(false);
            panelUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAsilar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvYaklasanAsilar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUst;
        private Button button1;
        private Label label1;
        private Button button6;
        private Button button2;
        private Label label8;
        private Label label3;
        private Label label2;
        private TextBox txtAsiAdi;
        private DateTimePicker dtpAsiTarihi;
        private DateTimePicker dtpSonrakiAsiTarihi;
        private Label label4;
        private TextBox rtxtAciklama;
        private Label label5;
        private DataGridView dgvAsilar;
        private Button btnAsiKaydet;
        private Button btnSil;
        private Button btnGuncelle;
        private DataGridView dgvYaklasanAsilar;
        private ComboBox cmbGun;
        private Button btnYaklasanAsilar;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Panel panel2;
        private ComboBox cmbChipNo;
    }
}