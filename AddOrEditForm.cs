using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hardware_store
{
 
    public partial class AddOrEditForm : Form
    {
        Stock currStock;
        ListView stockListView;
        public AddOrEditForm(string type, Stock CurrStock, ListView stockViewList)
        {
            InitializeComponent();
            addEditButton.Text = type;
            this.currStock = CurrStock;
            this.stockListView = stockViewList;
        }

        private void componentTypeCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            string selection = componentTypeCombo.Text;
            switch (selection)
            {
                case "Processor":
                    custom1Label.Text = "No. Cores:";
                    custom2Label.Text = "GHz:";
                    break;
                case "Hard Drive":
                    custom1Label.Text = "Capacity:";
                    custom2Label.Text = "RPM:";
                    break;
                case "RAM":
                    custom1Label.Text = "Space:";
                    custom2Label.Text = "Frequency:";
                    break;
                case "Graphics Card":
                    custom1Label.Text = "Video Memory:";
                    custom2Label.Text = "Bitrate:";
                    break;
            }
        }

        private void addEditButton_Click(object sender, EventArgs e)
        {
            string type = addEditButton.Text;
            if(type == "Add")
            {

                
                Component component;
                int quantity = int.Parse(quantityTextBox.Text);
                switch (componentTypeCombo.Text)
                {
                    case "Processor":
                        component = new Processor(int.Parse(custom1TextBox.Text), float.Parse(custom2TextBox.Text), nameTextBox.Text, double.Parse(priceTextBox.Text), ComponentType.Processor);
                        break;
                    case "Hard Drive":
                        component = new HardDrive(int.Parse(custom1TextBox.Text), int.Parse(custom2TextBox.Text), nameTextBox.Text, double.Parse(priceTextBox.Text), ComponentType.Processor);
                        break;
                    case "RAM":
                        component = new RamMemory(int.Parse(custom1TextBox.Text), int.Parse(custom2TextBox.Text), nameTextBox.Text, double.Parse(priceTextBox.Text), ComponentType.Processor);
                        break;
                    case "Graphics Card":
                        component = new GraphicsCard(int.Parse(custom1TextBox.Text), int.Parse(custom2TextBox.Text), nameTextBox.Text, double.Parse(priceTextBox.Text), ComponentType.Processor);
                        break;
                    default:
                        return;
                        // do nothing ^
                }
                this.currStock.AddMultipleToStock(component, quantity);
                this.stockListView.Items.Add(component.Name);
                this.stockListView.Items[this.stockListView.Items.Count - 1].SubItems.Add(quantity.ToString());

                this.Close();
            }

        }
    }
}
