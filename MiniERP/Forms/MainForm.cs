using MiniERP.DAL;
using MiniERP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniERP
{
    public partial class MainForm : Form
    {
        private int selectedProductId = -1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            //--------Boş giriş kontrolü
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Lütfen isim girin!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();//Burda eğer boş geçerse kişi textboxa geri gönderir ve kullanıcı direk oraya yazabilir.
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Lütfen fiyat girin!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtStock.Text)) 
            {
                MessageBox.Show("Lütfen stok girin!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return;
            }
            //--------Dönüşüm Kontrolü
            decimal price;
            if(!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Geçerli bir fiyat giriniz!");
                txtPrice.Focus();
                return;
            }
            int stock;
            if(!int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("Geçerli bir stok giriniz!");
                txtStock.Focus();
                return;
            }

            Product product = new Product();
            product.Name = txtName.Text;
            product.Price = price;
            product.Stock = stock;
            product.IsActive = checkAktifMi.Checked;
            ProductRepository repo = new ProductRepository();
            int result = repo.AddProduct(product);
            if (result > 0)
            {
                MessageBox.Show("Ürün eklendi", "Bilgi!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProducts();
                ClearProductForm();
            }
            else
            {
                MessageBox.Show("Ürün eklerken bir hata oluştu!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadProducts()
        {
            ProductRepository repo = new ProductRepository();
            dgvProducts.DataSource = repo.GetProductsData();
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//Burda grid içerisinde satır bütün alanı kaplayarak düzgün bir görüntü oluşturması için kullanılır
            dgvProducts.ReadOnly = true;//Burda grid sadece görüntüleme amaçlı olduğunu göstermek için
        }
        private void ClearProductForm()
        {
            txtName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            checkAktifMi.Checked = false;
            selectedProductId = -1;
            txtName.Focus();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                ProductRepository repo = new ProductRepository();
                if (dgvProducts.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silinecek öğeyi seçin!.", "Uyarı!", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show("Ürünü silmek istediğine emin misin?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Id"].Value);
                    int result = repo.DeleteProduct(id);
                    if (result > 0)
                    {
                        LoadProducts();
                        MessageBox.Show("Ürün silindi!", "Bilgi!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("Ürün silinirken bir hata oluştu!", "Uyarı!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ürün silinirken bir hata oluştu!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(selectedProductId == -1)
            {
                MessageBox.Show("Lütfen güncellenecek ürün seçin", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Lütfen ürün adı girin");
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Lütfen ürün fiyatı girin");
                txtPrice.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Lütfen ürün stok adedi girin");
                txtStock.Focus();
                return;
            }

            decimal price;
            int stock;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Geçerli bir fiyat girin");
                txtPrice.Focus();
                return;
            }
            if (!int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("Geçerli bir stok girin");
                txtStock.Focus();
                return;
            }

            ProductRepository repo = new ProductRepository();
            Product product = new Product();
            product.Id = selectedProductId;
            product.Name = txtName.Text;
            product.Price = price;
            product.Stock = stock;
            product.IsActive = checkAktifMi.Checked;


            int result = repo.UpdateProducts(product);
            if(result > 0)
            {
                LoadProducts();
                MessageBox.Show("Ürün bilgileri güncellenmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearProductForm();
            }
            else
            {
                MessageBox.Show("Bir hata oluştu!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedProductId = Convert.ToInt32(dgvProducts.CurrentRow.Cells["Id"].Value.ToString());
                txtName.Text = dgvProducts.CurrentRow.Cells["Name"].Value.ToString();
                txtPrice.Text = dgvProducts.CurrentRow.Cells["Price"].Value.ToString();
                txtStock.Text = dgvProducts.CurrentRow.Cells["Stock"].Value.ToString();
                checkAktifMi.Checked = Convert.ToBoolean(dgvProducts.CurrentRow.Cells["IsActive"].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu!", "Uyarı!", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }
    }
}
