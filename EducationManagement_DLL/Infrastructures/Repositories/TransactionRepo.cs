
using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Models.AccountsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface ITransaction : IGenericRepository<TransactionMaster> { }


    public class TransactionRepo : GenericRepository<TransactionMaster>, ITransaction
    {
        public TransactionRepo(SchoolContext context) : base(context) { }
    }
}
