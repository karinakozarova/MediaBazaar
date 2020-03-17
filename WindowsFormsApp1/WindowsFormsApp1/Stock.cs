using MySql.Data.MySqlClient;
using System;

namespace WindowsFormsApp1
{
    public class Stock
    {
        private int id;

        public string Name
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

        public Stock(string name, int quantityInDepot, int quantityInStore, decimal price, int departmentId)
        {
            this.Name = name;
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
                string sql = "INSERT INTO stock(name, department_id, quantity_in_depo, quantity_in_store, price, currency_id) VALUES (@name, @department_id, @depo, @store, @price, 1);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@department_id", DepartmentId);
                cmd.Parameters.AddWithValue("@depo", QuantityInDepot);
                cmd.Parameters.AddWithValue("@store", QuantityInStore);
                cmd.Parameters.AddWithValue("@price", Price);
                conn.Open();
                int effectedRows = cmd.ExecuteNonQuery();
                this.id = (int)cmd.LastInsertedId;
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