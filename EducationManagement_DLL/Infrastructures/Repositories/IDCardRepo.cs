
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
    public interface IIDCard : IGenericRepository<IDCardRepo> { }
    public class IDCardRepo : GenericRepository<IDCardRepo>, IIDCard
    {
        public IDCardRepo(SchoolContext context) : base(context) { }
    }
}
