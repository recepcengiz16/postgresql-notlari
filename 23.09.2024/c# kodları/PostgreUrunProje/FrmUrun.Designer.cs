namespace PostgreUrunProje
{
    partial class FrmUrun
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
            txtUrunAd = new TextBox();
            label2 = new Label();
            txtUrunId = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtAlisFiyat = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtGorsel = new TextBox();
            label5 = new Label();
            txtSatisFiyat = new TextBox();
            label6 = new Label();
            label7 = new Label();
            stok = new NumericUpDown();
            comboBox1 = new ComboBox();
            btnAra = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            btnListele = new Button();
            btnView = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stok).BeginInit();
            SuspendLayout();
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(774, 95);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(142, 27);
            txtUrunAd.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(685, 97);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 14;
            label2.Text = "Ürün Ad:";
            // 
            // txtUrunId
            // 
            txtUrunId.Location = new Point(774, 62);
            txtUrunId.Name = "txtUrunId";
            txtUrunId.Size = new Size(142, 27);
            txtUrunId.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(689, 64);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 12;
            label1.Text = "Ürün ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(607, 338);
            dataGridView1.TabIndex = 10;
            // 
            // txtAlisFiyat
            // 
            txtAlisFiyat.Location = new Point(774, 161);
            txtAlisFiyat.Name = "txtAlisFiyat";
            txtAlisFiyat.Size = new Size(142, 27);
            txtAlisFiyat.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(680, 163);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 22;
            label3.Text = "Alış Fiyat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(710, 130);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 20;
            label4.Text = "Stok:";
            // 
            // txtGorsel
            // 
            txtGorsel.Location = new Point(774, 227);
            txtGorsel.Name = "txtGorsel";
            txtGorsel.Size = new Size(142, 27);
            txtGorsel.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(697, 229);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 26;
            label5.Text = "Görsel:";
            // 
            // txtSatisFiyat
            // 
            txtSatisFiyat.Location = new Point(774, 194);
            txtSatisFiyat.Name = "txtSatisFiyat";
            txtSatisFiyat.Size = new Size(142, 27);
            txtSatisFiyat.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(673, 196);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 24;
            label6.Text = "Satış Fiyat:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(682, 262);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 28;
            label7.Text = "Kategori:";
            // 
            // stok
            // 
            stok.Location = new Point(774, 128);
            stok.Name = "stok";
            stok.Size = new Size(142, 27);
            stok.TabIndex = 29;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(774, 262);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 28);
            comboBox1.TabIndex = 30;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(957, 203);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(142, 30);
            btnAra.TabIndex = 35;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(957, 167);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(142, 30);
            btnGuncelle.TabIndex = 34;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(957, 131);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(142, 30);
            btnSil.TabIndex = 33;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(957, 95);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(142, 30);
            btnEkle.TabIndex = 32;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(957, 59);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(142, 30);
            btnListele.TabIndex = 31;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(957, 239);
            btnView.Name = "btnView";
            btnView.Size = new Size(142, 30);
            btnView.TabIndex = 36;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // FrmUrun
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 450);
            Controls.Add(btnView);
            Controls.Add(btnAra);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(btnListele);
            Controls.Add(comboBox1);
            Controls.Add(stok);
            Controls.Add(label7);
            Controls.Add(txtGorsel);
            Controls.Add(label5);
            Controls.Add(txtSatisFiyat);
            Controls.Add(label6);
            Controls.Add(txtAlisFiyat);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtUrunAd);
            Controls.Add(label2);
            Controls.Add(txtUrunId);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmUrun";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUrun";
            Load += FrmUrun_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)stok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUrunAd;
        private Label label2;
        private TextBox txtUrunId;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtAlisFiyat;
        private Label label3;
        private Label label4;
        private TextBox txtGorsel;
        private Label label5;
        private TextBox txtSatisFiyat;
        private Label label6;
        private Label label7;
        private NumericUpDown stok;
        private ComboBox comboBox1;
        private Button btnAra;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Button btnListele;
        private Button btnView;
    }
}