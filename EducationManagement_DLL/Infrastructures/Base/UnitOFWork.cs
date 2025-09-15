

using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Repositories;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;

namespace EducationManagement_DLL.Infrastructures.Base
{
    public class UnitOFWork : IUnitOfWork
    {
        public SchoolContext context;
        public UnitOFWork(SchoolContext context)
        {
            this.context = context;
        }


        private IAcademyClass academyClass;
      //  public IAcademyClass AcademyClassRepo => academyClass ??= new AcademyClassRepo(context);

        public IAcademyClass AcademyClassRepo
        {
            get
            {
                if(academyClass==null)
                {
                    academyClass = new AcademyClassRepo(context);
                }
                return academyClass;
            }
        }
        private IAdmitCard admitCard;
        public IAdmitCard AdmitCardRepo => admitCard ??= new AdmitCardRepo(context);

        private IIDCard idCard;
        public IIDCard IDCardRepo => idCard ??= new IDCardRepo(context);
        private IAttendance attendance;
        public IAttendance AttendanceRepo => attendance ??= new AttendanceRepo(context);
        private IBranch branch;
        public IBranch BranchRepo => branch ??= new BranchRepo(context);
        private IClassSubject classSubject; 
        public IClassSubject ClassSubjectRepo => classSubject ??= new ClassSubjectRepo(context);
        private IEvent eventEntity;
        public IEvent EventRepo => eventEntity ??= new EventRepo(context);
        private IEventImage eventImage;
        public IEventImage EventImageRepo => eventImage ??= new EventImageRepo(context);
       
        private IExam exam;
        public IExam ExamRepo => exam ??= new ExamRepo(context);
        private IExamRoutine examRoutine;
        public IExamRoutine ExamRoutineRepo => examRoutine ??= new ExamRoutineRepo(context);
        private IFeedback feedback;
        public IFeedback FeedbackRepo => feedback ??= new FeedbackRepo(context);
        private IFeePayment feePayment;
        public IFeePayment FeePaymentRepo => feePayment ??= new FeePaymentRepo(context);
        private IFee fee;
        public IFee FeeRepo => fee ??= new FeeRepo(context);
        private IFeeStructure feeStructure;
        public IFeeStructure FeeStructureRepo => feeStructure ??= new FeeStructureRepo(context);
        private IHomework homework;
        public IHomework HomeworkRepo => homework ??= new HomeworkRepo(context);
        private IHomeworkSubmission homeworkSubmission;
        public IHomeworkSubmission HomeworkSubmissionRepo => homeworkSubmission ??= new HomeworkSubmissionRepo(context);
        private IUser userRepo;
        public IUser UserRepo => userRepo ??= new UserRepo(context);
        

        private ILeaveRequest leaveRequest;
        public ILeaveRequest LeaveRequestRepo => leaveRequest ??= new LeaveRequestRepo(context);

        private IMessage message;
        public IMessage MessageRepo => message ??= new MessageRepo(context);

        private INotice notice;
        public INotice NoticeRepo => notice ??= new NoticeRepo(context);

        private INotification notification;
        public INotification NotificationRepo => notification ??= new NotificationRepo(context);

        private IParent parent;
        public IParent ParentRepo => parent ??= new ParentRepo(context);

        private IResult result;
        public IResult ResultRepo => result ??= new ResultRepo(context);

        private ISalary salary;
        public ISalary SalaryRepo => salary ??= new SalaryRepo(context);

        private ISchoolClass schoolClass;
        public ISchoolClass SchoolClassRepo => schoolClass ??= new SchoolClassRepo(context);

        private ISchoolClassSubject schoolClassSubject;
        public ISchoolClassSubject SchoolClassSubjectRepo => schoolClassSubject ??= new SchoolClassSubjectRepo(context);

        private ISchool school;
        public ISchool SchoolRepo => school ??= new SchoolRepo(context);

        private ISection section;
        public ISection SectionRepo => section ??= new SectionRepo(context);

        private IStaffAttendance staffAttendance;
        public IStaffAttendance StaffAttendanceRepo => staffAttendance ??= new StaffAttendanceRepo(context);

        private IStaff staff;
        public IStaff StaffRepo => staff ??= new StaffRepo(context);

        private IStudent student;
        public IStudent StudentRepo => student ??= new StudentRepo(context);

        private ISubject subject;
        public ISubject SubjectRepo => subject ??= new SubjectRepo(context);

        private ISubstituteAssignment substituteAssignment;
        public ISubstituteAssignment SubstituteAssignmentRepo => substituteAssignment ??= new SubstituteAssignmentRepo(context);

        private ITeacher teacher;
        public ITeacher TeacherRepo => teacher ??= new TeacherRepo(context);

        private ITimetableEntry timetableEntry;
        public ITimetableEntry TimetableEntryRepo => timetableEntry ??= new TimetableEntryRepo(context);

        private ITransaction transaction;
        public ITransaction TransactionRepo => transaction ??= new TransactionRepo(context);
        private IUser user;

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
                    modelMessage.Message = $"Operation Successfull";
                    modelMessage.IsSuccess = true;
                }
                else
                {
                    modelMessage.Message = $"Operation Failled";
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
