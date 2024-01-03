using Exams_Application.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

public class Exam : BaseEntity
{
    [ForeignKey("Teacher")]
    public Guid TeacherOwnsExamId { get; }
    public string? ExamDescription { get; set; }
    public DateTime ExamDateTime { get; set; }
    public bool IsOrderQuestionsRandom { get; set; }
    public List<Question>? ExamQuestions { get; set; }
    public int ExamGrade { get; set; }
    public float ExamGradeAvg { get; set; }

    public Exam()
    {
        ExamQuestions = new List<Question>();
        ExamGrade = 0;
    }
}
