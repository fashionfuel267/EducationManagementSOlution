
using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface ISchoolClass : IGenericRepository<SchoolClassRepo> { }


    public class SchoolClassRepo : GenericRepository<SchoolClassRepo>, ISchoolClass
    {
        public SchoolClassRepo(SchoolContext context) : base(context) { }
    }
}
