using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                LoginForm.service.Register(_user);

            }
            catch (ServiceException ex) {
                //DoSomething
                switch (ex.Message)
                {
                    case "Introduzca un usuario":
                        UserError.Text = ex.Message;
                        UserError.Visible = true;
                        break;
                    case "Introduzca una contraseña":
                        PasswordError.Text = ex.Message;
                        PasswordError.Visible = true;
                        break;
                    case "El usuario ya existe":
                        UserError.Text = ex.Message;
                        UserError.Visible = true;
                        break;
                    case "Introduzca un correo electrónico":
                        EmailError.Text = ex.Message;
                        EmailError.Visible = true;
                        break;
                    case "Introduzca una area de interes":
                        AreaError.Text = ex.Message;
                        AreaError.Visible = true;
                        break;
                    case "Introduzca su nombre":
                        NameError.Text = ex.Message;
                        NameError.Visible = true;
                        break;
                    case "Introduzca su apellido":
                        SurnameError.Text = ex.Message;
                        SurnameError.Visible = true;
                        break;
                }
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }        
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserError_Click(object sender, EventArgs e)
        {

        }

        private void PasswordError_Click(object sender, EventArgs e)
        {

        }

        private void EmailError_Click(object sender, EventArgs e)
        {

        }

        private void AreaError_Click(object sender, EventArgs e)
        {

        }

        private void NameError_Click(object sender, EventArgs e)
        {

        }

        private void SurnameError_Click(object sender, EventArgs e)
        {

        }

        private void AreaOfInterestTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
