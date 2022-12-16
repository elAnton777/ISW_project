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
    public class MagazineService : IMagazineService
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
            if (person.Id == "") throw new ServiceException("El campo id es obligatorio");
            if (person.Name == "") throw new ServiceException("El campo nombre es obligatorio");
            if (person.Surname == "") throw new ServiceException("El campo apellido es obligatorio");

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
            else throw new ServiceException("El paper " + paper.Title + " ya existe.");

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
            IEnumerable<Area> area = dal.GetWhere<Area>(x => x.Name == name);


            if (area.Count() != 0)
            {
                return area.First();
            }
            else {
                throw new ServiceException("El area con nombre " + name + " no existe");
            }
        }


        public void Register(User user) {
            Console.WriteLine("He llegado");
            if (user.Name == "") throw new ServiceException("Introduzca un nombre");
            if (user.Surname == "") throw new ServiceException("Introduzca un apellido");
            if (user.Login == "") throw new ServiceException("Introduzca un usuario");
            if (user.AreasOfInterest == "") throw new ServiceException("Introduzca sus areas de interés");
            if (user.Email == "") throw new ServiceException("Introduzca un correo electrónico");
            if (user.Password == "") throw new ServiceException("Introduzca una contraseña");

            if (dal.GetWhere<User>(x => x.Login == user.Login).Count() != 0) {
                throw new ServiceException("El usuario ya existe");
            }
            if (dal.GetWhere<User>(x => x.Email == user.Email).Count() != 0)
            {
                throw new ServiceException("El usuario ya existe");
            }
            if (dal.GetById<User>(user.Id) == null)
            {
                dal.Insert<User>(user);
                dal.Commit();
            }
            else
            {
                throw new ServiceException("El usuario ya existe");
            }
        }



        public void Login(string Login, string Password) {

            if (Login == "")
            {
                throw new ServiceException("Introduzca un usuario");
            }
            if (Password == "")
            {
                throw new ServiceException("Introduzca una contraseña");
            }

            //user = dal.GetWhere<User>(x => x.Login).First();
            try
            {
                user = dal.GetWhere<User>(x => x.Login == Login).First();
            }
            catch (Exception)
            {
                //?
            }



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



        public void Logout() {
            user = null;
        }

        public User UserLogged()
        {
            if (user == null)
            {
                throw new ServiceException("No hay ningun usuario logueado");
            }

            return user;
        }


        Entities.Magazine GetMagazine() {
            Entities.Magazine magazine = dal.GetAll<Entities.Magazine>().First();

            if (magazine != null)
            {
                return magazine;
            }
            else {
                throw new ServiceException("No se ha encontrado una única revista");
            }
        }

        public IEnumerable<Entities.Magazine> GetAllMagazines() {
            IEnumerable<Entities.Magazine> magazines = dal.GetAll<Entities.Magazine>();

            if (magazines.Count() > 0) {
                return magazines;
            }
            else
            {
                throw new ServiceException("No se ha encontrado ninguna revista");
            }
        }

        IEnumerable<Paper> GetEvaluationPendingPapers(Area area)
        {
            if (area.EvaluationPending.Count > 0) {
                return area.EvaluationPending;
            }
            else
            {
                throw new ServiceException("No hay articulos pendientes de evaluación");
            }
        }

        public IEnumerable<Paper> GetPublicationPendingPapers(Area area)
        {
            if (area.PublicationPending.Count > 0)
            {
                return area.PublicationPending;
            }
            else
            {
                throw new ServiceException("No hay articulos pendientes de publicación");
            }
        }

        public void AddPendingEvaluatePaperToArea(Area area, Paper paper) {
            area.EvaluationPending.Add(paper);
            dal.Commit();
        }

        public void setPublicationPending(Area area, Paper paper) {

            area.EvaluationPending.Remove(paper);
            area.PublicationPending.Add(paper);

            dal.Commit();
        }

        public void RemoveFromEvaluationPending(Area area, Paper paper)
        {
            area.EvaluationPending.Remove(paper);
            dal.Commit();
        }

        public void EvaluatePaper(bool accepted, string comments, DateTime date, int paperId) {
            if (accepted == null) throw new ServiceException("No se ha aceptado el artículo");
            if (comments == "") throw new ServiceException("No se han aportado comentarios");
            if (date == null) throw new ServiceException("No se ha aportado una fecha");

            Paper paper = dal.GetById<Paper>(paperId);

            if (paper != null) {
                Evaluation evaluation = new Evaluation(accepted, comments, date);
                paper.Evaluation = evaluation;
                dal.Commit();
            }
            else
            {
                throw new ServiceException("El artículo no existe");
            }

        }

        bool isAccepted(int paperId) {
            Paper paper = dal.GetById<Paper>(paperId);
            if (paper != null)
            {
                return paper.Evaluation.Accepted;
            }
            else
            {
                throw new ServiceException("El artículo no existe");
            }
        }

        public Paper getPaperByName(string paperTitle) {
            IEnumerable<Paper> paper = dal.GetWhere<Paper>(x => x.Title == paperTitle);
            if (paper.Count() > 0) {
                return paper.First();
            }
            else {
                throw new ServiceException("El artículo " + paperTitle + " no existe");
            }
        }

        public IEnumerable<Paper> GetAllPapers(string id) {
            IEnumerable<Paper> papers = dal.GetAll<Paper>();

            if (papers.Count() > 0)
            {
                return papers;
            }
            else
            {
                throw new ServiceException("No se han encontrado articulos");
            }
        }

        public IEnumerable<Area> getAllAreas() {
            IEnumerable<Area> areas = dal.GetAll<Area>();

            if (areas.Count() > 0)
            {
                return areas;
            }
            else
            {
                throw new ServiceException("No se han encontrado areas");
            }
        }

        public Issue getIssue(Entities.Magazine magazine) {
            if (this.user == magazine.ChiefEditor) {
                if (magazine.CurrentIssue != null)
                {
                    return magazine.CurrentIssue;
                }
                else 
                {
                    int issueNumber = magazine.Issues.Count + 1;
                    Issue issue = new Issue(issueNumber, magazine);
                    magazine.CurrentIssue= issue;
                    dal.Commit();
                    return issue;
                }
            }
            else
            {
                throw new ServiceException("El usuario no es Chief Editor");
            }
        }

        public Entities.Magazine FindMagazine(string magazinName)
        {
            IEnumerable<Entities.Magazine> magazine = dal.GetWhere<Entities.Magazine>(x => x.Name == magazinName);
            if (magazine.Count() > 0)
            {
                return magazine.First();
            }
            else
            {
                throw new ServiceException("No existe esa revista");
            }

        }

        void IMagazineService.Logout()
        {
            user = null;
        }

        User IMagazineService.UserLogged()
        {
            return user;    
        }

        void IMagazineService.EvaluatePaper(bool accepted, string comments, DateTime date, int paperId)
        {
            throw new NotImplementedException();
        }

        bool IMagazineService.isPublicationPending(int paperId)
        {
            throw new NotImplementedException();
        }

        bool IMagazineService.isAccepted(int paperId)
        {
            throw new NotImplementedException();
        }


    }
}
