using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Magazine
    {
        public Magazine() 
        {
            Issues = new List<Issue>();
            Areas = new List<Area>();
        }
        public Magazine(String Name, User ChiefEditor) :this()
        {
            //this.Id = Id;
            this.Name = Name;
            this.ChiefEditor = ChiefEditor;

           /* this.Issues = new List<Issue>();
            this.Areas = new List<Area>();*/
        }
    }
}
