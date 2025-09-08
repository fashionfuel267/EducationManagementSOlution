 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface ISchoolClassSubject : IGenericRepository<SchoolClassSubject> { }


    public class SchoolClassSubjectRepo : GenericRepository<SchoolClassSubject>, ISchoolClassSubject
    {
        public SchoolClassSubjectRepo(SchoolCOntext context) : base(context) { }
    }
}
