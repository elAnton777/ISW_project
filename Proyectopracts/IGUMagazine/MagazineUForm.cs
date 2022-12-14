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
    public partial class MagazineUForm : Form
    {
        public MagazineUForm()
        {
            InitializeComponent();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            button2.Enabled = false;
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
                    textBox2.Show();
                    button2.Enabled = true;
                    count++;
                    break;

                case 2:
                    textBox3.Show();
                    count++;
                    break;

                case 3:
                    textBox4.Show();
                    count++;
                    break;

                case 4:
                    textBox5.Show();
                    button1.Enabled = false;
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
                    textBox2.Hide();
                    textBox2.Clear();
                    button2.Enabled = false;
                    count--;
                    break;

                case 3:
                    textBox3.Hide();
                    textBox3.Clear();
                    count--;
                    break;

                case 4:
                    textBox4.Hide();
                    textBox4.Clear();
                    count--;
                    break;

                case 5:
                    textBox5.Hide();
                    textBox5.Clear();
                    button1.Enabled = true;
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
