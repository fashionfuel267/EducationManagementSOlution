 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IStudent : IGenericRepository<Student> { }


    public class StudentRepo : GenericRepository<Student>, IStudent
    {
        public StudentRepo(SchoolCOntext context) : base(context) { }
    }
}
