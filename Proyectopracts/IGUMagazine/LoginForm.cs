using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine.Persistence;
using Magazine.Services;

namespace IGUMagazine
{
    public partial class LoginForm : Form
    {

        public static MagazineService service = new MagazineService(new EntityFrameworkDAL(new MagazineDbContext()));
        public LoginForm()
        { 
            InitializeComponent();
            service.DBInitialization();
        }


        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*';
        }

        private void BotonInicio_Click(object sender, EventArgs e)
        {
            Console.WriteLine(UserTextBox.Text);
            try
            {
                service.Login(UserTextBox.Text, PasswordTextBox.Text);

                SendArticleForm magazineform = new SendArticleForm();
                this.Hide();
                magazineform.ShowDialog();
                this.Close();
            }
            catch (ServiceException ex) {
                switch(ex.Message)
                {
                    case "Introduzca un usuario":   
                        UserError.Text = ex.Message;
                        UserError.Visible = true;
                        break;
                    case "Introduzca una contraseña":
                        PasswordError.Text = ex.Message;
                        PasswordError.Visible= true;
                        break;
                    case "El usuario no existe":
                        UserError.Text = ex.Message;
                        UserError.Visible = true;
                        break;
                    case "La contraseña es incorrecta":
                        PasswordError.Text = ex.Message;
                        PasswordError.Visible = true;
                        break;
                }
                
            }
        }

        private void UserError_Click(object sender, EventArgs e)
        {

        }

        private void PasswordError_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
