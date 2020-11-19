namespace Customer
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MenuList = new System.Windows.Forms.DataGridView();
            this.TopSeller = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NomorMeja = new System.Windows.Forms.ComboBox();
            this.grpbxPesan = new System.Windows.Forms.GroupBox();
            this.TombolPesan = new System.Windows.Forms.Button();
            this.nudJumlah = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TombolBayar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DaftarPesanan = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MenuList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopSeller)).BeginInit();
            this.grpbxPesan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaftarPesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News701 BT", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 28);
            this.label4.TabIndex = 67;
            this.label4.Text = "Daftar Pesanan";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(539, 350);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(49, 18);
            this.Total.TabIndex = 66;
            this.Total.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(438, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 18);
            this.label7.TabIndex = 65;
            this.label7.Text = "Total Harga :";
            // 
            // MenuList
            // 
            this.MenuList.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.MenuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuList.Location = new System.Drawing.Point(13, 222);
            this.MenuList.Name = "MenuList";
            this.MenuList.Size = new System.Drawing.Size(242, 156);
            this.MenuList.TabIndex = 56;
            this.MenuList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MenuList_CellClick);
            // 
            // TopSeller
            // 
            this.TopSeller.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.TopSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TopSeller.Location = new System.Drawing.Point(13, 83);
            this.TopSeller.MultiSelect = false;
            this.TopSeller.Name = "TopSeller";
            this.TopSeller.ReadOnly = true;
            this.TopSeller.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TopSeller.Size = new System.Drawing.Size(243, 101);
            this.TopSeller.TabIndex = 64;
            this.TopSeller.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TopSeller_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News701 BT", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 28);
            this.label1.TabIndex = 55;
            this.label1.Text = "Menu List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("News701 BT", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 28);
            this.label5.TabIndex = 63;
            this.label5.Text = "Top 3 Seller";
            // 
            // NomorMeja
            // 
            this.NomorMeja.FormattingEnabled = true;
            this.NomorMeja.Location = new System.Drawing.Point(129, 9);
            this.NomorMeja.Name = "NomorMeja";
            this.NomorMeja.Size = new System.Drawing.Size(52, 21);
            this.NomorMeja.TabIndex = 62;
            this.NomorMeja.SelectedIndexChanged += new System.EventHandler(this.NomorMeja_SelectedIndexChanged);
            this.NomorMeja.Leave += new System.EventHandler(this.NomorMeja_SelectedIndexChanged);
            // 
            // grpbxPesan
            // 
            this.grpbxPesan.BackColor = System.Drawing.Color.Transparent;
            this.grpbxPesan.Controls.Add(this.TombolPesan);
            this.grpbxPesan.Controls.Add(this.nudJumlah);
            this.grpbxPesan.Controls.Add(this.label2);
            this.grpbxPesan.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxPesan.Location = new System.Drawing.Point(274, 239);
            this.grpbxPesan.Name = "grpbxPesan";
            this.grpbxPesan.Size = new System.Drawing.Size(150, 139);
            this.grpbxPesan.TabIndex = 61;
            this.grpbxPesan.TabStop = false;
            // 
            // TombolPesan
            // 
            this.TombolPesan.BackColor = System.Drawing.Color.Teal;
            this.TombolPesan.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TombolPesan.ForeColor = System.Drawing.Color.White;
            this.TombolPesan.Location = new System.Drawing.Point(24, 77);
            this.TombolPesan.Name = "TombolPesan";
            this.TombolPesan.Size = new System.Drawing.Size(100, 39);
            this.TombolPesan.TabIndex = 4;
            this.TombolPesan.Text = "Pesan";
            this.TombolPesan.UseVisualStyleBackColor = false;
            this.TombolPesan.Click += new System.EventHandler(this.TombolPesan_Click);
            // 
            // nudJumlah
            // 
            this.nudJumlah.Location = new System.Drawing.Point(24, 44);
            this.nudJumlah.Name = "nudJumlah";
            this.nudJumlah.Size = new System.Drawing.Size(100, 20);
            this.nudJumlah.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jumlah";
            // 
            // TombolBayar
            // 
            this.TombolBayar.BackColor = System.Drawing.Color.Teal;
            this.TombolBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TombolBayar.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TombolBayar.ForeColor = System.Drawing.Color.White;
            this.TombolBayar.Location = new System.Drawing.Point(755, 350);
            this.TombolBayar.Name = "TombolBayar";
            this.TombolBayar.Size = new System.Drawing.Size(109, 28);
            this.TombolBayar.TabIndex = 59;
            this.TombolBayar.Text = "Bayar";
            this.TombolBayar.UseVisualStyleBackColor = false;
            this.TombolBayar.Click += new System.EventHandler(this.TombolBayar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 22);
            this.label3.TabIndex = 60;
            this.label3.Text = "Nomor Meja";
            // 
            // DaftarPesanan
            // 
            this.DaftarPesanan.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.DaftarPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaftarPesanan.Location = new System.Drawing.Point(441, 83);
            this.DaftarPesanan.MultiSelect = false;
            this.DaftarPesanan.Name = "DaftarPesanan";
            this.DaftarPesanan.ReadOnly = true;
            this.DaftarPesanan.Size = new System.Drawing.Size(423, 261);
            this.DaftarPesanan.TabIndex = 58;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(274, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(878, 401);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MenuList);
            this.Controls.Add(this.TopSeller);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NomorMeja);
            this.Controls.Add(this.grpbxPesan);
            this.Controls.Add(this.TombolBayar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DaftarPesanan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopSeller)).EndInit();
            this.grpbxPesan.ResumeLayout(false);
            this.grpbxPesan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudJumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaftarPesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView MenuList;
        private System.Windows.Forms.DataGridView TopSeller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox NomorMeja;
        private System.Windows.Forms.GroupBox grpbxPesan;
        private System.Windows.Forms.Button TombolPesan;
        private System.Windows.Forms.NumericUpDown nudJumlah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button TombolBayar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DaftarPesanan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

