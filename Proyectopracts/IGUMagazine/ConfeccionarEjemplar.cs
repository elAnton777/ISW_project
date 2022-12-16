using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Magazine.Entities;
using Magazine.Services;

namespace IGUMagazine
{
    public partial class ConfeccionarEjemplar : Form
    {
        public ConfeccionarEjemplar()
        {
            InitializeComponent();
            foreach (Magazine.Entities.Magazine magazine in LoginForm.service.GetAllMagazines())
            {
                MagazineComboBox.Items.Add(magazine.Name);
            }
            foreach (Area area in LoginForm.service.getAllAreas())
            {
                AreaPicker.Items.Add(area.Name);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListaArticulos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Issue issue = new Issue();
        private void MagazineComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                issue = LoginForm.service.getIssue(LoginForm.service.FindMagazine((string)MagazineComboBox.SelectedItem));
            }
            catch (ServiceException ex)
            {
                //Poner lo de los mensajes
            }
        }

        private void AreaPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Area area = LoginForm.service.FindAreaByName(AreaPicker.SelectedItem.ToString());
                IEnumerable<Paper> publicationPendingPapers = LoginForm.service.GetPublicationPendingPapers(area);
                foreach (Paper paper in publicationPendingPapers)
                {
                    if (!issue.PublishedPapers.Contains(paper))
                    {
                        PublicationPendingListBox.Items.Add(paper.Title);
                    }
                    else
                    {
                        CurrentAreaIssueListBox.Items.Add(paper.Title);
                    }

                }
            }
            catch (ServiceException ex)
            {
                //Poner lo de los mensajes
            }
        }

        private void AddToIssueButton_Click(object sender, EventArgs e)
        {
            CurrentAreaIssueListBox.Items.Add(PublicationPendingListBox.SelectedItem);
            PublicationPendingListBox.Items.Remove(PublicationPendingListBox.SelectedItem);
            Area selectedArea = LoginForm.service.FindAreaByName(AreaPicker.SelectedItem.ToString());
        }

        private void RemoveFromIssueButton_Click(object sender, EventArgs e)
        {
            PublicationPendingListBox.Items.Add(CurrentAreaIssueListBox.SelectedItem);
            CurrentAreaIssueListBox.Items.Remove(CurrentAreaIssueListBox.SelectedItem);
        }
    }
}
