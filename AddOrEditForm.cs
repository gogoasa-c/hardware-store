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

        public AddOrEditForm(string type, Stock CurrStock, ListView stockViewList, int indexOfItem)
        {
            InitializeComponent();
            addEditButton.Text = type;
            this.currStock = CurrStock;
            this.stockListView = stockViewList;
            
            Component currComponent = stockListView.Items[indexOfItem].Tag as Component;
            nameTextBox.Text = currComponent.Name;
            priceTextBox.Text = currComponent.Price.ToString();
            componentTypeCombo.Text = currComponent.Type.ToString();
            componentTypeCombo.Enabled = false;
            switch (componentTypeCombo.Text)
            {
                case "Processor":
                    custom1Label.Text = "No. Cores:";
                    custom2Label.Text = "GHz:";
                    Processor p = currComponent as Processor;
                    custom1TextBox.Text = p.Cores.ToString();
                    custom2TextBox.Text = p.Frequency.ToString();
                    break;
                case "HardDrive":
                    custom1Label.Text = "Capacity:";
                    custom2Label.Text = "RPM:";
                    HardDrive hdd = currComponent as HardDrive;
                    custom1TextBox.Text = hdd.Capacity.ToString();
                    custom2TextBox.Text = hdd.RotationsPerMinute.ToString();
                    break;
                case "RAM":
                    custom1Label.Text = "Space:";
                    custom2Label.Text = "Frequency:";
                    RamMemory ram = currComponent as RamMemory;
                    custom1TextBox.Text = ram.Memory.ToString();
                    custom2TextBox.Text = ram.Frequency.ToString();
                    break;
                case "GraphicsCard":
                    custom1Label.Text = "Video Memory:";
                    custom2Label.Text = "Bitrate:";
                    GraphicsCard gc = currComponent as GraphicsCard;
                    custom1TextBox.Text = gc.VideoMemory.ToString();
                    custom2TextBox.Text = gc.Bitrate.ToString();
                    break;
            }
            custom1TextBox.Enabled = false;
            custom2TextBox.Enabled = false;
            quantityTextBox.Text = currStock.GetQuantity(currComponent).ToString();
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
                        component = new HardDrive(int.Parse(custom1TextBox.Text), int.Parse(custom2TextBox.Text), nameTextBox.Text, double.Parse(priceTextBox.Text), ComponentType.HardDrive);
                        break;
                    case "RAM":
                        component = new RamMemory(int.Parse(custom1TextBox.Text), int.Parse(custom2TextBox.Text), nameTextBox.Text, double.Parse(priceTextBox.Text), ComponentType.RAM);
                        break;
                    case "Graphics Card":
                        component = new GraphicsCard(int.Parse(custom1TextBox.Text), int.Parse(custom2TextBox.Text), nameTextBox.Text, double.Parse(priceTextBox.Text), ComponentType.GraphicsCard);
                        break;
                    default:
                        return;
                        // do nothing ^
                }
                this.currStock.AddMultipleToStock(component, quantity);
                this.stockListView.Items.Add(component.Name);
                this.stockListView.Items[this.stockListView.Items.Count - 1].SubItems.Add(quantity.ToString());
            }
            if(type == "Edit")
            {
                Component currComponent = stockListView.SelectedItems[0].Tag as Component;
                int newQuantity = int.Parse(quantityTextBox.Text);
                string newName = nameTextBox.Text;
                double newPrice = double.Parse(priceTextBox.Text);
                currComponent.Name = newName;
                currComponent.Price = newPrice;
                currStock.setQuantity(currComponent, newQuantity);
                this.stockListView.Items[this.stockListView.SelectedItems[0].Index].SubItems[0].Text = newName;
                this.stockListView.Items[this.stockListView.SelectedItems[0].Index].SubItems[1].Text = newQuantity.ToString();
                this.stockListView.Items[this.stockListView.SelectedItems[0].Index].Tag = currComponent;
            }
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
