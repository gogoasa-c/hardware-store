using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hardware_store
{
    public partial class StockForm : Form
    {
        public StockForm(Stock currStock)
        {
            InitializeComponent();
            /*foreach(Component comp in currStock.ComponentStock.Keys.ToList())
            {
                this.stocksListView.Items.Add(comp.Name);
                this.stocksListView.Items[this.stocksListView.Items.Count - 1].SubItems.Add(currStock.ComponentStock[comp].ToString());
            }*/
        }
    }
}
