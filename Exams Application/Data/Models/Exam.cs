﻿using Exams_Application.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Timers;

public class Exam : BaseEntity
{
    private DateTime examStartTime; // Declare the examStartTime field

    [ForeignKey("Teacher")]
    public Guid TeacherOwnsExamId { get; }
    public string? ExamDescription { get; set; }
    public DateTime ExamDateTime { get; set; }
    public System.Timers.Timer? ExamTimer { get; set; }
    public bool WasExamLoggedInToByStudent { get; set; }
    public bool IsOrderQuestionsRandom { get; set; }
    public List<Question>? ExamQuestions { get; set; }
    public int ExamGrade { get; set; }
    public float ExamGradeAvg { get; set; }

    public Exam()
    {
        ExamQuestions = new List<Question>();
        ExamGrade = 0;
        WasExamLoggedInToByStudent = false;

        // Initialize the timer if needed
        ExamTimer = new System.Timers.Timer(1000);
        ExamTimer.Elapsed += OnTimedEvent;
        ExamTimer.AutoReset = true;
        ExamTimer.Enabled = false; // Set to true when the exam starts
    }
    public void StartExamTimer(int durationInMinutes)
    {
        // Set the duration of the timer based on the teacher's decision
        ExamTimer.Interval = durationInMinutes * 60 * 1000; // Convert minutes to milliseconds
        ExamTimer.Enabled = true; // Start the timer
    }
    private void OnTimedEvent(object sender, ElapsedEventArgs e)
    {
        // This method will be called every time the timer ticks

        // Calculate remaining time in seconds
        var remainingTimeInSeconds = (int)((ExamTimer.Interval - (DateTime.Now - examStartTime).TotalMilliseconds) / 1000);

        // You can use remainingTimeInSeconds as needed, for example, update UI or perform actions when time is up
        Console.WriteLine($"Remaining Time: {remainingTimeInSeconds} seconds");

        // Example: If the remaining time is zero, stop the timer
        if (remainingTimeInSeconds <= 0)
        {
            ExamTimer.Enabled = false;

            // Perform actions when the time is up
            Console.WriteLine("Exam Time is Up!");
        }
    }
}
