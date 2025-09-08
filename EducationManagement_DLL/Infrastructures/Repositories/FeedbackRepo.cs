 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IFeedback : IGenericRepository<Feedback> { }


    public class FeedbackRepo : GenericRepository<Feedback>, IFeedback
    {
        public FeedbackRepo(SchoolCOntext context) : base(context) { }
    }
}
