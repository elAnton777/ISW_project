using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class User
    {
        public object CoAuthoredPapers;
        public object MainAuthoredPapers;
        public object Surname;
        public object Id;
        public object Area;

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

        public User(string eXPECTED_PERSON_ID, string eXPECTED_PERSON_NAME, string eXPECTED_PERSON_SURNAME, bool eXPECTED_USER_ALERTED, string eXPECTED_USER_AREASOFINTEREST, string eXPECTED_USER_EMAIL, string eXPECTED_USER_LOGIN, string eXPECTED_USER_PASSWORD)
        {
        }
    }
}
