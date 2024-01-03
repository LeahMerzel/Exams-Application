namespace Exams_Application.Data.Enums
{
    public class Enums
    {
        public enum Roles
        {
            admin,
            teacher,
            student
        }
        public enum UserStatusTypes
        {
            LoggedIn,
            LoggedOff,
            Freeze
        }
        public enum UserTypes
        {
            Guest,
            Reader,
            Creator,
            Admin
        }

    }

}
