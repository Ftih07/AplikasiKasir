namespace AplikasiKasir
{
    partial class FormKasir
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHargaMinuman = new System.Windows.Forms.TextBox();
            this.txtHargaMakanan = new System.Windows.Forms.TextBox();
            this.cbMinuman = new System.Windows.Forms.ComboBox();
            this.cbMakanan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamaKasir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SatuanMinuman = new System.Windows.Forms.NumericUpDown();
            this.SatuanMakanan = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSubTotalMinuman = new System.Windows.Forms.TextBox();
            this.txtSubTotalMakanan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtBayar = new System.Windows.Forms.TextBox();
            this.txtKembali = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btProses = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SatuanMinuman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatuanMakanan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "WARUNG MAKAN RAHAYU";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.txtHargaMinuman);
            this.groupBox1.Controls.Add(this.txtHargaMakanan);
            this.groupBox1.Controls.Add(this.cbMinuman);
            this.groupBox1.Controls.Add(this.cbMakanan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesan";
            // 
            // txtHargaMinuman
            // 
            this.txtHargaMinuman.Location = new System.Drawing.Point(248, 62);
            this.txtHargaMinuman.Name = "txtHargaMinuman";
            this.txtHargaMinuman.ReadOnly = true;
            this.txtHargaMinuman.Size = new System.Drawing.Size(151, 22);
            this.txtHargaMinuman.TabIndex = 5;
            this.txtHargaMinuman.Text = "0";
            this.txtHargaMinuman.TextChanged += new System.EventHandler(this.txtHargaMinuman_TextChanged);
            // 
            // txtHargaMakanan
            // 
            this.txtHargaMakanan.Location = new System.Drawing.Point(248, 30);
            this.txtHargaMakanan.Name = "txtHargaMakanan";
            this.txtHargaMakanan.ReadOnly = true;
            this.txtHargaMakanan.Size = new System.Drawing.Size(151, 22);
            this.txtHargaMakanan.TabIndex = 4;
            this.txtHargaMakanan.Text = "0";
            // 
            // cbMinuman
            // 
            this.cbMinuman.FormattingEnabled = true;
            this.cbMinuman.Location = new System.Drawing.Point(88, 60);
            this.cbMinuman.Name = "cbMinuman";
            this.cbMinuman.Size = new System.Drawing.Size(154, 24);
            this.cbMinuman.TabIndex = 3;
            this.cbMinuman.SelectedIndexChanged += new System.EventHandler(this.cbMinuman_SelectedIndexChanged);
            // 
            // cbMakanan
            // 
            this.cbMakanan.FormattingEnabled = true;
            this.cbMakanan.Location = new System.Drawing.Point(88, 30);
            this.cbMakanan.Name = "cbMakanan";
            this.cbMakanan.Size = new System.Drawing.Size(154, 24);
            this.cbMakanan.TabIndex = 2;
            this.cbMakanan.SelectedIndexChanged += new System.EventHandler(this.cbMakanan_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Minuman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Makanan";
            // 
            // txtNamaKasir
            // 
            this.txtNamaKasir.Location = new System.Drawing.Point(34, 249);
            this.txtNamaKasir.Name = "txtNamaKasir";
            this.txtNamaKasir.Size = new System.Drawing.Size(151, 22);
            this.txtNamaKasir.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nama Kasir";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.SatuanMinuman);
            this.groupBox2.Controls.Add(this.SatuanMakanan);
            this.groupBox2.Location = new System.Drawing.Point(437, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satuan";
            // 
            // SatuanMinuman
            // 
            this.SatuanMinuman.Location = new System.Drawing.Point(6, 58);
            this.SatuanMinuman.Name = "SatuanMinuman";
            this.SatuanMinuman.Size = new System.Drawing.Size(94, 22);
            this.SatuanMinuman.TabIndex = 1;
            this.SatuanMinuman.ValueChanged += new System.EventHandler(this.SatuanMinuman_ValueChanged);
            // 
            // SatuanMakanan
            // 
            this.SatuanMakanan.Location = new System.Drawing.Point(7, 30);
            this.SatuanMakanan.Name = "SatuanMakanan";
            this.SatuanMakanan.Size = new System.Drawing.Size(94, 22);
            this.SatuanMakanan.TabIndex = 0;
            this.SatuanMakanan.ValueChanged += new System.EventHandler(this.SatuanMakanan_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.txtSubTotalMinuman);
            this.groupBox3.Controls.Add(this.txtSubTotalMakanan);
            this.groupBox3.Location = new System.Drawing.Point(550, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sub Total";
            // 
            // txtSubTotalMinuman
            // 
            this.txtSubTotalMinuman.Location = new System.Drawing.Point(6, 60);
            this.txtSubTotalMinuman.Name = "txtSubTotalMinuman";
            this.txtSubTotalMinuman.ReadOnly = true;
            this.txtSubTotalMinuman.Size = new System.Drawing.Size(226, 22);
            this.txtSubTotalMinuman.TabIndex = 7;
            this.txtSubTotalMinuman.Text = "0";
            this.txtSubTotalMinuman.TextChanged += new System.EventHandler(this.SubTotalMinuman_TextChanged);
            // 
            // txtSubTotalMakanan
            // 
            this.txtSubTotalMakanan.Location = new System.Drawing.Point(6, 28);
            this.txtSubTotalMakanan.Name = "txtSubTotalMakanan";
            this.txtSubTotalMakanan.ReadOnly = true;
            this.txtSubTotalMakanan.Size = new System.Drawing.Size(226, 22);
            this.txtSubTotalMakanan.TabIndex = 6;
            this.txtSubTotalMakanan.Text = "0";
            this.txtSubTotalMakanan.TextChanged += new System.EventHandler(this.SubTotalMakanan_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "TOTAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 252);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "BAYAR";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(481, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "KEMBALI";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(550, 221);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(238, 22);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.Text = "0";
            // 
            // txtBayar
            // 
            this.txtBayar.Location = new System.Drawing.Point(550, 252);
            this.txtBayar.Name = "txtBayar";
            this.txtBayar.Size = new System.Drawing.Size(238, 22);
            this.txtBayar.TabIndex = 11;
            this.txtBayar.Text = "0";
            this.txtBayar.TextChanged += new System.EventHandler(this.txtBayar_TextChanged);
            // 
            // txtKembali
            // 
            this.txtKembali.Location = new System.Drawing.Point(550, 282);
            this.txtKembali.Name = "txtKembali";
            this.txtKembali.ReadOnly = true;
            this.txtKembali.Size = new System.Drawing.Size(238, 22);
            this.txtKembali.TabIndex = 12;
            this.txtKembali.Text = "0";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(208, 340);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(97, 81);
            this.btClear.TabIndex = 13;
            this.btClear.Text = "CLEAR";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btProses
            // 
            this.btProses.Location = new System.Drawing.Point(320, 340);
            this.btProses.Name = "btProses";
            this.btProses.Size = new System.Drawing.Size(111, 81);
            this.btProses.TabIndex = 14;
            this.btProses.Text = "PROSES";
            this.btProses.UseVisualStyleBackColor = true;
            this.btProses.Click += new System.EventHandler(this.btProses_Click);
            // 
            // FormKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btProses);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.txtKembali);
            this.Controls.Add(this.txtBayar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNamaKasir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormKasir";
            this.Text = "p;";
            this.Load += new System.EventHandler(this.FormKasir_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SatuanMinuman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatuanMakanan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHargaMinuman;
        private System.Windows.Forms.TextBox txtHargaMakanan;
        private System.Windows.Forms.ComboBox cbMinuman;
        private System.Windows.Forms.ComboBox cbMakanan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamaKasir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtBayar;
        private System.Windows.Forms.TextBox txtKembali;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btProses;
        private System.Windows.Forms.NumericUpDown SatuanMinuman;
        private System.Windows.Forms.NumericUpDown SatuanMakanan;
        private System.Windows.Forms.TextBox txtSubTotalMinuman;
        private System.Windows.Forms.TextBox txtSubTotalMakanan;
    }
}

