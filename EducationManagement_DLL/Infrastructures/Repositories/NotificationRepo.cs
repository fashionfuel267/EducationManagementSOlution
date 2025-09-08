 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface INotification : IGenericRepository<Notification> { }

    public class NotificationRepo : GenericRepository<Notification>, INotification
    {
        public NotificationRepo(SchoolCOntext context) : base(context) { }
    }
}
