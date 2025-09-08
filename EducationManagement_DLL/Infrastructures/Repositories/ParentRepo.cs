 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IParent : IGenericRepository<Parent> { }

    public class ParentRepo : GenericRepository<Parent>, IParent
    {
        public ParentRepo(SchoolCOntext context) : base(context) { }
    }
}
