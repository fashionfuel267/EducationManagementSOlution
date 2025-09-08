 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IStaff : IGenericRepository<Staff> { }


    public class StaffRepo : GenericRepository<Staff>, IStaff
    {
        public StaffRepo(SchoolCOntext context) : base(context) { }
    }
}
