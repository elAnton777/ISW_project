﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Person
    {
        {
        public int Id
        {

            get;

            set;
        }
        public string Name
        {

            get;

            set;
        }
        public string Surname
        {

            get;

            set;
         }
        public ICollection<Paper> CoAuthorPapers {

            get; 
            
            set; 
        }

    }
}
