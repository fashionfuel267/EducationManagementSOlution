
using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IClassSubject : IGenericRepository<ClassSubjecTeacherIns> { }


    public class ClassSubjectRepo : GenericRepository<ClassSubjecTeacherIns>, IClassSubject
    {
        public ClassSubjectRepo(SchoolCOntext context) : base(context) { }
    }
}
