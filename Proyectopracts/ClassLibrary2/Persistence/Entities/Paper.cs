using System;
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
        public Evaluation Evaluation { get; set; }
        public User Responsible { get; set; }
        public Area BelongingArea { get; set; }
        public Area EvaluationPendingArea { get; set; }
        public Area PublicationPendingArea { get; set; }

        public ICollection<Person> CoAuthors { get; set; }


    }
}
