using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Person
    {
        [Key]
        public String Id
        {

            get;

            set;
        }
        [Required]
        public string Name
        {

            get;

            set;
        }
        [Required]
        public string Surname
        {

            get;

            set;
        }
        public virtual ICollection<Paper> CoAuthoredPapers
        {

            get;

            set;
        }

    }


}
