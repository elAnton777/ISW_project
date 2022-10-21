using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class User
    {
        public User()
        {
            MainAuthorsPapers = new List<Paper>();
            
        }
        public User(Boolean Alerted, String AreasOfInterest, String Email, String Login, String PassWord, Magazine Magazine)
        {
            this.Alerted = Alerted;
            this.AreasOfInterest = AreasOfInterest;
            this.Email = Email;
            this.Login = Login;
            this.Password = PassWord;
            this.Magazine = Magazine;

            this.MainAuthorsPapers = new List<Paper>();
        }
    }
}
