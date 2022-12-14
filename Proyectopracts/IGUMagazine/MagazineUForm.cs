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
        bool hidden = false;
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (count == 1)
            {
                textBox2.Show();
            }
            if (count == 2)
            {
                textBox3.Show();
            }
            if (count == 3)
            {
                textBox4.Show();
            }
            if (count == 4)
            {
                textBox5.Show();
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
            if (count != 0)
            {
                if (count == 1)
                {
                    textBox2.Hide();
                    textBox2.Clear();
                    count--;
                }
                if (count == 2)
                {
                    textBox3.Hide();
                    textBox3.Clear();
                    count--;
                }
                if (count == 3)
                {
                    textBox4.Hide();
                    textBox4.Clear();
                    count--;
                }
                if (count == 4)
                {
                    textBox5.Hide();
                    textBox5.Clear();
                    count--;
                }
            }
        }
    }
}
