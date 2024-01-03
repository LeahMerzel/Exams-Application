using static Exams_Application.Data.Enums.Enums;

namespace Exams_Application.Core.DTOs
{
    public class UserReturnDto : UserRegisterDTO
    {
        public Guid Id { get; set; }
        public UserTypes UserType { get; set; }
        public UserStatusTypes UserStatusType { get; set; }
        public string? HobbiesList { get; set; }
        public string? FavCategoriesList { get; set; }
        public string? AboutMe { get; set; }
    }
}
