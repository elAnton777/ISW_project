using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGUMagazine
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void back_button_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                Random _random = new Random();
                string _id = _random.Next(0, 9999).ToString("D4");

                Magazine.Entities.User _user = new Magazine.Entities.User(_id, NameTextBox.Text, SurnameTextBox.Text, AlertedTickBox.Checked, AreaOfInterestTextBox.Text, EmailTextBox.Text, UsernameTextBox.Text, PasswordTextBox.Text);
                Console.WriteLine(_user.AreasOfInterest);
                LoginForm.service.Register(_user);

            }
            catch (ServiceException) {
                //DoSomething
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);    
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
