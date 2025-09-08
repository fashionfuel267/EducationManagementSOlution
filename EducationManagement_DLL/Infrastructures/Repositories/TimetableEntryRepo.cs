 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface ITimetableEntry : IGenericRepository<TimetableEntry> { }


    public class TimetableEntryRepo : GenericRepository<TimetableEntry>, ITimetableEntry
    {
        public TimetableEntryRepo(SchoolCOntext context) : base(context) { }
    }
}
