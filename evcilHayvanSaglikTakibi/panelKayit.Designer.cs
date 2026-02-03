namespace evcilHayvanSaglikTakibi
{
    partial class panelKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(panelKayit));
            panel1 = new Panel();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            txtSifreTekrar = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnKayitOl = new Button();
            checkOnayliyorum = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 60);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.SteelBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(544, 0);
            button2.Name = "button2";
            button2.Size = new Size(64, 60);
            button2.TabIndex = 9;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.NavajoWhite;
            label1.Location = new Point(63, 9);
            label1.Name = "label1";
            label1.Size = new Size(393, 36);
            label1.TabIndex = 0;
            label1.Text = "Veteriner Hesap Oluşturma";
            label1.MouseDown += panel1_MouseDown;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(63, 135);
            txtKullaniciAdi.Multiline = true;
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(210, 34);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(63, 235);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(210, 23);
            txtSifre.TabIndex = 2;
            txtSifre.UseSystemPasswordChar = true;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(63, 335);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.PasswordChar = '*';
            txtSifreTekrar.Size = new Size(210, 23);
            txtSifreTekrar.TabIndex = 3;
            txtSifreTekrar.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(63, 96);
            label2.Name = "label2";
            label2.Size = new Size(125, 24);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(63, 203);
            label3.Name = "label3";
            label3.Size = new Size(52, 24);
            label3.TabIndex = 5;
            label3.Text = "Şifre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(63, 301);
            label4.Name = "label4";
            label4.Size = new Size(116, 24);
            label4.TabIndex = 6;
            label4.Text = "Şifre Tekrar";
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.NavajoWhite;
            btnKayitOl.Cursor = Cursors.Hand;
            btnKayitOl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKayitOl.Location = new Point(63, 452);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(116, 47);
            btnKayitOl.TabIndex = 7;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // checkOnayliyorum
            // 
            checkOnayliyorum.AutoSize = true;
            checkOnayliyorum.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            checkOnayliyorum.Location = new Point(63, 406);
            checkOnayliyorum.Name = "checkOnayliyorum";
            checkOnayliyorum.Size = new Size(98, 19);
            checkOnayliyorum.TabIndex = 8;
            checkOnayliyorum.Text = "Onaylıyorum";
            checkOnayliyorum.UseVisualStyleBackColor = true;
            // 
            // panelKayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 539);
            Controls.Add(checkOnayliyorum);
            Controls.Add(btnKayitOl);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSifreTekrar);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "panelKayit";
            Text = "panelKayit";
            Load += panelKayit_Load;
            MouseDown += panel1_MouseDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private TextBox txtSifreTekrar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnKayitOl;
        private CheckBox checkOnayliyorum;
        private Button button2;
    }
}