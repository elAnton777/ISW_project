﻿using System;
using System.Collections.Generic;
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

        public virtual User Editor 
        {
            get;
            set;
        }

        public virtual Magazine Magazine { get; set; }
    }
}
