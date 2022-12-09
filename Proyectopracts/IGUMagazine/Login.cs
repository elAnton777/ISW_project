using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine.Services;

namespace IGUMagazine
{
    public partial class Login : Form
    {
        
        private IMagazineService service;
        public Login()
        {
            InitializeComponent();
            this.service = service;
        }


        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*';
        }

    }
}
