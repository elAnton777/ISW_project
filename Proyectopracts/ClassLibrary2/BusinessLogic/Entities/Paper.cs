using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Paper
    {
        public Paper()
        {
            CoAuthors = new List<Person>();
        }

        public void AddCoAuthor(Person person) {
            if (this.CoAuthors.Count < 4)
            {
                this.CoAuthors.Add(person);
            }
            else
            {
                throw new Exception("No pueden haber mas de 4 coautores");
            }
        }

        public Paper(string Title, DateTime UploadDate, Area BelongingArea, User Responsible) :this()
        {
            //this.Id = Id;
            this.Title = Title;
            this.UploadDate = UploadDate;
            this.Responsible = Responsible;

            this.BelongingArea = BelongingArea;
            AddCoAuthor(Responsible);

            //this.CoAuthors = new List<Person>();
        }
    }
}
