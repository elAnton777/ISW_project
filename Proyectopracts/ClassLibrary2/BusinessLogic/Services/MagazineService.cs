using Magazine.Entities;
using Magazine.Persistence;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Services
{
    public class MagazineService: IMagazineService 
    {
        private readonly IDAL dal;

        private User user;


        public MagazineService(IDAL dal)
        {
            this.dal = dal;
        }

        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        public void Commit()
        {
            dal.Commit();
        }

        public void DBInitialization()
        {
            RemoveAllData();

            User u1 = new User("1234", "Pepe", "TheBoss", false, "ninguna", "ptheboss@gmail.com", "theboss", "1234");
            AddUser(u1);

            Magazine.Entities.Magazine m = new Magazine.Entities.Magazine("Revista Universitaria", u1);
            AddMagazine(m);

            User u2 = new User("2345", "Javier", "Garcia", false, "la mia", "jgarcia@gmail.com", "jgarcia", "1234");
            AddUser(u2);
            Area a1 = new Area("Area 1", u2, m);
            AddArea(a1);

            User u3 = new User("3456", "Mª Carmen", "Jimenez", false, "la mia por supuesto", "mcjimenez@gmail.com", "mcjimenez", "1234");
            AddUser(u3);
            Area a2 = new Area("Area 2", u3, m);
            AddArea(a2);

            // De regalo
            User u4 = new User("4567", "Juan", "Campeador", false, "la mejor", "jcampeador@gmail.com", "jcampeador", "1234");
            AddUser(u4);
        }

        public void AddPerson(Person person)
        {
            // Restricción: No puede haber dos personas con el mismo DNI
            if (dal.GetById<Person>(person.Id) == null)
            {
                dal.Insert<Person>(person);
                dal.Commit();
            }
            else throw new ServiceException("Person with Id " + person.Id + " already exists.");
        }

        public void AddMagazine(Magazine.Entities.Magazine magazine)
        {
            // Restricción: No puede haber dos revistas con el mismo nombre
            if (!dal.GetWhere<Magazine.Entities.Magazine>(x => x.Name == magazine.Name).Any())
            {
                dal.Insert<Magazine.Entities.Magazine>(magazine);
                dal.Commit();
            }
            else throw new ServiceException("Magazine with name " + magazine.Name + " already exists.");
        }

        public void AddArea(Area area)
        {
            // Restricción: No puede haber dos areas con el mismo nombre
            if (!dal.GetWhere<Area>(x => x.Name == area.Name).Any())
            {
                dal.Insert<Area>(area);
                dal.Commit();
            }
            else throw new ServiceException("Area with name " + area.Name + " already exists.");
        }

	    public void AddUser(User user)
        {
            if (dal.GetById<User>(user.Id) == null)
            {
                dal.Insert<User>(user);
                dal.Commit();
            }
            else throw new ServiceException("User with name " + user.Name + " already exists.");

        }

        public void AddPaper(Paper paper)
        {
            if (!dal.GetWhere<Paper>(x => x.Title == paper.Title).Any())
            {
                dal.Insert<Paper>(paper);
                dal.Commit();
            }
            else throw new ServiceException("El paper" + paper.Title+ " ya existe.");

        }

        public Person FindPersonById(string id) {
            Person person = dal.GetById<Person>(id);
            if (person != null)
            {
                return person;
            }
            else {
                throw new ServiceException("La persona con Id " + id + " no existe");
            }
        }
        public Area FindAreaByName(string name) {
            Area area = dal.GetWhere<Area>(x => x.Name == name).First();
            if (area != null)
            {
                return area;
            }
            else {
                throw new ServiceException("El area con nombre " + name + " no exite");
            }
        }

        void Login(string Login, string Password) {

            if (Login == null)
            {
                throw new ServiceException("Introduzca un usuario");
            }
            if (Password == null)
            {
                throw new ServiceException("Introduzca una contraseña");
            }

            //user = dal.GetWhere<User>(x => x.Login).First();
            user = dal.GetWhere<User>(x => x.Login == Login).First();

            if (user == null)
            {
                throw new ServiceException("El usuario no existe");
            }

            if (user.Password != Password)
            {
                user = null;
                throw new ServiceException("La contraseña es incorrecta");
            }
        }

        void Logout() {
            user = null;
        }


        public User UserLogged()
        {
            if(user == null)
            {
                throw new ServiceException("No hay ningun usuario logueado");
            }

            return user;
        }



        
    }
}
