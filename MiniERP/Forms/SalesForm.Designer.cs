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
            this.grpSale = new System.Windows.Forms.GroupBox();
            this.btnSaleSil = new System.Windows.Forms.Button();
            this.btnSaleGuncelle = new System.Windows.Forms.Button();
            this.btnSaleEkle = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.lblSatisTarihi = new System.Windows.Forms.Label();
            this.lblMusteriSecim = new System.Windows.Forms.Label();
            this.grpSaleItems = new System.Windows.Forms.GroupBox();
            this.lblUrun = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblBirim = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnKalemEkle = new System.Windows.Forms.Button();
            this.btnKalemGuncelle = new System.Windows.Forms.Button();
            this.btnKalemSil = new System.Windows.Forms.Button();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtLineTotal = new System.Windows.Forms.TextBox();
            this.dgvSaleItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisListesi)).BeginInit();
            this.grpSale.SuspendLayout();
            this.grpSaleItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(65, 25);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomers.TabIndex = 0;
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.Location = new System.Drawing.Point(18, 82);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(200, 20);
            this.dtpSaleDate.TabIndex = 1;
            // 
            // dgvSatisListesi
            // 
            this.dgvSatisListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatisListesi.Location = new System.Drawing.Point(12, 12);
            this.dgvSatisListesi.Name = "dgvSatisListesi";
            this.dgvSatisListesi.Size = new System.Drawing.Size(789, 210);
            this.dgvSatisListesi.TabIndex = 2;
            this.dgvSatisListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSatisListesi_CellClick);
            // 
            // grpSale
            // 
            this.grpSale.Controls.Add(this.btnSaleSil);
            this.grpSale.Controls.Add(this.btnSaleGuncelle);
            this.grpSale.Controls.Add(this.btnSaleEkle);
            this.grpSale.Controls.Add(this.txtTotalAmount);
            this.grpSale.Controls.Add(this.lblToplamTutar);
            this.grpSale.Controls.Add(this.lblSatisTarihi);
            this.grpSale.Controls.Add(this.lblMusteriSecim);
            this.grpSale.Controls.Add(this.cmbCustomers);
            this.grpSale.Controls.Add(this.dtpSaleDate);
            this.grpSale.Location = new System.Drawing.Point(12, 228);
            this.grpSale.Name = "grpSale";
            this.grpSale.Size = new System.Drawing.Size(389, 319);
            this.grpSale.TabIndex = 3;
            this.grpSale.TabStop = false;
            this.grpSale.Text = "Satış Yönetimi";
            // 
            // btnSaleSil
            // 
            this.btnSaleSil.Location = new System.Drawing.Point(260, 140);
            this.btnSaleSil.Name = "btnSaleSil";
            this.btnSaleSil.Size = new System.Drawing.Size(122, 23);
            this.btnSaleSil.TabIndex = 8;
            this.btnSaleSil.Text = "Satış Sil";
            this.btnSaleSil.UseVisualStyleBackColor = true;
            this.btnSaleSil.Click += new System.EventHandler(this.btnSaleSil_Click);
            // 
            // btnSaleGuncelle
            // 
            this.btnSaleGuncelle.Location = new System.Drawing.Point(134, 140);
            this.btnSaleGuncelle.Name = "btnSaleGuncelle";
            this.btnSaleGuncelle.Size = new System.Drawing.Size(122, 23);
            this.btnSaleGuncelle.TabIndex = 7;
            this.btnSaleGuncelle.Text = "Satış Güncelle";
            this.btnSaleGuncelle.UseVisualStyleBackColor = true;
            this.btnSaleGuncelle.Click += new System.EventHandler(this.btnSaleGuncelle_Click);
            // 
            // btnSaleEkle
            // 
            this.btnSaleEkle.Location = new System.Drawing.Point(6, 140);
            this.btnSaleEkle.Name = "btnSaleEkle";
            this.btnSaleEkle.Size = new System.Drawing.Size(122, 23);
            this.btnSaleEkle.TabIndex = 6;
            this.btnSaleEkle.Text = "Satış Ekle";
            this.btnSaleEkle.UseVisualStyleBackColor = true;
            this.btnSaleEkle.Click += new System.EventHandler(this.btnSaleEkle_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Location = new System.Drawing.Point(282, 27);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAmount.TabIndex = 5;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(206, 30);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(70, 13);
            this.lblToplamTutar.TabIndex = 4;
            this.lblToplamTutar.Text = "Toplam Tutar";
            // 
            // lblSatisTarihi
            // 
            this.lblSatisTarihi.AutoSize = true;
            this.lblSatisTarihi.Location = new System.Drawing.Point(15, 60);
            this.lblSatisTarihi.Name = "lblSatisTarihi";
            this.lblSatisTarihi.Size = new System.Drawing.Size(59, 13);
            this.lblSatisTarihi.TabIndex = 3;
            this.lblSatisTarihi.Text = "Satış Tarihi";
            // 
            // lblMusteriSecim
            // 
            this.lblMusteriSecim.AutoSize = true;
            this.lblMusteriSecim.Location = new System.Drawing.Point(15, 28);
            this.lblMusteriSecim.Name = "lblMusteriSecim";
            this.lblMusteriSecim.Size = new System.Drawing.Size(44, 13);
            this.lblMusteriSecim.TabIndex = 2;
            this.lblMusteriSecim.Text = "Müşteri ";
            // 
            // grpSaleItems
            // 
            this.grpSaleItems.Controls.Add(this.dgvSaleItems);
            this.grpSaleItems.Controls.Add(this.txtLineTotal);
            this.grpSaleItems.Controls.Add(this.txtUnitPrice);
            this.grpSaleItems.Controls.Add(this.txtQuantity);
            this.grpSaleItems.Controls.Add(this.cmbProducts);
            this.grpSaleItems.Controls.Add(this.btnKalemSil);
            this.grpSaleItems.Controls.Add(this.btnKalemGuncelle);
            this.grpSaleItems.Controls.Add(this.btnKalemEkle);
            this.grpSaleItems.Controls.Add(this.lblToplam);
            this.grpSaleItems.Controls.Add(this.lblBirim);
            this.grpSaleItems.Controls.Add(this.lblAdet);
            this.grpSaleItems.Controls.Add(this.lblUrun);
            this.grpSaleItems.Location = new System.Drawing.Point(407, 228);
            this.grpSaleItems.Name = "grpSaleItems";
            this.grpSaleItems.Size = new System.Drawing.Size(394, 319);
            this.grpSaleItems.TabIndex = 4;
            this.grpSaleItems.TabStop = false;
            this.grpSaleItems.Text = "Satış Kalemleri";
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(32, 28);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(30, 13);
            this.lblUrun.TabIndex = 0;
            this.lblUrun.Text = "Ürün";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(32, 60);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(29, 13);
            this.lblAdet.TabIndex = 1;
            this.lblAdet.Text = "Adet";
            // 
            // lblBirim
            // 
            this.lblBirim.AutoSize = true;
            this.lblBirim.Location = new System.Drawing.Point(32, 89);
            this.lblBirim.Name = "lblBirim";
            this.lblBirim.Size = new System.Drawing.Size(29, 13);
            this.lblBirim.TabIndex = 2;
            this.lblBirim.Text = "Birim";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(32, 117);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(42, 13);
            this.lblToplam.TabIndex = 3;
            this.lblToplam.Text = "Toplam";
            // 
            // btnKalemEkle
            // 
            this.btnKalemEkle.Location = new System.Drawing.Point(6, 140);
            this.btnKalemEkle.Name = "btnKalemEkle";
            this.btnKalemEkle.Size = new System.Drawing.Size(122, 23);
            this.btnKalemEkle.TabIndex = 4;
            this.btnKalemEkle.Text = "Kalem Ekle";
            this.btnKalemEkle.UseVisualStyleBackColor = true;
            this.btnKalemEkle.Click += new System.EventHandler(this.btnKalemEkle_Click);
            // 
            // btnKalemGuncelle
            // 
            this.btnKalemGuncelle.Location = new System.Drawing.Point(134, 140);
            this.btnKalemGuncelle.Name = "btnKalemGuncelle";
            this.btnKalemGuncelle.Size = new System.Drawing.Size(122, 23);
            this.btnKalemGuncelle.TabIndex = 5;
            this.btnKalemGuncelle.Text = "Kalem Güncelle";
            this.btnKalemGuncelle.UseVisualStyleBackColor = true;
            this.btnKalemGuncelle.Click += new System.EventHandler(this.btnKalemGuncelle_Click);
            // 
            // btnKalemSil
            // 
            this.btnKalemSil.Location = new System.Drawing.Point(262, 140);
            this.btnKalemSil.Name = "btnKalemSil";
            this.btnKalemSil.Size = new System.Drawing.Size(122, 23);
            this.btnKalemSil.TabIndex = 6;
            this.btnKalemSil.Text = "Kalem Sil";
            this.btnKalemSil.UseVisualStyleBackColor = true;
            this.btnKalemSil.Click += new System.EventHandler(this.btnKalemSil_Click);
            // 
            // cmbProducts
            // 
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(101, 22);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(121, 21);
            this.cmbProducts.TabIndex = 7;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(101, 57);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 8;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(101, 86);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 9;
            // 
            // txtLineTotal
            // 
            this.txtLineTotal.Location = new System.Drawing.Point(101, 114);
            this.txtLineTotal.Name = "txtLineTotal";
            this.txtLineTotal.Size = new System.Drawing.Size(100, 20);
            this.txtLineTotal.TabIndex = 10;
            // 
            // dgvSaleItems
            // 
            this.dgvSaleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleItems.Location = new System.Drawing.Point(6, 169);
            this.dgvSaleItems.Name = "dgvSaleItems";
            this.dgvSaleItems.Size = new System.Drawing.Size(382, 144);
            this.dgvSaleItems.TabIndex = 11;
            this.dgvSaleItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleItems_CellClick);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 559);
            this.Controls.Add(this.grpSaleItems);
            this.Controls.Add(this.grpSale);
            this.Controls.Add(this.dgvSatisListesi);
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisListesi)).EndInit();
            this.grpSale.ResumeLayout(false);
            this.grpSale.PerformLayout();
            this.grpSaleItems.ResumeLayout(false);
            this.grpSaleItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.DataGridView dgvSatisListesi;
        private System.Windows.Forms.GroupBox grpSale;
        private System.Windows.Forms.Button btnSaleSil;
        private System.Windows.Forms.Button btnSaleGuncelle;
        private System.Windows.Forms.Button btnSaleEkle;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblSatisTarihi;
        private System.Windows.Forms.Label lblMusteriSecim;
        private System.Windows.Forms.GroupBox grpSaleItems;
        private System.Windows.Forms.Label lblBirim;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.TextBox txtLineTotal;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Button btnKalemSil;
        private System.Windows.Forms.Button btnKalemGuncelle;
        private System.Windows.Forms.Button btnKalemEkle;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.DataGridView dgvSaleItems;
    }
}