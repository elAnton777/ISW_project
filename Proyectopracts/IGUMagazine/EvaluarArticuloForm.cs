using Magazine.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Magazine.Services;

namespace IGUMagazine
{
    public partial class EvaluarArticuloForm : Form
    {
        public EvaluarArticuloForm()
        {
            InitializeComponent();
            AceptarButton.Enabled = false;

            foreach (Area area in LoginForm.service.getAllAreas())
            {
                AreasComboBox.Items.Add(area.Name);
            }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ArticulosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        Area area = new Area();
        private void AreaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String AreaSeleccioada = AreasComboBox.Text;
            if (AreaSeleccioada != "")
            {
                area = LoginForm.service.FindAreaByName(AreaSeleccioada);
                foreach (Paper paper in area.EvaluationPending)
                {
                    ArticulosComboBox.Items.Add(paper.Title + " ");
                }
            }

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool accepted = checkBox1.Checked;
                string comments = CommentsTextBox.Text;
                DateTime date = DateTime.Now;
                Paper paper = LoginForm.service.getPaperByName((string)ArticulosComboBox.SelectedItem);
                LoginForm.service.EvaluatePaper(accepted, comments, date, paper.Id);
                LoginForm.service.setPublicationPending(area, paper);

                ArticulosComboBox.Items.Clear();
                ArticulosComboBox.Text = "";
                checkBox1.Checked = false;
                CommentsTextBox.Text = "";
                AreasComboBox.Focus();
            } catch(ServiceException ex) {
                MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void CancelEvaluation_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int count = 1;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                AceptarButton.Enabled = true;
            }
            else
            {
                AceptarButton.Enabled = false;
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
