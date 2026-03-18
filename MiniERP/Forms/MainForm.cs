using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUrunYonetimi_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            productForm.ShowDialog();
        }

        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            customerForm.ShowDialog();
        }

        private void btnSatisYonetimi_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();
            salesForm.FormClosed += (s, args) =>
            {
                this.Show();
            };
            this.Hide();
            salesForm.ShowDialog();
        }
    }
}
