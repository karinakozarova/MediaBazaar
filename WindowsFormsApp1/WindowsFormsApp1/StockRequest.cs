using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class ShelfRequests: Stock
    {
        public int Quantity
        {
            get;
            private set;
        }
        public ShelfRequests(string name, string description, int quantityInDepot, int quantityInStore, decimal price, int departmentId, int quantity) : base(name, description, quantityInDepot, quantityInStore, price, departmentId)
        {
            this.Quantity = quantity;
        }
        public ShelfRequests(Stock s, int quantity) : base(s.Name, s.Description, s.QuantityInDepot, s.QuantityInStore, s.Price, s.DepartmentId)
        {
            this.Quantity = quantity;
        }

        public static List<ShelfRequests> GetAllShelfRestockRequests()
        {
            MySqlConnection conn = Utils.GetConnection();

            List<ShelfRequests> requests = new List<ShelfRequests>();
            List<Stock> stocks = new List<Stock>();
            try
            {
                string sql = "SELECT name, description, quantity_in_depo, quantity_in_store, price, department_id, needed_quantity FROM stock INNER JOIN stockrequests ON stock_id = id;";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();    
                MySqlDataReader row = cmd.ExecuteReader();

                while (row.Read())
                {
                    ShelfRequests request = new ShelfRequests(row[0].ToString(),row[1].ToString(), Convert.ToInt32(row[2].ToString()), Convert.ToInt32(row[3]), Convert.ToInt32(row[4]), Convert.ToInt32(row[5]), Convert.ToInt32(row[6]));
                    requests.Add(request);
                }
            }
            catch (Exception e)
            {
                // TODO: add it to error log in the future
            }
            finally
            {
                conn.Close();
            }
            return requests;
        }
    }
}