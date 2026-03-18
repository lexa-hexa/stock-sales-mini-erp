using System;
using MiniERP.DAL;
using MiniERP.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MiniERP.Services
{
    public class SaleItemsService
    {
        private SaleItemsRepository saleItemsRepository;

        public SaleItemsService()
        {
            saleItemsRepository = new SaleItemsRepository();
        }

        public DataTable GetSaleItems(int saleId)
        {
            return saleItemsRepository.GetSalesItemsData(saleId);
        }
        public ServiceResult AddSaleItem(SaleItem saleItem)
        {
            if (saleItem.SaleId <= 0)
            {
                return new ServiceResult { Success = false, Message = "Geçerli bir satış seçin." };
            }
            if (saleItem.ProductId <= 0)
            {
                return new ServiceResult { Success = false, Message = "Geçerli bir ürün seçin." };
            }
            if (saleItem.Quantity <= 0)
            {
                return new ServiceResult { Success = false, Message = "Ürün adedi 0'dan büyük olmalıdır." };
            }
            if (saleItem.UnitPrice < 0)
            {
                return new ServiceResult { Success = false, Message = "Birim fiyat negatif olamaz." };
            }
            if (saleItem.LineTotal < 0)
            {
                return new ServiceResult { Success = false, Message = "Satır toplamı negatif olamaz." };
            }
            int result = saleItemsRepository.AddSaleItem(saleItem);
            if (result > 0)
            {
                return new ServiceResult { Success = true, Message = "Satış kalemi eklendi." };
            }
            return new ServiceResult { Success = false, Message = "Satış kalemi eklenirken hata oluştu!" };
        }
        public ServiceResult UpdateSaleItem(SaleItem saleItem)
        {
            if (saleItem.SaleId <= 0)
            {
                return new ServiceResult { Success = false, Message = "Geçerli bir satış seçin." };
            }
            if (saleItem.ProductId <= 0)
            {
                return new ServiceResult { Success = false, Message = "Geçerli bir ürün seçin." };
            }
            if (saleItem.Quantity <= 0)
            {
                return new ServiceResult { Success = false, Message = "Ürün adedi 0'dan büyük olmalıdır." };
            }
            if (saleItem.UnitPrice < 0)
            {
                return new ServiceResult { Success = false, Message = "Birim fiyat negatif olamaz." };
            }
            if (saleItem.LineTotal < 0)
            {
                return new ServiceResult { Success = false, Message = "Satır toplamı negatif olamaz." };
            }
            int result = saleItemsRepository.UpdateSaleItem(saleItem);

            if (result > 0)
                return new ServiceResult { Success = true, Message = "Satış kalemi güncellendi." };

            return new ServiceResult { Success = false, Message = "Satış kalemi güncellenirken hata oluştu." };
        }
        public ServiceResult DeleteSaleItem(int id)
        {
            int result = saleItemsRepository.DeleteSaleItem(id);

            if (result > 0)
            {
                return new ServiceResult { Success = true, Message = "Satış kalemi silindi!" };
            }
            return new ServiceResult { Success = false, Message = "Satış kalemi silinirken hata oluştu!" };
        }
    }
}
