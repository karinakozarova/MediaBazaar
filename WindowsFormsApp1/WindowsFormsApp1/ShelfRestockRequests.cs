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
            listView1.Columns.Add("Arrival Date", 100);
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Description", 200);
            listView1.Columns.Add("Quantity", 100);
        }
    }
}
