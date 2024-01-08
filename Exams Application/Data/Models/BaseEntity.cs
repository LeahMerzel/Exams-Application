using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Exams_Application.Data.Models
{
    public class BaseEntity
    {
        [Key]
        [JsonIgnore]
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
