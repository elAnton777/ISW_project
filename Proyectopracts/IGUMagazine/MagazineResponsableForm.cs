using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IGUMagazine
{
    public partial class MagazineResponsableForm : Form
    {
        public MagazineResponsableForm()
        {
            InitializeComponent();
        }

        private void MagazineResponsableForm_Load(object sender, EventArgs e)
        {

        }

        private void evaluar_boton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EvaluarArticulos evaluararticulos = new EvaluarArticulos();
            evaluararticulos.ShowDialog();
            this.Show();
        }

        private void enviar_boton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SendArticleForm magazineuserform = new SendArticleForm();
            magazineuserform.ShowDialog();
            this.Show();
        }
    }
}
