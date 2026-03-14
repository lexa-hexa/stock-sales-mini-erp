using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MiniERP.Models;
using System.Data;

namespace MiniERP.DAL
{
    public class ProductRepository
    {
        private SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionManager.GetConnectionString());
        }
        public int AddProduct(Product product)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Insert Into Products (Name, Price, Stock, IsActive) Values (@Name, @Price, @Stock, @IsActive)", conn);
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Stock", product.Stock);
                command.Parameters.AddWithValue("@IsActive", product.IsActive);
                int result = command.ExecuteNonQuery();
                return result;
            }
        }
        public DataTable GetProductsData()
        {
            using (SqlConnection conn = GetConnection()) 
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Select * from Products", conn);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                return dataTable;
            }
        }
        public int UpdateProducts(Product product)
        {
            using (SqlConnection conn = GetConnection()) 
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Update Products Set Name=@Name, Price=@Price, Stock=@Stock, IsActive=@IsActive Where Id = @Id", conn);
                command.Parameters.AddWithValue("@Id", product.Id);
                command.Parameters.AddWithValue("@Name", product.Name);
                command.Parameters.AddWithValue("@Price", product.Price);
                command.Parameters.AddWithValue("@Stock", product.Stock);
                command.Parameters.AddWithValue("@IsActive", product.IsActive);
                int result = command.ExecuteNonQuery();
                return result;

            }
        }
        public int DeleteProduct(int id) 
        {
            using (SqlConnection conn = GetConnection()) 
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Delete From Products Where Id = @Id", conn);
                command.Parameters.AddWithValue("@Id", id);
                int result = command.ExecuteNonQuery();
                return result;

            }
        }
    }
}
