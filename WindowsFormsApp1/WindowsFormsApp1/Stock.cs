using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class Stock
    {
        public int Id
        {
            get;
            private set;
        }

        public string Name
        {
            get;
            private set;
        }
        public string Description
        {
            get;
            private set;
        }

        public int QuantityInDepot
        {
            get;
            private set;
        }

        public int QuantityInStore
        {
            get;
            private set;
        }

        public int DepartmentId
        {
            get;
            private set;
        }

        public decimal Price
        {
            get;
            private set;
        }

        public Stock(string name, string description, int quantityInDepot, int quantityInStore, decimal price, int departmentId)
        {
            this.Name = name;
            this.Description = description;
            this.QuantityInDepot = quantityInDepot;
            this.QuantityInStore = quantityInStore;
            this.Price = price;
            this.DepartmentId = departmentId;
            AddStock();
        }

        private void AddStock()
        {
            MySqlConnection conn = Utils.GetConnection();
            try
            {
                string sql = "INSERT INTO stock(name, description, department_id, quantity_in_depo, quantity_in_store, price, currency_id) VALUES (@name, @description, @department_id, @depo, @store, @price, 1);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@description", Description);
                cmd.Parameters.AddWithValue("@department_id", DepartmentId);
                cmd.Parameters.AddWithValue("@depo", QuantityInDepot);
                cmd.Parameters.AddWithValue("@store", QuantityInStore);
                cmd.Parameters.AddWithValue("@price", Price);
                conn.Open();
                int effectedRows = cmd.ExecuteNonQuery();
                Id = (int)cmd.LastInsertedId;
            }
            catch (Exception)
            {
                // TODO: add it to error log in the future
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<Stock> GetAllStocks()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<Stock> stocks = new List<Stock>();
            try
            {
                string sql = "SELECT name, description,quantity_in_depo,quantity_in_store, price,department_id,id FROM stock;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    Stock s = new Stock(row[0].ToString(), row[1].ToString(), Convert.ToInt32(row[2]), Convert.ToInt32(row[3]), Convert.ToInt32(row[4]), Convert.ToInt32(row[5]));
                    s.Id = Convert.ToInt32(row[5]);
                    stocks.Add(s);
                }
            }
            catch (Exception)
            {
                // TODO: add it to error log in the future
            }
            finally
            {
                conn.Close();
            }
            return stocks;
        }

        public bool RemoveStock(int id)
        {
            throw new NotImplementedException();
        }

        public int GetTotalQuantity()
        {
            return QuantityInStore + QuantityInDepot;
        }
    }
}