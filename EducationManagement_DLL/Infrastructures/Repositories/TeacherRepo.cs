 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface ITeacher : IGenericRepository<Teacher> { }


    public class TeacherRepo : GenericRepository<Teacher>, ITeacher
    {
        public TeacherRepo(SchoolCOntext context) : base(context) { }
    }
}
