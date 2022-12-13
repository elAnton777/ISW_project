using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Magazine.Entities;


namespace Magazine.Services
{
    public interface IMagazineService
    {
        void RemoveAllData();
        void Commit();

        // Necesario para la inicialización de la BD
        void DBInitialization();
        void AddPerson(Person p);
        void AddMagazine(Magazine.Entities.Magazine m);
        void AddArea(Area a);

        // A partir de aquí cread los vuestros
        // void AddUser(User u);

        void Login(string Login, string Password);
        void Register(User user);
        void Logout();
        User UserLogged();
        void EvaluatePaper(bool accepted, string comments, DateTime date, int paperId);
        bool isPublicationPending(int paperId);
        bool isAccepted(int paperId);
        IEnumerable<Paper> GetAllPapers(string id);

        }
    }
