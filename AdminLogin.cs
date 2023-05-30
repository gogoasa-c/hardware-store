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
    public partial class AdminLogin : UserControl
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        public TextBox UsernameTextBox {
            get => this.usernameTextBox;
        }
        public TextBox PasswordTextBox {
            get => this.passwordTextBox;
        }
    }
}
