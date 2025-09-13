
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
    public interface IParent : IGenericRepository<ParentRepo> { }

    public class ParentRepo : GenericRepository<ParentRepo>, IParent
    {
        public ParentRepo(SchoolContext context) : base(context) { }
    }
}
