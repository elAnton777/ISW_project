using Magazine.Entities;
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
    public partial class ListaArticulos : Form
    {
        public ListaArticulos()
        {
            InitializeComponent();

            IEnumerable<Area> areas= LoginForm.service.getAllAreas();
            foreach (Area area in areas)
            {
                foreach (Paper paper in area.Papers)
                {
                    String autores = "";
                    for (int i = 0; i < paper.CoAuthors.Count; i++)
                    {
                        autores += paper.CoAuthors.ElementAt(i).Name + " " + paper.CoAuthors.ElementAt(i).Surname + " | ";
                    }

                    string status = "";

                    if (area.EvaluationPending.Contains(paper))
                    {
                        status = "Evaluación pendiente";
                    }
                    else if(area.PublicationPending.Contains(paper))
                    {
                        status = "Publicación pendiente";
                    }
                    else if(paper.Evaluation.Accepted == false)
                    {
                        status = "Rechazado";
                    }
                    else
                    {
                        status = "Publicado";
                    }

                    TablaDatos.Rows.Add(paper.Title, autores, status);
                }
                
            }
        }
    }
}
