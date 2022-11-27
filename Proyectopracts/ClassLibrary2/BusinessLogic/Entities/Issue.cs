using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Issue
    {
        public Issue()
        {
            PublishedPapers = new List<Paper>();
        }

        

        public Issue( int Number, Magazine magazine) :this()
        {
            //this.Id = Id;
            this.Number = Number;
            PublicationDate = null;
            this.Magazine = magazine;

           // this.PublishedPapers = new List<Paper>();
        }

        void AddPaper(Paper paper) { 
            this.PublishedPapers.Add(paper);
        }

        void RemovePaper(Paper paper)
        {
            this.PublishedPapers.Remove(paper);
        }
    }
}
