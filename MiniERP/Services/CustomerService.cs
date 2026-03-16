using MiniERP.DAL;
using System;
using System.Data;
using MiniERP.Models;


namespace MiniERP.Services
{
    public class CustomerService
    {
        private CustomerRepository repository;
        public CustomerService()
        {
            repository = new CustomerRepository();
        }
        public DataTable GetCustomers()
        {
            return repository.GetCustomersData();
        }
        public ServiceResult AddCustomer(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.FullName))
            {
                return new ServiceResult { Success = false, Message = "Müşteri adı boş olamaz!"};
            }
            if (string.IsNullOrWhiteSpace(customer.Phone))
            {
                return new ServiceResult { Success = false, Message = "Müşteri telefon numarası boş geçilemez!" };
            }
            if (string.IsNullOrWhiteSpace(customer.Email))
            {
                return new ServiceResult { Success = false, Message = "Müşteri mail adresi boş geçilemez!" };
            }
            int result = repository.AddCustomer(customer);
            if(result > 0)
            {
                return new ServiceResult { Success = true, Message = "Müşteri eklendi!" };
            }
            return new ServiceResult { Success = false, Message = "Müşteri eklenirken bir hata oluştu!" }; 
        }
        public ServiceResult UpdateCustomer(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.FullName))
            {
                return new ServiceResult { Success = false, Message = "Müşteri adı boş geçilemez!" };
            }
            if (string.IsNullOrWhiteSpace(customer.Phone))
            {
                return new ServiceResult { Success = false, Message = "Müşteri telefon numarası boş geçilemez!" };
            }
            if (string.IsNullOrWhiteSpace(customer.Email))
            {
                return new ServiceResult { Success = false, Message = "Müşteri mail adresi boş geçilemez!" };
            }
            int result = repository.UpdateCustomer(customer);
            if (result > 0) 
            {
                return new ServiceResult { Success = true, Message = "Müşteri bilgileri güncellendi!" };
            }
            return new ServiceResult { Success = false, Message = "Müşteri bilgileri güncellenirken bir hata oluştu!" };
        }
        public ServiceResult DeleteCustomer(int id) 
        {
            int result = repository.DeleteCustomer(id);
            if (result > 0)
            {
                return new ServiceResult { Success = true, Message = "Müşteri başarıyla silindi!" };
            }
            return new ServiceResult { Success = false, Message = "Müşteri silinirken bir hata oluştu!" };
        }
    }
}
