using System;
using System.Collections.Generic;
using System.Linq;
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


        public Paper(string Title, DateTime UploadDate, Area BelongingArea, User Responsible) :this()
        {
            //this.Id = Id;
            this.Title = Title;
            this.UploadDate = UploadDate;
            this.Responsible = Responsible;

            this.BelongingArea = BelongingArea;
            CoAuthors.Add(Responsible);

            //this.CoAuthors = new List<Person>();
        }
    }
}
