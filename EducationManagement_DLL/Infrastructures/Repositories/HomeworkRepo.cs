 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IHomework : IGenericRepository<Homework> { }
    public class HomeworkRepo : GenericRepository<Homework>, IHomework
    {
        public HomeworkRepo(SchoolCOntext context) : base(context) { }
    }
}
