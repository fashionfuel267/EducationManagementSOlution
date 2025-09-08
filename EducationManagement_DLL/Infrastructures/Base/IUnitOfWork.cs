



using EducationManagement_DLL.Utility;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Base
{
    public interface IUnitOfWork:IDisposable
    {


     
        ModelMessage Save();
    }
}
