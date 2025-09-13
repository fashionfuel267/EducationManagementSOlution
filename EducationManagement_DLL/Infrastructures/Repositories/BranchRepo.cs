 
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Infrastructures.Base;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EducationManagement_DLL.Context;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IBranch : IGenericRepository<InsBranch> { }


    public class BranchRepo : GenericRepository<InsBranch>, IBranch
    {
        public BranchRepo(SchoolContext context) : base(context) { }
    }
}
