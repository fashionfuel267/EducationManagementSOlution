 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface ISchool : IGenericRepository<School> { }


    public class SchoolRepo : GenericRepository<School>, ISchool
    {
        public SchoolRepo(SchoolCOntext context) : base(context) { }
    }
    
}
