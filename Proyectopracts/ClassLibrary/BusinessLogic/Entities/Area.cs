using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Area
    {
        public Area()
        {
            Papers = new List<Paper>();
            EvaluationPending = new List<Paper>();
            PublicationPending = new List<Paper>();
        }
        public Area(int Id, String Name, User Editor)
        {
            this.Id = Id;
            this.Name = Name;
            this.Editor = Editor;

            this.Papers = new List<Paper>();
            this.EvaluationPending = new List<Paper>();
            this.PublicationPending = new List<Paper>();

        }
    }
}
