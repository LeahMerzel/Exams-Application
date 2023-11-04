using Exams_Application.Interfaces;
using Exams_Application.Models;
using System.Diagnostics;

namespace Exams_Application.Repositories
{
    public class TeacherCrudRepo : ITeacherCrudRepo
    {
        public Exam? CreateExam(Exam exam)
        {
            using ExamsDbContext db = new ExamsDbContext();
            {
                var teacherId = exam.TeacherId;
                var teacherFound = db.Teachers.SingleOrDefault(t => t.Id == teacherId);
                if (teacherFound != null)
                {
                    db.Exams.Add(exam);
                    db.SaveChanges();
                    return exam;
                }

                return null;
            }
        }
        //will the second "list" override the first?
        public List<Exam>? GetAllExams(int teacherId)
        {
            using ExamsDbContext db = new ExamsDbContext();
            {
                var teacher = db.Teachers.SingleOrDefault(t => t.Id == teacherId);
                if (teacher != null)
                {
                    var list = db.Exams.ToList();
                    foreach (Exam exam in list)
                    {
                        if (exam.TeacherId == teacherId)
                        {
                            list.Add(exam);
                            return list;
                        }
                    }
                }
                return null;
            }
        }
        public Exam? UpdateExam(Exam exam)
        {
            using ExamsDbContext db = new ExamsDbContext();
            {
                var examToUpdate = db.Exams.SingleOrDefault(e => e.ExamId == exam.ExamId);
                if (examToUpdate != null && examToUpdate.ExamBegganAt != examToUpdate.ExamDateTime)
                {
                    exam.ExamName = examToUpdate.ExamName;
                    exam.ExamQuestions = examToUpdate.ExamQuestions;
                    exam.ExamDescription = examToUpdate.ExamDescription;
                    exam.ExamQuestions = examToUpdate.ExamQuestions.ToList();
                    exam.StudentId = examToUpdate.StudentId;
                    exam.Grade = examToUpdate.Grade;

                    db.SaveChanges();
                    return examToUpdate;
                }
                return null;
            }
        }
        public bool DeleteExam(int examId)
        {
            using ExamsDbContext db = new ExamsDbContext();
            {
                var exam = db.Exams.SingleOrDefault(e => e.ExamId == examId);
                if (exam != null)
                {
                    db.Exams.Remove(exam);
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        public Question? CreateQuestion(Question question)
        {
            using ExamsDbContext db = new ExamsDbContext();
            {
                if (question != null)
                {
                    db.Questions.Add(question);
                    db.SaveChanges();
                    return question;
                }
                return null;
            }
        }
        public List<Question>? GetAllQuestionsOfExam(int examId)
        {
            var list = new List<Question>();
            using (var db = new ExamsDbContext())
            {
                var examWanted = db.Exams.SingleOrDefault(e => e.ExamId == examId);
                if (examWanted != null)
                {
                    list = examWanted.ExamQuestions.ToList();
                    return list;
                }
                return null;
            }
        }
        public Question UpdateQuestion(Question questionToUptade)
        {
            using (var db = new ExamsDbContext())
            {
                var question = db.Questions.SingleOrDefault(q => q.QuestionNumber == questionToUptade.QuestionNumber);
                if (question != null)
                {
                    question.QuestionName = questionToUptade.QuestionName;
                    question.QuestionDescription = questionToUptade.QuestionDescription;
                    question.QuestionScoring = questionToUptade.QuestionScoring;
                    db.SaveChanges();
                    return question;
                }
                return questionToUptade;
            }
        }
        public bool DeleteQuestion(int questionId)
        {
            using var db = new ExamsDbContext();
            {
                var question = db.Questions.SingleOrDefault(q => q.QuestionNumber == questionId);
                if (question != null)
                {
                    db.Questions.Remove(question);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public int GradeExamPerStudent(Exam studentExam)
        {
            int grade = 0;//to change according to ui?
            using (var db = new ExamsDbContext())//how to use without סוגריים and why
            {
                var student = db.Students.SingleOrDefault(s => s.Id == studentExam.StudentId);
                if (student != null)
                {
                    studentExam.Grade = grade;
                    student.AllExamsTaken.Add(studentExam);//does this add info of grade to student Db?
                    db.SaveChanges();
                }
            };
            return grade;
        }
       /* public double GetExamGradeStatistic()
        {
            
        }*/
    }
}
