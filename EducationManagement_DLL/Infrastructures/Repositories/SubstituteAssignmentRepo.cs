
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
    public interface ISubstituteAssignment : IGenericRepository<SubstituteAssignmentRepo> { }


    public class SubstituteAssignmentRepo : GenericRepository<SubstituteAssignmentRepo>, ISubstituteAssignment
    {
        public SubstituteAssignmentRepo(SchoolContext context) : base(context) { }
    }
}
