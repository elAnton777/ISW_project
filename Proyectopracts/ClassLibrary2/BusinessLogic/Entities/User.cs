using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class User : Person
    {
      
        public User()
        {
            MainAuthoredPapers = new List<Paper>();
            
        }
        public User(string Id, string Name, string Surname, bool Alerted, String AreasOfInterest, String Email, String Login, String PassWord) :base(Id, Name, Surname)
        {
            this.Alerted = Alerted;
            this.AreasOfInterest = AreasOfInterest;
            this.Email = Email;
            this.Login = Login;
            this.Password = PassWord;
            

            this.MainAuthoredPapers = new List<Paper>();
        }
        

     
    }
}
