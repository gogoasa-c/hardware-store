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
        Stock currStock;
        public StockForm(Stock currStock)
        {
            InitializeComponent();
            this.currStock = currStock;
            // adds the items in stock into the stocksListView
            foreach (Component comp in currStock.Keys)
            {
                this.stocksListView.Items.Add(comp.Name);
                this.stocksListView.Items[this.stocksListView.Items.Count - 1].SubItems.Add(currStock.GetValue(comp).ToString());
            }
        }

        private void newItemButton_Click(object sender, EventArgs e)
        {
            AddOrEditForm addForm = new AddOrEditForm("Add", currStock, stocksListView);
            addForm.Show();
        }

        private void removeItemButton_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = stocksListView.SelectedItems[0];
            DialogResult result = MessageBox.Show("Are sure you wish to delete the selected item?", "Delete Item", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                // delete item from stock
                currStock.Delete(selectedItem.Text);
                // and also from stocksListView
                foreach(ListViewItem item in stocksListView.Items)
                {
                    if (item.Text == selectedItem.Text)
                    {
                        stocksListView.Items.Remove(item);
                        return;
                    }
                }
            }
            return;
        }
    }
}
