using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Area
    {
        public int Id
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public virtual ICollection<Paper> Papers
        {
            get;
            set;
        }

        public virtual ICollection<Paper> EvaluationPending 
        {
            get;
            set;
        }
        
        public virtual ICollection<Paper> PublicationPending 
        {
            get; 
            set;
        }

        [Required]
        public virtual User Editor 
        {
            get;
            set;
        }

        [Required]
        public virtual Magazine Magazine { get; set; }
    }
}
