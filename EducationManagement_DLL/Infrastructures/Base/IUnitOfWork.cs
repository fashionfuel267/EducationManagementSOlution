



using EducationManagement_DLL.Infrastructures.Repositories;
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
        public IUser UserRepo { get; }
        public IAcademyClass AcademyClassRepo { get; }
        public IAdmitCard AdmitCardRepo { get; }
        public IAttendance AttendanceRepo { get; }
        public IBranch BranchRepo { get; }
        public IClassSubject ClassSubjectRepo { get; }
        public IEvent EventRepo { get; }
        //public IClassSubject EventSubjectRepo { get; }
        public IEventImage EventImageRepo { get; }
        //public IEventImage EventVideoRepo { get; }
        public IExam ExamRepo { get; }
        public IExamRoutine ExamRoutineRepo { get; }
        public IFeedback FeedbackRepo { get; }
        public IFeePayment FeePaymentRepo { get; }
        public IFee FeeRepo { get; }
        public IFeeStructure FeeStructureRepo { get; }
        public IHomework HomeworkRepo { get; }
        public IHomeworkSubmission HomeworkSubmissionRepo { get; }
        public IIDCard IDCardRepo { get; }  
        public ILeaveRequest LeaveRequestRepo { get; }
        public IMessage MessageRepo { get; }
        public INotice NoticeRepo { get; }
        public INotification NotificationRepo { get; }
        public IParent ParentRepo { get; }
        public IResult ResultRepo { get; }
        public ISalary SalaryRepo { get; }  
        public ISchoolClass SchoolClassRepo { get; }
        public ISchoolClassSubject SchoolClassSubjectRepo { get; }
        public ISchool SchoolRepo { get; }
        public ISection SectionRepo { get; }
        public IStaffAttendance StaffAttendanceRepo { get; }
        public IStaff StaffRepo { get; }
        public IStudent StudentRepo { get; }
        public ISubject SubjectRepo { get; }
        public ISubstituteAssignment SubstituteAssignmentRepo { get; }
        public ITeacher TeacherRepo { get; }
        public ITimetableEntry TimetableEntryRepo { get; }
        public ITransaction TransactionRepo { get; }


        ModelMessage Save();
    }
}
