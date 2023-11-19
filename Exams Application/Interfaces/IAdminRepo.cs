using Exams_Application.Models;

namespace Exams_Application.Repositories
{
    public interface IAdminRepo
    {
        User? GetAccountById(int id);
        User CreateAccount(User user);
        bool DeleteAccount(int userId);
        List<User> GetAllAcounts();
    }
}