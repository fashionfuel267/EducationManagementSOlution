 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IFeePayment : IGenericRepository<FeePayment> { }


    public class FeePaymentRepo : GenericRepository<FeePayment>, IFeePayment
    {
        public FeePaymentRepo(SchoolCOntext context) : base(context) { }
    }
}
