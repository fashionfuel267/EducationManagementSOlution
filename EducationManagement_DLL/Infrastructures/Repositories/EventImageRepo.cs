 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IEventImage : IGenericRepository<EventImage> { }


    public class EventImageRepo : GenericRepository<EventImage>, IEventImage
    {
        public EventImageRepo(SchoolCOntext context) : base(context) { }
    }
}
