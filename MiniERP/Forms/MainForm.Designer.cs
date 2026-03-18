namespace MiniERP.Forms
{
    partial class MainForm
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
            this.btnUrunYonetimi = new System.Windows.Forms.Button();
            this.btnMusteriYonetimi = new System.Windows.Forms.Button();
            this.btnSatisYonetimi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUrunYonetimi
            // 
            this.btnUrunYonetimi.Location = new System.Drawing.Point(307, 71);
            this.btnUrunYonetimi.Name = "btnUrunYonetimi";
            this.btnUrunYonetimi.Size = new System.Drawing.Size(115, 58);
            this.btnUrunYonetimi.TabIndex = 0;
            this.btnUrunYonetimi.Text = "Ürün Yönetimi";
            this.btnUrunYonetimi.UseVisualStyleBackColor = true;
            this.btnUrunYonetimi.Click += new System.EventHandler(this.btnUrunYonetimi_Click);
            // 
            // btnMusteriYonetimi
            // 
            this.btnMusteriYonetimi.Location = new System.Drawing.Point(307, 175);
            this.btnMusteriYonetimi.Name = "btnMusteriYonetimi";
            this.btnMusteriYonetimi.Size = new System.Drawing.Size(115, 58);
            this.btnMusteriYonetimi.TabIndex = 1;
            this.btnMusteriYonetimi.Text = "Müşteri Yönetimi";
            this.btnMusteriYonetimi.UseVisualStyleBackColor = true;
            this.btnMusteriYonetimi.Click += new System.EventHandler(this.btnMusteriYonetimi_Click);
            // 
            // btnSatisYonetimi
            // 
            this.btnSatisYonetimi.Location = new System.Drawing.Point(307, 268);
            this.btnSatisYonetimi.Name = "btnSatisYonetimi";
            this.btnSatisYonetimi.Size = new System.Drawing.Size(115, 58);
            this.btnSatisYonetimi.TabIndex = 2;
            this.btnSatisYonetimi.Text = "Satış Yönetimi";
            this.btnSatisYonetimi.UseVisualStyleBackColor = true;
            this.btnSatisYonetimi.Click += new System.EventHandler(this.btnSatisYonetimi_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSatisYonetimi);
            this.Controls.Add(this.btnMusteriYonetimi);
            this.Controls.Add(this.btnUrunYonetimi);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUrunYonetimi;
        private System.Windows.Forms.Button btnMusteriYonetimi;
        private System.Windows.Forms.Button btnSatisYonetimi;
    }
}