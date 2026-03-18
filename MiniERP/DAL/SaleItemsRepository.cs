using MiniERP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.DAL
{
    public class SaleItemsRepository
    {
        private SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionManager.GetConnectionString());
        }
        public DataTable GetSalesItemsData(int saleId)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Select * From SalesItems Where SaleId=@SaleId", conn);
                command.Parameters.AddWithValue("@SaleId", saleId);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                reader.Close();
                return dataTable;
            }
        }
        public int AddSaleItem(SaleItem saleItem)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Insert Into SalesItems (SaleId, ProductId, Quantity, UnitPrice, LineTotal) Values (@SaleId, @ProductId, @Quantity, @UnitPrice, @LineTotal)", conn);
                command.Parameters.AddWithValue("@SaleId", saleItem.SaleId);
                command.Parameters.AddWithValue("@ProductId", saleItem.ProductId);
                command.Parameters.AddWithValue("@Quantity", saleItem.Quantity);
                command.Parameters.AddWithValue("@UnitPrice", saleItem.UnitPrice);
                command.Parameters.AddWithValue("@LineTotal", saleItem.LineTotal);

                int result = command.ExecuteNonQuery();
                return result;

            }
        }
        public int UpdateSaleItem(SaleItem saleItem)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Update SalesItems Set SaleId=@SaleId, ProductId=@ProductId, Quantity=@Quantity, UnitPrice=@UnitPrice, LineTotal=@LineTotal Where Id=@Id", conn);
                command.Parameters.AddWithValue("@Id", saleItem.Id);
                command.Parameters.AddWithValue("@SaleId", saleItem.SaleId);
                command.Parameters.AddWithValue("@ProductId", saleItem.ProductId);
                command.Parameters.AddWithValue("@Quantity", saleItem.Quantity);
                command.Parameters.AddWithValue("@UnitPrice", saleItem.UnitPrice);
                command.Parameters.AddWithValue("@LineTotal", saleItem.LineTotal);
                
                int result = command.ExecuteNonQuery();
                return result;
            }
        }
        public int DeleteSaleItem(int id)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand("Delete From SalesItems Where Id=@Id", conn);
                command.Parameters.AddWithValue("@Id", id);
                int result = command.ExecuteNonQuery();
                return result;
            }
        }

    }
}
