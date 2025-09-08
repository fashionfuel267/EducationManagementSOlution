 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface ISchoolClass : IGenericRepository<SchoolClass> { }


    public class SchoolClassRepo : GenericRepository<SchoolClass>, ISchoolClass
    {
        public SchoolClassRepo(SchoolCOntext context) : base(context) { }
    }
}
