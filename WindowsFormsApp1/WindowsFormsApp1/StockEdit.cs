using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StockEdit : Form
    {
        int id;
        Stock s;
        public StockEdit(int id)
        {
            this.id = id;
            InitializeComponent();
            s = Stock.GetStockById(id);
            populateForm(s);
        }

        private void populateForm(Stock s)
        {
            stocksEditNameTbx.Text = s.Name;
            pricePerItemTbx.Value = s.Price;
            depoQuantityStock.Value = s.QuantityInDepot;
            storeQuantityStock.Value = s.QuantityInStore;
            idLbl.Text = s.Id.ToString();
            DepartmentLbl.Text = Department.GetDepartmentById(s.DepartmentId).Name;
        }

        private void editStockBttn_Click(object sender, EventArgs e)
        {
            Stock.EditStock(this.id, stocksEditNameTbx.Text, pricePerItemTbx.Value, storeQuantityStock.Value, depoQuantityStock.Value);
            this.Hide();
        }
    }
}
