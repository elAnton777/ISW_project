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
    public partial class EvaluarArticulos : Form
    {
        public EvaluarArticulos()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Lista.Columns.Add("Título", -2,HorizontalAlignment.Left);
            Lista.Columns.Add("Autor", -2, HorizontalAlignment.Center);
            Lista.Columns.Add("fecha", -2, HorizontalAlignment.Right);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
