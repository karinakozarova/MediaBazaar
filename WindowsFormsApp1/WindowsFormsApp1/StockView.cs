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
    public partial class StockView : Form
    {
        public StockView()
        {
            InitializeComponent();
            List<Department> departments = Department.GetAllDepartments();
            foreach (Department d in departments) departmentsCmbbxStockView.Items.Add(new DepartmentComboBoxItem(d));

            // populateStocks(Stock.GetAllStocks());
        }

        private void populateStocks(List<Stock> stocks)
        {
            stocksViewLbx.Items.Clear();
            foreach (Stock s in stocks)
            {
                stocksViewLbx.Items.Add(s.Name);
            }
        }
        private void removeStockBttn_Click(object sender, EventArgs e)
        {
            List<Stock> stocks = Stock.GetAllStocks();
            foreach (Stock s in stocks) stocksViewLbx.Items.Add(new StocksComboBoxItem(s));
            //populateStocks();
        }

        private void editStockBttn_Click(object sender, EventArgs e)
        {

        }
    }
}
