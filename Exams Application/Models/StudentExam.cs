﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Exams_Application.Models
{
    public class StudentExam: BaseEntity
    {
        public int Grade { get; set; }
        public List<Question>? MistakesInExam { get; set; }
        //where do i do functionality that can show correct answer?
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [ForeignKey("Exam")]
        public int ExamId { get; set; }
    }
}
