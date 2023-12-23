namespace Exams_Application.Data.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
