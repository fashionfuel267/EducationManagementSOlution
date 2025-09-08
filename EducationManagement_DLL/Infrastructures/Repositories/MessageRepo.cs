 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IMessage : IGenericRepository<Message> { }
    public class MessageRepo : GenericRepository<Message>, IMessage
    {
        public MessageRepo(SchoolCOntext context) : base(context) { }
    }
}
