 
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface ISection : IGenericRepository<Section> { }


    public class SectionRepo : GenericRepository<Section>, ISection
    {
        public SectionRepo(SchoolCOntext context) : base(context) { }
    }
}
