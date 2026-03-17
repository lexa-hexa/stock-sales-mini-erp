namespace MiniERP.Forms
{
    partial class SalesForm
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
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.dgvSatisListesi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMusteriSecim = new System.Windows.Forms.Label();
            this.lblSatisTarihi = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.btnSaleEkle = new System.Windows.Forms.Button();
            this.btnSaleGuncelle = new System.Windows.Forms.Button();
            this.btnSaleSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisListesi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(80, 48);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomers.TabIndex = 0;
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.Location = new System.Drawing.Point(80, 90);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(200, 20);
            this.dtpSaleDate.TabIndex = 1;
            // 
            // dgvSatisListesi
            // 
            this.dgvSatisListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatisListesi.Location = new System.Drawing.Point(12, 12);
            this.dgvSatisListesi.Name = "dgvSatisListesi";
            this.dgvSatisListesi.Size = new System.Drawing.Size(776, 150);
            this.dgvSatisListesi.TabIndex = 2;
            this.dgvSatisListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSatisListesi_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaleSil);
            this.groupBox1.Controls.Add(this.btnSaleGuncelle);
            this.groupBox1.Controls.Add(this.btnSaleEkle);
            this.groupBox1.Controls.Add(this.txtTotalAmount);
            this.groupBox1.Controls.Add(this.lblToplamTutar);
            this.groupBox1.Controls.Add(this.lblSatisTarihi);
            this.groupBox1.Controls.Add(this.lblMusteriSecim);
            this.groupBox1.Controls.Add(this.cmbCustomers);
            this.groupBox1.Controls.Add(this.dtpSaleDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 270);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satış Yönetimi";
            // 
            // lblMusteriSecim
            // 
            this.lblMusteriSecim.AutoSize = true;
            this.lblMusteriSecim.Location = new System.Drawing.Point(15, 51);
            this.lblMusteriSecim.Name = "lblMusteriSecim";
            this.lblMusteriSecim.Size = new System.Drawing.Size(44, 13);
            this.lblMusteriSecim.TabIndex = 2;
            this.lblMusteriSecim.Text = "Müşteri ";
            // 
            // lblSatisTarihi
            // 
            this.lblSatisTarihi.AutoSize = true;
            this.lblSatisTarihi.Location = new System.Drawing.Point(15, 94);
            this.lblSatisTarihi.Name = "lblSatisTarihi";
            this.lblSatisTarihi.Size = new System.Drawing.Size(59, 13);
            this.lblSatisTarihi.TabIndex = 3;
            this.lblSatisTarihi.Text = "Satış Tarihi";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(15, 133);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(70, 13);
            this.lblToplamTutar.TabIndex = 4;
            this.lblToplamTutar.Text = "Toplam Tutar";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(101, 130);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 5;
            // 
            // btnSaleEkle
            // 
            this.btnSaleEkle.Location = new System.Drawing.Point(18, 181);
            this.btnSaleEkle.Name = "btnSaleEkle";
            this.btnSaleEkle.Size = new System.Drawing.Size(122, 23);
            this.btnSaleEkle.TabIndex = 6;
            this.btnSaleEkle.Text = "Satış ekle";
            this.btnSaleEkle.UseVisualStyleBackColor = true;
            this.btnSaleEkle.Click += new System.EventHandler(this.btnSaleEkle_Click);
            // 
            // btnSaleGuncelle
            // 
            this.btnSaleGuncelle.Location = new System.Drawing.Point(18, 210);
            this.btnSaleGuncelle.Name = "btnSaleGuncelle";
            this.btnSaleGuncelle.Size = new System.Drawing.Size(122, 23);
            this.btnSaleGuncelle.TabIndex = 7;
            this.btnSaleGuncelle.Text = "Satış Güncelle";
            this.btnSaleGuncelle.UseVisualStyleBackColor = true;
            this.btnSaleGuncelle.Click += new System.EventHandler(this.btnSaleGuncelle_Click);
            // 
            // btnSaleSil
            // 
            this.btnSaleSil.Location = new System.Drawing.Point(18, 239);
            this.btnSaleSil.Name = "btnSaleSil";
            this.btnSaleSil.Size = new System.Drawing.Size(122, 23);
            this.btnSaleSil.TabIndex = 8;
            this.btnSaleSil.Text = "Satış Sil";
            this.btnSaleSil.UseVisualStyleBackColor = true;
            this.btnSaleSil.Click += new System.EventHandler(this.btnSaleSil_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSatisListesi);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisListesi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.DataGridView dgvSatisListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaleSil;
        private System.Windows.Forms.Button btnSaleGuncelle;
        private System.Windows.Forms.Button btnSaleEkle;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblSatisTarihi;
        private System.Windows.Forms.Label lblMusteriSecim;
    }
}