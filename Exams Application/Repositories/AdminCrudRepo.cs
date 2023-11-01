using Exams_Application.Models;
using System.ComponentModel.DataAnnotations;

namespace Exams_Application.Repositories
{

    public class AdminCrudRepo : IAdminCrudRepo
    {
        public User? GetAccountById(int id)
        {
            using(ExamsDbContext db = new ExamsDbContext())
            {
                var targetUser = db.Users.SingleOrDefault(u => u.Id == id);
                return targetUser;
            }
        }
        public List<User> GetAllAcounts()
        {
            using (ExamsDbContext db = new ExamsDbContext())
            {
                List<User> users = db.Users.ToList();
                return users;
            }
        }
        public bool DeleteAccount(int userId)
        {
            using (ExamsDbContext db = new ExamsDbContext())
            {
                var userToDelete = db.Users.SingleOrDefault(u => u.Id == userId);
                if (userToDelete != null)
                {
                    db.Users.Remove(userToDelete);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        //is this good or do i add each property? if so, how to send object User?
        public User CreateAccount(User user)
        {
            using (ExamsDbContext db = new ExamsDbContext())
            {
                db.Users.Add(user);
                db.SaveChanges();
                return user;
            }
        }

    }
}
