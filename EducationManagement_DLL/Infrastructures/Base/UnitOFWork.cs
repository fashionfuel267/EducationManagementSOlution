

using EducationManagement_DLL.Context;
using EducationManagement_DLL.Utility;

namespace EducationManagement_DLL.Infrastructures.Base
{
    public class UnitOFWork : IUnitOfWork
    {
        public SchoolCOntext context;
        public UnitOFWork(SchoolCOntext context)
        {
            this.context = context;
        }

     





        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
        }

        public ModelMessage Save()
        {
            ModelMessage modelMessage = new ModelMessage();
            try
            {
                if (context.SaveChanges() > 0)
                {
                    modelMessage.Message = $"Successfully Created";
                    modelMessage.IsSuccess = true;
                }
                else
                {
                    modelMessage.Message = $"Failled to create";
                    modelMessage.IsSuccess = false;
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    modelMessage.Message = ex.InnerException.Message;
                    modelMessage.IsSuccess = false;
                }
                else
                {
                    modelMessage.Message = ex.Message;
                    modelMessage.IsSuccess = false;
                }
            }
            return modelMessage;
        }
    }
}
