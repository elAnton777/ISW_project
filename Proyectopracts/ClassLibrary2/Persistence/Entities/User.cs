using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class User :Person
    {
        [Required]
        public bool Alerted { get; set; }

        [Required]
        public String Email { get; set; }

        public virtual Area Area { get; set; }

        [Required]
        public String Login { get; set; }

        [Required]
        public String Password { get; set; }

        [Required]
        public String AreasOfInterest { get; set; }

        public virtual Magazine Magazine { get; set; }

        public virtual ICollection<Paper> MainAuthoredPapers { get; set; }

    }
}
