namespace evcilHayvanSaglikTakibi
{
    partial class hastalikTakipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hastalikTakipForm));
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            button6 = new Button();
            label2 = new Label();
            txtTeshis = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dtpMuayeneTarihi = new DateTimePicker();
            dtpKontrolTarihi = new DateTimePicker();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            rtxtTedavi = new RichTextBox();
            label7 = new Label();
            txtVeteriner = new TextBox();
            cmbDurum = new ComboBox();
            rtxtAciklama = new TextBox();
            label9 = new Label();
            dgvHastaliklar = new DataGridView();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            ellipseTool1 = new ModernUI.EllipseTool();
            panel2 = new Panel();
            cmbChipNo = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHastaliklar).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button6);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1398, 68);
            panel1.TabIndex = 2;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(307, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(65, 62);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.SteelBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(1320, 0);
            button2.Name = "button2";
            button2.Size = new Size(78, 68);
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
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(301, 40);
            label1.TabIndex = 3;
            label1.Text = "Hasta Takip Paneli";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(88, 33);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(73, 22);
            label2.TabIndex = 24;
            label2.Text = "Çip No:";
            // 
            // txtTeshis
            // 
            txtTeshis.Location = new Point(198, 94);
            txtTeshis.Multiline = true;
            txtTeshis.Name = "txtTeshis";
            txtTeshis.Size = new Size(200, 29);
            txtTeshis.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(88, 92);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(66, 22);
            label3.TabIndex = 26;
            label3.Text = "Teşhis:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(876, 155);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(69, 22);
            label4.TabIndex = 28;
            label4.Text = "Tedavi:";
            // 
            // dtpMuayeneTarihi
            // 
            dtpMuayeneTarihi.Location = new Point(633, 36);
            dtpMuayeneTarihi.Name = "dtpMuayeneTarihi";
            dtpMuayeneTarihi.Size = new Size(200, 23);
            dtpMuayeneTarihi.TabIndex = 31;
            // 
            // dtpKontrolTarihi
            // 
            dtpKontrolTarihi.Location = new Point(633, 95);
            dtpKontrolTarihi.Name = "dtpKontrolTarihi";
            dtpKontrolTarihi.Size = new Size(200, 23);
            dtpKontrolTarihi.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(446, 37);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(144, 22);
            label8.TabIndex = 33;
            label8.Text = "Muayene Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(446, 98);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(132, 22);
            label5.TabIndex = 34;
            label5.Text = "Kontrol Tarihi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(88, 160);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(90, 22);
            label6.TabIndex = 35;
            label6.Text = "Veteriner:";
            // 
            // rtxtTedavi
            // 
            rtxtTedavi.Location = new Point(990, 157);
            rtxtTedavi.Name = "rtxtTedavi";
            rtxtTedavi.Size = new Size(201, 81);
            rtxtTedavi.TabIndex = 36;
            rtxtTedavi.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(446, 157);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(156, 22);
            label7.TabIndex = 37;
            label7.Text = "Hastalık Durumu:";
            // 
            // txtVeteriner
            // 
            txtVeteriner.Location = new Point(198, 160);
            txtVeteriner.Multiline = true;
            txtVeteriner.Name = "txtVeteriner";
            txtVeteriner.Size = new Size(200, 29);
            txtVeteriner.TabIndex = 38;
            // 
            // cmbDurum
            // 
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Items.AddRange(new object[] { "Devam Ediyor", "Kontrolde", "İyileşti" });
            cmbDurum.Location = new Point(633, 159);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(200, 23);
            cmbDurum.TabIndex = 39;
            // 
            // rtxtAciklama
            // 
            rtxtAciklama.Location = new Point(990, 36);
            rtxtAciklama.Multiline = true;
            rtxtAciklama.Name = "rtxtAciklama";
            rtxtAciklama.Size = new Size(201, 81);
            rtxtAciklama.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(876, 33);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(93, 22);
            label9.TabIndex = 41;
            label9.Text = "Açıklama:";
            // 
            // dgvHastaliklar
            // 
            dgvHastaliklar.AllowUserToAddRows = false;
            dgvHastaliklar.AllowUserToDeleteRows = false;
            dgvHastaliklar.Anchor = AnchorStyles.None;
            dgvHastaliklar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHastaliklar.BackgroundColor = Color.Silver;
            dgvHastaliklar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHastaliklar.Location = new Point(88, 281);
            dgvHastaliklar.MultiSelect = false;
            dgvHastaliklar.Name = "dgvHastaliklar";
            dgvHastaliklar.ReadOnly = true;
            dgvHastaliklar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHastaliklar.Size = new Size(1103, 235);
            dgvHastaliklar.TabIndex = 42;
            dgvHastaliklar.CellClick += dgvHastaliklar_CellClick;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.NavajoWhite;
            btnKaydet.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnKaydet.Location = new Point(198, 543);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(137, 40);
            btnKaydet.TabIndex = 43;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.NavajoWhite;
            btnGuncelle.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnGuncelle.Location = new Point(592, 543);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(137, 40);
            btnGuncelle.TabIndex = 44;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.NavajoWhite;
            btnSil.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnSil.ForeColor = Color.Red;
            btnSil.Location = new Point(990, 543);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(137, 40);
            btnSil.TabIndex = 45;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // ellipseTool1
            // 
            ellipseTool1.CornerRadius = 30;
            ellipseTool1.TargetControl = null;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(cmbChipNo);
            panel2.Controls.Add(rtxtTedavi);
            panel2.Controls.Add(btnSil);
            panel2.Controls.Add(txtTeshis);
            panel2.Controls.Add(btnGuncelle);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btnKaydet);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dgvHastaliklar);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(rtxtAciklama);
            panel2.Controls.Add(cmbDurum);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtVeteriner);
            panel2.Controls.Add(dtpMuayeneTarihi);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dtpKontrolTarihi);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(38, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(1300, 638);
            panel2.TabIndex = 47;
            // 
            // cmbChipNo
            // 
            cmbChipNo.FormattingEnabled = true;
            cmbChipNo.Location = new Point(198, 35);
            cmbChipNo.Name = "cmbChipNo";
            cmbChipNo.Size = new Size(200, 23);
            cmbChipNo.TabIndex = 47;
            // 
            // hastalikTakipForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 810);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "hastalikTakipForm";
            Text = "hastalikTakipForm";
            Load += hastalikTakipForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHastaliklar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Button button6;
        private Button button2;
        private Label label2;
        private TextBox txtTeshis;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpMuayeneTarihi;
        private DateTimePicker dtpKontrolTarihi;
        private Label label8;
        private Label label5;
        private Label label6;
        private RichTextBox rtxtTedavi;
        private Label label7;
        private TextBox txtVeteriner;
        private ComboBox cmbDurum;
        private TextBox rtxtAciklama;
        private Label label9;
        private DataGridView dgvHastaliklar;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Button btnSil;
        private ModernUI.EllipseTool ellipseTool1;
        private Panel panel2;
        private PictureBox pictureBox5;
        private ComboBox cmbChipNo;
    }
}