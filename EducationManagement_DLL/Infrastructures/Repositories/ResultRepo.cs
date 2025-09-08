 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IResult : IGenericRepository<Result> { }

    public class ResultRepo : GenericRepository<Result>, IResult
    {
        public ResultRepo(SchoolCOntext context) : base(context) { }
    }
}
