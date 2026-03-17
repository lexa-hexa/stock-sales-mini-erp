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
    public class SalesRepository
    {
        private SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionManager.GetConnectionString());
        }
        public DataTable GetSalesData()
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Select * From Sales", conn);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                return dataTable;
            }
        }
        public int AddSale(Sale sale)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Insert Into Sales (CustomerId, SaleDate, TotalAmount) Values (@CustomerId, @SaleDate, @TotalAmount)", conn);
                command.Parameters.AddWithValue("@CustomerId", sale.CustomerId);
                command.Parameters.AddWithValue("@SaleDate", sale.SaleDate);
                command.Parameters.AddWithValue("@TotalAmount", sale.TotalAmount);

                int result = command.ExecuteNonQuery();
                return result;

            }
        }
        public int UpdateSale(Sale sale)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Update Sales Set CustomerId=@CustomerId, SaleDate=@SaleDate, TotalAmount=@TotalAmount Where Id=@Id", conn);
                command.Parameters.AddWithValue("@Id", sale.Id);
                command.Parameters.AddWithValue("@CustomerId", sale.CustomerId);
                command.Parameters.AddWithValue("@SaleDate", sale.SaleDate);
                command.Parameters.AddWithValue("@TotalAmount", sale.TotalAmount);
                int result = command.ExecuteNonQuery();
                return result;
            }
        }
        public int DeleteSale(int id) 
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Delete From Sales Where Id=@Id", conn);
                command.Parameters.AddWithValue("@Id", id);
                int result = command.ExecuteNonQuery();
                return result;
            }
        }
    }
}
