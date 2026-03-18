using System;
using System.Data;
using MiniERP.DAL;
using MiniERP.Models;

namespace MiniERP.Services
{
    public class SalesService
    {
        private SalesRepository salesRepository;

        public SalesService()
        {
            salesRepository = new SalesRepository();
        }

        public DataTable GetSales()
        {
            return salesRepository.GetSalesData();
        }

        public ServiceResult AddSale(Sale sale)
        {
            if (sale.CustomerId <= 0)
            {
                return new ServiceResult { Success = false, Message = "Geçerli bir müşteri seçin." };
            }
            if (sale.TotalAmount < 0)
            {
                return new ServiceResult { Success = false, Message = "Tutar negatif olamaz." };
            }
            int result = salesRepository.AddSale(sale);
            if (result > 0)
            {
                return new ServiceResult { Success = true, Message = "Sipariş eklendi" };
            }
            return new ServiceResult { Success = false, Message = "Sipariş eklenirken hata oluştu!" };
        }
        public ServiceResult UpdateSale(Sale sale)
        {
            if(sale.CustomerId <= 0)
            {
                return new ServiceResult { Success = false, Message = "Geçerli bir müşteri seçin." };
            }
            if(sale.TotalAmount < 0)
            {
                return new ServiceResult { Success = false, Message = "Tutar negatif olamaz." };
            }
            int result = salesRepository.UpdateSale(sale);

            if (result > 0)
                return new ServiceResult { Success = true, Message = "Sipariş güncellendi." };

            return new ServiceResult { Success = false, Message = "Sipariş güncellenirken hata oluştu." };
        }
        public ServiceResult DeleteSale(int id) 
        {
            int result = salesRepository.DeleteSale(id);

            if (result > 0)
            {
                return new ServiceResult { Success = true, Message = "Satış silindi!" };
            }
            return new ServiceResult { Success = false, Message = "Satış silinemedi!" };
        }

    }
}
