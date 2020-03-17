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
    public partial class ShelfRestockRequests : Form
    {
        public ShelfRestockRequests()
        {
            InitializeComponent();
            List<ShelfRequests> requests = ShelfRequests.GetAllShelfRestockRequests();

            foreach(ShelfRequests request in requests)
            {
                shelfRestockView.Items.Add(new ListViewItem(new[] { "[WIP, in later phase]", request.Name, request.Description, request.Quantity.ToString()}));
            }
        }
    }
}
