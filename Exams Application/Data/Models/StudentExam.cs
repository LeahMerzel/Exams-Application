using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Timers;

namespace Exams_Application.Data.Models
{
    public class StudentExam : BaseEntity
    {
        public int Grade { get; set; }
        public List<Question>? QuestionsFailed { get; set; }
        public Guid StudentId { get; set; }
        public int ExamId { get; set; }

        // Timing-related properties
        public DateTime ExamStartTime { get; set; }
        public System.Timers.Timer? ExamTimer { get; set; }
        public bool WasExamLoggedInToByStudent { get; set; }
        public int DurationInMinutes { get; set; } 

        public StudentExam()
        {
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
            ExamStartTime = DateTime.Now;
        }
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            // This method will be called every time the timer ticks

            // Calculate remaining time in seconds
            var remainingTimeInSeconds = (int)((ExamTimer.Interval - (DateTime.Now - ExamStartTime).TotalMilliseconds) / 1000);

            // can use remainingTimeInSeconds as needed, for example, update UI or perform actions when time is up
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
}
