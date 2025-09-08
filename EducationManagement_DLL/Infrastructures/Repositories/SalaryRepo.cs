 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface ISalary : IGenericRepository<Salary> { }


    public class SalaryRepo : GenericRepository<Salary>, ISalary
    {
        public SalaryRepo(SchoolCOntext context) : base(context) { }
    }
   
}
