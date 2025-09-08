 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IUser : IGenericRepository<User> { }


    public class UserRepo : GenericRepository<User>, IUser
    {
        public UserRepo(SchoolCOntext context) : base(context) { }
    }
}
