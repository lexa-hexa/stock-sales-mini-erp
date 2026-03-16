
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniERP.Models;

namespace MiniERP.DAL
{
    public class CustomerRepository
    {
        private SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionManager.GetConnectionString());
        }
        public DataTable GetCustomersData()
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Select * From Customers", conn);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                return dataTable;
            }
        }
        public int AddCustomer(Customer customer)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Insert Into Customers (FullName, Phone, Email, IsActive) Values (@FullName, @Phone, @Email, @IsActive)", conn);
                command.Parameters.AddWithValue("@FullName", customer.FullName);
                command.Parameters.AddWithValue("@Phone", customer.Phone);
                command.Parameters.AddWithValue("@Email", customer.Email);
                command.Parameters.AddWithValue("@IsActive", customer.IsActive);
                int result = command.ExecuteNonQuery();
                return result;
            }
        }
        public int UpdateCustomer(Customer customer)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Update Customers Set FullName=@FullName, Phone=@Phone, Email=@Email, IsActive=@IsActive Where Id=@Id", conn);
                command.Parameters.AddWithValue("@Id", customer.Id);
                command.Parameters.AddWithValue("@FullName", customer.FullName);
                command.Parameters.AddWithValue("@Phone", customer.Phone);
                command.Parameters.AddWithValue("@Email", customer.Email);
                command.Parameters.AddWithValue("@IsActive", customer.IsActive);
                int result = command.ExecuteNonQuery();
                return result;
            }
        }
        public int DeleteCustomer(int id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Delete From Customers Where Id=@Id", conn);
                command.Parameters.AddWithValue("@Id", id);
                int result = command.ExecuteNonQuery();
                return result;
            }
        }
    }
}
