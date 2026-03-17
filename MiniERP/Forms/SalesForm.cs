using MiniERP.Models;
using MiniERP.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MiniERP.Forms
{
    public partial class SalesForm : Form
    {
        private SalesService salesService;
        private CustomerService customerService;
        private int selectedSaleId = -1;
        public SalesForm()
        {
            InitializeComponent();
            salesService = new SalesService();
            customerService = new CustomerService();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            LoadCustomersToComboBox();
            LoadSales();
        }

        private void dgvSatisListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedSaleId = Convert.ToInt32(dgvSatisListesi.CurrentRow.Cells["Id"].Value);
                cmbCustomers.SelectedValue = dgvSatisListesi.CurrentRow.Cells["CustomerId"].Value;
                dtpSaleDate.Value = Convert.ToDateTime(dgvSatisListesi.CurrentRow.Cells["SaleDate"].Value);
                txtTotalAmount.Text = dgvSatisListesi.CurrentRow.Cells["TotalAmount"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void LoadCustomersToComboBox()
        {
            cmbCustomers.DataSource = customerService.GetCustomers();
            cmbCustomers.DisplayMember = "FullName";
            cmbCustomers.ValueMember = "Id";

        }
        private void LoadSales()
        {
            dgvSatisListesi.DataSource = salesService.GetSales();
            dgvSatisListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSatisListesi.ReadOnly = true;
        }
        private void ClearSalesForm()
        {
            cmbCustomers.SelectedIndex = 0;
            dtpSaleDate.Value = DateTime.Now;
            txtTotalAmount.Clear();
            selectedSaleId = -1;

        }
        private void btnSaleEkle_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(cmbCustomers.SelectedValue);
            DateTime saleDate = dtpSaleDate.Value;

            decimal totalamount;
            if(!decimal.TryParse(txtTotalAmount.Text, out totalamount))
            {
                MessageBox.Show("Geçerli bir fiyat giriniz!");
                txtTotalAmount.Focus();
                return;
            }

            Sale sale = new Sale();
            sale.CustomerId = customerId;
            sale.SaleDate = saleDate;
            sale.TotalAmount = totalamount;

            ServiceResult result = salesService.AddSale(sale);
            if(result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSales();
                ClearSalesForm();
            }
            else
            {
                MessageBox.Show(result.Message, "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSaleGuncelle_Click(object sender, EventArgs e)
        {
            if (selectedSaleId == -1)
            {
                MessageBox.Show("Lütfen güncellenecek satışı seçin", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbCustomers.SelectedIndex < 0 )
            {
                MessageBox.Show("Lütfen müşteri seçin", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCustomers.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTotalAmount.Text))
            {
                MessageBox.Show("Lütfen total fiyatı girin");
                txtTotalAmount.Focus();
                return;
            }

            decimal totalamount;
            if (!decimal.TryParse(txtTotalAmount.Text, out totalamount))
            {
                MessageBox.Show("Geçerli bir fiyat girin");
                txtTotalAmount.Focus();
                return;
            }

            Sale sale = new Sale();
            sale.Id = selectedSaleId;
            sale.CustomerId = Convert.ToInt32(cmbCustomers.SelectedValue);
            sale.SaleDate = dtpSaleDate.Value;
            sale.TotalAmount = totalamount;

            ServiceResult result = salesService.UpdateSale(sale);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSales();
                ClearSalesForm();
                selectedSaleId = -1;
            }
            else
            {
                MessageBox.Show(result.Message, "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaleSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedSaleId == -1)
                {
                    MessageBox.Show("Lütfen silinecek satışı seçin.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Seçili satışı silmek istediğinize emin misiniz?",
        "Silme Onayı",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                ServiceResult result = salesService.DeleteSale(selectedSaleId);

                if (result.Success)
                {
                    LoadSales();
                    ClearSalesForm();
                    selectedSaleId = -1;
                    MessageBox.Show(result.Message, "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show(result.Message, "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error); }


            }
            catch (Exception)
            {
                MessageBox.Show("Satış silinirken bir hata oluştu!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
