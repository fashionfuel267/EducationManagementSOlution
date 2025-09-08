 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IFee : IGenericRepository<Fee> { }


    public class FeeRepo : GenericRepository<Fee>, IFee
    {
        public FeeRepo(SchoolCOntext context) : base(context) { }
    }
}
