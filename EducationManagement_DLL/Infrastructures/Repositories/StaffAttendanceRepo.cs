 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IStaffAttendance : IGenericRepository<StaffAttendance> { }


    public class StaffAttendanceRepo : GenericRepository<StaffAttendance>, IStaffAttendance
    {
        public StaffAttendanceRepo(SchoolCOntext context) : base(context) { }
    }
}
