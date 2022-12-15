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

        private void BotonInicio_Click(object sender, EventArgs e)
        {
            Console.WriteLine(UserTextBox.Text);
            try
            {
                service.Login(UserTextBox.Text, PasswordTextBox.Text);

                SelectActionForm selectActionForm = new SelectActionForm();
                this.Hide();
                selectActionForm.ShowDialog();
                this.Close();
            }
            catch (ServiceException ex) {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
