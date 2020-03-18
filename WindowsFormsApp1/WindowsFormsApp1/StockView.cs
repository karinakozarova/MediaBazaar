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

            populateStocks(Stock.GetAllStocks());
        }

        private void populateStocks(List<Stock> stocks)
        {
            stocksViewLbx.Items.Clear();
            foreach (Stock s in stocks)
            {
                stocksViewLbx.Items.Add(new ListViewItem(new[] { s.Name, s.Description, s.QuantityInStore.ToString(), s.QuantityInDepot.ToString(), s.Price.ToString() }));
            }
        }

        private void removeStockBttn_Click(object sender, EventArgs e)
        {

        }

        private void editStockBttn_Click(object sender, EventArgs e)
        {

        }

        private void filterStocksBttn_Click(object sender, EventArgs e)
        {
            int departmentId = ((DepartmentComboBoxItem)departmentsCmbbxStockView.SelectedItem).Id;
            string productName = (stockNameTbx.Text != "Stock name" ? stockNameTbx.Text : null);
            List<Stock> stocks = Stock.FilterStocks(departmentId, productName);
            populateStocks(stocks);
        }

        private void stocksViewLbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: on change
        }
    }
}
