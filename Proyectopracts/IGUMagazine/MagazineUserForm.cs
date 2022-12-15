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
    public partial class MagazineUserForm : Form
    {
        public MagazineUserForm()
        {
            InitializeComponent();
            autor1.Hide();
            autor2.Hide();
            autor3.Hide();
            autor4.Hide();
            Subbutton2.Enabled = false;
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
        int count = 1;
        
        private void button1_Click(object sender, EventArgs e)
        {
            switch (count)
            {
                case 1:
                    autor1.Show();
                    Subbutton2.Enabled = true;
                    count++;
                    break;

                case 2:
                    autor2.Show();
                    count++;
                    break;

                case 3:
                    autor3.Show();
                    count++;
                    break;

                case 4:
                    autor4.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {

            switch (count)
            {
                case 2:
                    autor1.Hide();
                    autor1.Clear();
                    Subbutton2.Enabled = false;
                    count--;
                    break;

                case 3:
                    autor2.Hide();
                    autor2.Clear();
                    count--;
                    break;

                case 4:
                    autor3.Hide();
                    autor3.Clear();
                    count--;
                    break;

                case 5:
                    autor4.Hide();
                    autor4.Clear();
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
    }
}
