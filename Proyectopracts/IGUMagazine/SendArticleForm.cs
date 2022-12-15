using Magazine.Entities;
using Magazine.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IGUMagazine
{
    public partial class SendArticleForm : Form
    {


        public SendArticleForm()
        {
            InitializeComponent();
           // autor1.Hide();
            CoAuthorTextBoxName2.Hide();
            CoAuthorTextBoxName3.Hide();
            CoAuthorTextBoxName4.Hide();
            Subbutton.Enabled = false;
        }

        private void MagazineForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int count = 2;
        
        private void button1_Click(object sender, EventArgs e)
        {
            switch (count)
            {
               /* case 1:
                    autor1.Show();
                    Subbutton2.Enabled = true;
                    count++;
                    break;*/

                case 2:
                    CoAuthorTextBoxName2.Show();
                    CoAuthorTextBoxSurName2.Show();
                    CoAuthor2Button.Show();
                    Subbutton.Enabled = true;
                    count++;
                    break;

                case 3:
                    CoAuthorTextBoxName3.Show();
                    CoAuthorTextBoxSurName3.Show();
                    CoAuthor3Button.Show();
                    count++;
                    break;

                case 4:
                    CoAuthorTextBoxName4.Show();
                    CoAuthorTextBoxSurName4.Show();
                    CoAuthor4Button.Show();
                    Addbutton.Enabled = false;
                    count++;
                    break;

            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        List<Person> CoAuthors = new List<Magazine.Entities.Person>();
        private void button2_Click(object sender, EventArgs e)
        {

            switch (count)
            {
                case 2:
                    CoAuthorTextBoxName1.Hide();
                    CoAuthorTextBoxName1.Clear();

                    CoAuthorTextBoxSurName1.Hide();
                    CoAuthorTextBoxSurName1.Clear();

                    CoAuthor1Button.Hide();

                    count--;
                    break;

                case 3:
                    CoAuthorTextBoxName2.Hide();
                    CoAuthorTextBoxName2.Clear();


                    CoAuthorTextBoxSurName2.Hide();
                    CoAuthorTextBoxSurName2.Clear();

                    CoAuthor2Button.Hide();

                    Subbutton.Enabled = false;
                    count--;
                    break;

                case 4:
                    CoAuthorTextBoxName3.Hide();
                    CoAuthorTextBoxName3.Clear();

                    CoAuthorTextBoxSurName3.Hide();
                    CoAuthorTextBoxSurName3.Clear();

                    CoAuthor3Button.Hide();

                    count--;
                    break;

                case 5:
                    CoAuthorTextBoxName4.Hide();
                    CoAuthorTextBoxName4.Clear();

                    CoAuthorTextBoxSurName4.Hide();
                    CoAuthorTextBoxSurName4.Clear();

                    CoAuthor4Button.Hide();

                    Addbutton.Enabled = true;
                    count--;
                    break;

                
            }
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Area_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private Magazine.Entities.Area area;
        private void AreaTextBoxLeave(object sender, EventArgs e)
        {
            if (AreaTextBox.Text != "") {
                try
                {
                    area = LoginForm.service.FindAreaByName(AreaTextBox.Text);
                    TitleTextBox.ReadOnly = false;
                    AreaTextBox.ReadOnly = true;

                }
                catch (ServiceException)
                {

                }
            }

            
        }

        private void titulo_txt_TextChanged(object sender, EventArgs e)
        {
            if (TitleTextBox.Text != "")
            {
                Send_Button.Enabled = true;
            }
            else { 
                Send_Button.Enabled = false;
            }
        }

        private void Send_Button_Click(object sender, EventArgs e)
        {
            try {
                DateTime CurrentDate = DateTime.Now;
                Magazine.Entities.User ResponsableUser = LoginForm.service.UserLogged();
                //LoginForm.service.AddPaper(new Magazine.Entities.Paper(TitleTextBox.Text, new DateTime().Now(), area, LoginForm.service.UserLogged()));
            } catch (ServiceException ex) { 
                
            }
            

        }

        private void EditAreaDoubleClick(object sender, EventArgs e)
        {
            if (AreaTextBox.ReadOnly == true) {
                AreaTextBox.ReadOnly = false;
                TitleTextBox.ReadOnly = true;
            }
        }

        private void CoAutorTextBoxSurName4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CoAuthorTextBoxSurName2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CoAuthorTextBoxSurName3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CoAuthor1Button_Click(object sender, EventArgs e)
        {
            if (CoAuthorTextBoxName1.ReadOnly == true)
            {
                CoAuthorTextBoxName1.ReadOnly = false;
                CoAuthorTextBoxSurName1.ReadOnly = false;
                CoAuthor1Button.Text = "✓";

            }
            else
            {
                CoAuthorTextBoxName1.ReadOnly = true;
                CoAuthorTextBoxSurName1.ReadOnly = true;
                CoAuthor1Button.Text = "✎";

            }
        }

        private void CoAuthor2Button_Click(object sender, EventArgs e)
        {
            if (CoAuthorTextBoxName2.ReadOnly == true){
                CoAuthorTextBoxName2.ReadOnly = false;
                CoAuthorTextBoxSurName2.ReadOnly = false;
                CoAuthor2Button.Text = "✓";

            }
            else {
                CoAuthorTextBoxName2.ReadOnly = true;
                CoAuthorTextBoxSurName2.ReadOnly = true;
                CoAuthor2Button.Text = "✎";

            }
        }

        private void CoAuthor3Button_Click(object sender, EventArgs e)
        {
            if (CoAuthorTextBoxName3.ReadOnly == true)
            {
                CoAuthorTextBoxName3.ReadOnly = false;
                CoAuthorTextBoxSurName3.ReadOnly = false;
                CoAuthor3Button.Text = "✓";

            }
            else
            {
                CoAuthorTextBoxName3.ReadOnly = true;
                CoAuthorTextBoxSurName3.ReadOnly = true;
                CoAuthor3Button.Text = "✎";

            }
        }

        private void CoAuthor4Button_Click(object sender, EventArgs e)
        {
            if (CoAuthorTextBoxName4.ReadOnly == true)
            {
                CoAuthorTextBoxName4.ReadOnly = false;
                CoAuthorTextBoxSurName4.ReadOnly = false;
                CoAuthor4Button.Text = "✓";

            }
            else
            {
                CoAuthorTextBoxName4.ReadOnly = true;
                CoAuthorTextBoxSurName4.ReadOnly = true;
                CoAuthor4Button.Text = "✎";

            }
        }
    }
}
