namespace evcilHayvanSaglikTakibi
{
    partial class RaporIstatistikForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporIstatistikForm));
            panel1 = new Panel();
            button2 = new Button();
            btnKapat = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button6 = new Button();
            lblToplamHasta = new Label();
            lblToplamIslem = new Label();
            lblToplamKazanc = new Label();
            lblBugunKazanc = new Label();
            dtBaslangic = new DateTimePicker();
            dtBitis = new DateTimePicker();
            btnFiltrele = new Button();
            dataGridViewRapor = new DataGridView();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRapor).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnKapat);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button6);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1399, 68);
            panel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.SteelBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(1324, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 68);
            button2.TabIndex = 6;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnKapat
            // 
            btnKapat.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKapat.BackColor = Color.Crimson;
            btnKapat.Cursor = Cursors.Hand;
            btnKapat.FlatAppearance.BorderSize = 0;
            btnKapat.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKapat.Location = new Point(2397, 0);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(75, 68);
            btnKapat.TabIndex = 5;
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
            button1.Location = new Point(3395, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 68);
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(393, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.NavajoWhite;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(384, 40);
            label1.TabIndex = 3;
            label1.Text = "Rapor / İstatistik Formu";
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button6.BackColor = Color.Crimson;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.Font = new Font("Times New Roman", 39.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.Location = new Point(4585, 0);
            button6.Name = "button6";
            button6.Size = new Size(80, 80);
            button6.TabIndex = 2;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            // 
            // lblToplamHasta
            // 
            lblToplamHasta.AutoSize = true;
            lblToplamHasta.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lblToplamHasta.Location = new Point(40, 33);
            lblToplamHasta.Name = "lblToplamHasta";
            lblToplamHasta.RightToLeft = RightToLeft.Yes;
            lblToplamHasta.Size = new Size(144, 22);
            lblToplamHasta.TabIndex = 4;
            lblToplamHasta.Text = "Toplam Hasta: 0";
            // 
            // lblToplamIslem
            // 
            lblToplamIslem.AutoSize = true;
            lblToplamIslem.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lblToplamIslem.Location = new Point(40, 82);
            lblToplamIslem.Name = "lblToplamIslem";
            lblToplamIslem.Size = new Size(140, 22);
            lblToplamIslem.TabIndex = 5;
            lblToplamIslem.Text = "Toplam İşlem: 0";
            // 
            // lblToplamKazanc
            // 
            lblToplamKazanc.AutoSize = true;
            lblToplamKazanc.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lblToplamKazanc.Location = new Point(40, 136);
            lblToplamKazanc.Name = "lblToplamKazanc";
            lblToplamKazanc.Size = new Size(172, 22);
            lblToplamKazanc.TabIndex = 6;
            lblToplamKazanc.Text = "Toplam Kazanç: 0 ₺";
            // 
            // lblBugunKazanc
            // 
            lblBugunKazanc.AutoSize = true;
            lblBugunKazanc.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            lblBugunKazanc.Location = new Point(40, 191);
            lblBugunKazanc.Name = "lblBugunKazanc";
            lblBugunKazanc.Size = new Size(185, 22);
            lblBugunKazanc.TabIndex = 7;
            lblBugunKazanc.Text = "Bugünkü Kazanç: 0 ₺";
            // 
            // dtBaslangic
            // 
            dtBaslangic.Location = new Point(351, 59);
            dtBaslangic.Name = "dtBaslangic";
            dtBaslangic.Size = new Size(200, 23);
            dtBaslangic.TabIndex = 8;
            // 
            // dtBitis
            // 
            dtBitis.Location = new Point(351, 147);
            dtBitis.Name = "dtBitis";
            dtBitis.Size = new Size(200, 23);
            dtBitis.TabIndex = 9;
            // 
            // btnFiltrele
            // 
            btnFiltrele.BackColor = Color.NavajoWhite;
            btnFiltrele.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            btnFiltrele.ForeColor = Color.Black;
            btnFiltrele.Location = new Point(351, 200);
            btnFiltrele.Name = "btnFiltrele";
            btnFiltrele.Size = new Size(123, 44);
            btnFiltrele.TabIndex = 10;
            btnFiltrele.Text = "Filtrele";
            btnFiltrele.UseVisualStyleBackColor = false;
            btnFiltrele.Click += btnFiltrele_Click;
            // 
            // dataGridViewRapor
            // 
            dataGridViewRapor.AllowUserToAddRows = false;
            dataGridViewRapor.AllowUserToDeleteRows = false;
            dataGridViewRapor.AllowUserToResizeRows = false;
            dataGridViewRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRapor.Location = new Point(40, 276);
            dataGridViewRapor.MultiSelect = false;
            dataGridViewRapor.Name = "dataGridViewRapor";
            dataGridViewRapor.ReadOnly = true;
            dataGridViewRapor.RowHeadersVisible = false;
            dataGridViewRapor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRapor.Size = new Size(1266, 314);
            dataGridViewRapor.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnFiltrele);
            panel2.Controls.Add(dataGridViewRapor);
            panel2.Controls.Add(dtBitis);
            panel2.Controls.Add(lblBugunKazanc);
            panel2.Controls.Add(lblToplamKazanc);
            panel2.Controls.Add(dtBaslangic);
            panel2.Controls.Add(lblToplamIslem);
            panel2.Controls.Add(lblToplamHasta);
            panel2.ForeColor = Color.WhiteSmoke;
            panel2.Location = new Point(12, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(1348, 645);
            panel2.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(351, 110);
            label6.Name = "label6";
            label6.Size = new Size(101, 22);
            label6.TabIndex = 25;
            label6.Text = "Bitiş Tarihi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Underline);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(351, 21);
            label5.Name = "label5";
            label5.Size = new Size(144, 22);
            label5.TabIndex = 24;
            label5.Text = "Başlangıç Tarihi";
            // 
            // RaporIstatistikForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 810);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RaporIstatistikForm";
            Text = "RaporIstatistikForm";
            Load += RaporIstatistikForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRapor).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnKapat;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button6;
        private Button button2;
        private Label lblToplamHasta;
        private Label lblToplamIslem;
        private Label lblToplamKazanc;
        private Label lblBugunKazanc;
        private DateTimePicker dtBaslangic;
        private DateTimePicker dtBitis;
        private Button btnFiltrele;
        private DataGridView dataGridViewRapor;
        private Panel panel2;
        private Label label5;
        private Label label6;
    }
}