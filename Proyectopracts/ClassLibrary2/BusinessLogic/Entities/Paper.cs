using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Entities
{
    public partial class Paper
    {
        public Paper()
        {
            CoAuthors = new List<Person>();
        }
        public Paper( String Title, DateTime UploadDate, User Responsible, Evaluation Evaluation,
                     Area BelongingArea, Area EvaluationPendingArea, Area PublicationPendingArea)
        {
            //this.Id = Id;
            this.Title = Title;
            this.UploadDate = UploadDate;
            this.Responsible = Responsible;
            this.Evaluation = Evaluation;
            this.BelongingArea = BelongingArea;
            this.EvaluationPendingArea = EvaluationPendingArea;
            this.PublicationPendingArea = PublicationPendingArea;

            this.CoAuthors = new List<Person>();
        }
    }
}
