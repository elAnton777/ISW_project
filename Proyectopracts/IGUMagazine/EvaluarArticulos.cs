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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Lista.Columns.Add("Título", -2,HorizontalAlignment.Left);
            Lista.Columns.Add("Autor", -2, HorizontalAlignment.Center);
            Lista.Columns.Add("fecha", -2, HorizontalAlignment.Right);

        }
    }
}
