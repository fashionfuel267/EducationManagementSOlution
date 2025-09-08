 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface ILeaveRequest : IGenericRepository<LeaveRequest> { }
    public class LeaveRequestRepo : GenericRepository<LeaveRequest>, ILeaveRequest
    {
        public LeaveRequestRepo(SchoolCOntext context) : base(context) { }
    }
}
