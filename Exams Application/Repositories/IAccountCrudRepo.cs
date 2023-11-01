using Exams_Application.Models;

namespace Exams_Application.Repositories
{
    public interface IAccountCrudRepo
    {
        User CreateAccount(User user);
        bool DeleteAccount(int userId);
        User? Login(string username, string password);
        bool Logout(int userId);
        bool UpdateAccountDetails(User userUpdated);
    }
}