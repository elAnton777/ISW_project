﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class User
    {
        public Boolean Alerted { get; set; }

        public String Name { get; set; }

        public String Email { get; set; }

        public String Login { get; set; }

        public String Password { get; set; }

        public String AreasOfInterest { get; set; }

        public Magazine Magazine { get; set; }

        public ICollection<Paper> MainAuthorsPapers { get; set; }
    }
}
