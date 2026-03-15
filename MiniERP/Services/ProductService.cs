using MiniERP.DAL;
using MiniERP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MiniERP.Services
{
    public class ProductService
    {
        private ProductRepository repository;
        public ProductService()
        {
            repository = new ProductRepository();
        }
        public DataTable GetProducts()
        {
            return repository.GetProductsData();
        }
        public ServiceResult AddProduct(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
            {
                return new ServiceResult { Success = false, Message = "Ürün adı boş olamaz!" };
            }
            if (product.Price < 0)
            {
                return new ServiceResult { Success = false, Message = "Fiyat negatif olamaz" };
            }
            if (product.Stock < 0)
            {
                return new ServiceResult { Success = false, Message = "Stok negatif olamaz" };
            }
            int result = repository.AddProduct(product);
            if (result > 0)
            {
                return new ServiceResult { Success = true, Message = "Ürün eklendi" };
            }
            return new ServiceResult { Success = false, Message = "Ürün eklenirken hata oluştu!" };
        }
        public ServiceResult DeleteProduct(int id)
        {
            int result = repository.DeleteProduct(id);

            if (result > 0)
            {
                return new ServiceResult { Success = true, Message = "Ürün silindi!" };
            }
            return new ServiceResult { Success = false, Message = "Ürün silinemedi!" };
        }
        public ServiceResult UpdateProduct(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name))
                return new ServiceResult { Success = false, Message = "Ürün adı boş olamaz." };

            if (product.Price < 0)
                return new ServiceResult { Success = false, Message = "Fiyat negatif olamaz." };

            if (product.Stock < 0)
                return new ServiceResult { Success = false, Message = "Stok negatif olamaz." };

            int result = repository.UpdateProducts(product);

            if (result > 0)
                return new ServiceResult { Success = true, Message = "Ürün güncellendi." };

            return new ServiceResult { Success = false, Message = "Ürün güncellenirken hata oluştu." };
        }

    }
}
