﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Paper
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime UploadDate { get; set; }
        public virtual Evaluation Evaluation { get; set; }
        public virtual User Responsible { get; set; }
        public virtual Area BelongingArea { get; set; }
        public virtual Area EvaluationPendingArea { get; set; }
        public virtual Area PublicationPendingArea { get; set; } 
        public virtual ICollection<Person> CoAuthors { get; set; }
        public virtual Issue Issue { get; set; }



    }
}
