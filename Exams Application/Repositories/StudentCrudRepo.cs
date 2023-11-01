using Exams_Application.Models;

namespace Exams_Application.Repositories
{
    public class StudentCrudRepo : IStudentCrudRepo
    {
        public Exam? LoginToExam(int examId)
        {
            using ExamsDbContext db = new ExamsDbContext();
            {
                var exam = db.Exams.SingleOrDefault(e => e.ExamId == examId);
                if (exam != null)
                {
                    return exam;
                }
                return null;
            }
        }
        public string SubmitExam(Exam exam)
        {
            using ExamsDbContext db = new ExamsDbContext();
            {
                if (exam != null)
                {
                    var teacherToRecieveExam = db.Teachers.SingleOrDefault(t => t.Id == exam.TeacherId);
                    if (teacherToRecieveExam != null)
                    {
                        exam.StudentId = exam.ExamId + exam.StudentId;
                        teacherToRecieveExam.SubmitedExams.Add(exam);
                        db.SaveChanges();
                        return "student "+ exam.StudentId +" submitted exam successfuly to teacher" + teacherToRecieveExam;
                    }
                    return "student " + exam.StudentId + " failed to submit exam";
                }
                return "no exam to submit";
            }
        }
        public List<Exam>? GetAllExamsTaken(int studentId)
        {
            using ExamsDbContext db = new ExamsDbContext();
            {
                if (studentId != 0)
                {
                    var student = db.Students.SingleOrDefault(s => s.Id == studentId);
                    if (student != null)
                    {
                        if(student.AllExamsTaken != null)
                        {
                            return student.AllExamsTaken.ToList();
                        }
                        return null;
                    }
                }
                return null;
            }
        }

    }
}
