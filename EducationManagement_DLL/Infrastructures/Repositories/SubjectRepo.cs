 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface ISubject : IGenericRepository<Subject> { }


    public class SubjectRepo : GenericRepository<Subject>, ISubject
    {
        public SubjectRepo(SchoolCOntext context) : base(context) { }
    }
}
