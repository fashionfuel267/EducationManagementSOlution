 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface INotice : IGenericRepository<Notice> { }
    public class NoticeRepo : GenericRepository<Notice>, INotice
    {
        public NoticeRepo(SchoolCOntext context) : base(context) { }
    }
}
