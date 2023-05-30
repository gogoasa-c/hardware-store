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
        private static Boolean enabledControls = false;
        public MainForm()
        {
            InitializeComponent();

            Stock currentStock = Stock.Instance; // singleton stock

            currentStock.Deserialize("file.dat");

            LoginForm loginForm = new LoginForm(ref welcomeLabel, ref showStockButton);
            loginForm.Show();
        }

        public static void enableButton()
        {
            enabledControls = true;
        }

        public static void disableButton()
        {
            enabledControls = false;
        }

        public void disableControls()
        {
            showStockButton.Enabled = false;
        }

        private void showStockButton_Click(object sender, EventArgs e)
        {
            StockForm stockForm = new StockForm(Stock.Instance);
            stockForm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            welcomeLabel.Text = "Welcome, ...";
            LoginForm loginForm = new LoginForm(ref welcomeLabel, ref showStockButton);
            LoginForm.userLogged = false;
            showStockButton.Enabled = false;
            disableButton();
            loginForm.Show();
        }
    }
}
