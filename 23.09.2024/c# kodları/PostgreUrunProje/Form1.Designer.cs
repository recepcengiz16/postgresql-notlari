namespace PostgreUrunProje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnListele = new Button();
            label1 = new Label();
            txtkategoriId = new TextBox();
            txtKategoriAd = new TextBox();
            label2 = new Label();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnAra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(680, 327);
            dataGridView1.TabIndex = 0;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(878, 124);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(142, 30);
            btnListele.TabIndex = 1;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(763, 26);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 2;
            label1.Text = "Kategori ID:";
            // 
            // txtkategoriId
            // 
            txtkategoriId.Location = new Point(878, 26);
            txtkategoriId.Name = "txtkategoriId";
            txtkategoriId.Size = new Size(142, 27);
            txtkategoriId.TabIndex = 3;
            // 
            // txtKategoriAd
            // 
            txtKategoriAd.Location = new Point(878, 59);
            txtKategoriAd.Name = "txtKategoriAd";
            txtKategoriAd.Size = new Size(142, 27);
            txtKategoriAd.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(763, 59);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 4;
            label2.Text = "Kategori Ad:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(878, 160);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(142, 30);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(878, 196);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(142, 30);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(878, 232);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(142, 30);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(878, 268);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(142, 30);
            btnAra.TabIndex = 9;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 382);
            Controls.Add(btnAra);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(txtKategoriAd);
            Controls.Add(label2);
            Controls.Add(txtkategoriId);
            Controls.Add(label1);
            Controls.Add(btnListele);
            Controls.Add(dataGridView1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnListele;
        private Label label1;
        private TextBox txtkategoriId;
        private TextBox txtKategoriAd;
        private Label label2;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnAra;
    }
}
