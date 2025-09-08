 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IIDCard : IGenericRepository<IDCard> { }
    public class IDCardRepo : GenericRepository<IDCard>, IIDCard
    {
        public IDCardRepo(SchoolCOntext context) : base(context) { }
    }
}
