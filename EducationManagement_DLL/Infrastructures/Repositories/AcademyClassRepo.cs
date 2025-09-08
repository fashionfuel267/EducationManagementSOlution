
using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IAcademyClass : IGenericRepository<AcademyClass> { }


    public class AcademyClassRepo : GenericRepository<AcademyClass>, IAcademyClass
    {
        public AcademyClassRepo(SchoolCOntext context) : base(context) { }
    }
    
}
