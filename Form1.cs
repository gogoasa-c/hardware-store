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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GraphicsCard gtx1050 = new GraphicsCard(4, 256, "GTX 1050", 700, ComponentType.GraphicsCard);
            /*gtx1050.Serialize("test.dat");
            GraphicsCard gtx1050Deserialized = GraphicsCard.Deserialize("test.dat");
            MessageBox.Show(gtx1050Deserialized.ToString());
            *//*Component comp = gtx1050;
            comp.Serialize("test.dat");
            Component compDeserialized = Component.Deserialize("test.dat");
            gtx1050 = (GraphicsCard)compDeserialized;
            MessageBox.Show(gtx1050.ToString());*/

            Stock currentStock = Stock.Instance; // singleton stock
            currentStock.AddMultipleToStock(gtx1050, 10);

        }

        private void showStockButton_Click(object sender, EventArgs e)
        {
            StockForm stockForm = new StockForm(Stock.Instance);
            stockForm.Show();
        }
    }
}
