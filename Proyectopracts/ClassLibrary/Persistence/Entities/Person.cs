using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Person 
    {
        public Person()

        {
            CoAuthorPapers = new List<Paper>();
        }
        public Person(string Id, string Name, string Surname)
        {
            this.Id = Id;
            this.Name = Name;
            this.Surname = Surname;
            this.CoAuthorPapers = new List<Paper>();
        }

    }   

    
}
