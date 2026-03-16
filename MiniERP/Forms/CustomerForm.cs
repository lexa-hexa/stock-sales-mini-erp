using MiniERP.DAL;
using MiniERP.Models;
using MiniERP.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace MiniERP.Forms
{
    public partial class CustomerForm : Form
    {
        private CustomerService customerService;
        private int selectedCustomerId = -1;
        public CustomerForm()
        {
            InitializeComponent();
            customerService = new CustomerService();
        }
        private void LoadCustomers()
        {
            dgvCustomers.DataSource = customerService.GetCustomers();
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ReadOnly = true;
        }
        private void ClearCustomerForm()
        {
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            checkAktifMi.Checked = false;
            selectedCustomerId = -1;
            txtFullName.Focus();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            //---Boş kontrolü
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("İsim alanı boş geçilemez.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Telefon alanı boş geçilemez.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email alanı boş geçilemez.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            Customer customer = new Customer();
            customer.FullName = txtFullName.Text;
            customer.Phone = txtPhone.Text;
            customer.Email = txtEmail.Text;
            customer.IsActive = checkAktifMi.Checked;

            ServiceResult result = customerService.AddCustomer(customer);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomers();
                ClearCustomerForm();
            }
            else
            {
                MessageBox.Show(result.Message, "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == -1)
            {
                MessageBox.Show("Lütfen güncellenecek müşteri seçin", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Lütfen müşteri adı girin");
                txtFullName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Lütfen telefon numarası girin");
                txtPhone.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Lütfen mail adresi girin");
                txtEmail.Focus();
                return;
            }

            Customer customer = new Customer();
            customer.Id = selectedCustomerId;
            customer.FullName = txtFullName.Text;
            customer.Phone = txtPhone.Text;
            customer.Email = txtEmail.Text;
            customer.IsActive = checkAktifMi.Checked;


            ServiceResult result = customerService.UpdateCustomer(customer);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomers();
                ClearCustomerForm();
                selectedCustomerId = -1;
            }
            else
            {
                MessageBox.Show(result.Message, "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCustomerId == -1)
                {
                    MessageBox.Show("Lütfen silinecek müşteri seçin.", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show("Seçili müşteriyi silmek istediğinize emin misiniz?",
        "Silme Onayı",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                ServiceResult result = customerService.DeleteCustomer(selectedCustomerId);

                if (result.Success)
                {
                    LoadCustomers();
                    ClearCustomerForm();
                    selectedCustomerId = -1;
                    MessageBox.Show(result.Message, "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else { MessageBox.Show(result.Message, "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error); }


            }
            catch (Exception)
            {
                MessageBox.Show("Müşteri silinirken bir hata oluştu!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedCustomerId = Convert.ToInt32(dgvCustomers.CurrentRow.Cells["Id"].Value.ToString());
                txtFullName.Text = dgvCustomers.CurrentRow.Cells["FullName"].Value.ToString();
                txtPhone.Text = dgvCustomers.CurrentRow.Cells["Phone"].Value.ToString();
                txtEmail.Text = dgvCustomers.CurrentRow.Cells["Email"].Value.ToString();
                checkAktifMi.Checked = Convert.ToBoolean(dgvCustomers.CurrentRow.Cells["IsActive"].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
