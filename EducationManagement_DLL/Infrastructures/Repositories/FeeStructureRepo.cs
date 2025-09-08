 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IFeeStructure : IGenericRepository<FeeStructure> { }
    public class FeeStructureRepo : GenericRepository<FeeStructure>, IFeeStructure
    {
        public FeeStructureRepo(SchoolCOntext context) : base(context) { }
    }
}
