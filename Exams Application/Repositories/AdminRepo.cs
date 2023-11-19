using Exams_Application.Interfaces;
using Exams_Application.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Exams_Application.Repositories
{

    public class AdminRepo : IAdminRepo
    {
        private readonly ExamsDbContext db;
        public AdminRepo(ExamsDbContext dbContext)
        {
            db = dbContext;
        }
        public User? GetAccountById(int id)
        {
            var targetUser = db.Users.SingleOrDefault(u => u.Id == id);
            return targetUser;
        }
        public List<User> GetAllAcounts()
        {
            List<User> users = db.Users.ToList();
            return users;
        }
        public bool DeleteAccount(int userId)
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

        //is this good or do i add each property? if so, how to send object User?
        public User CreateAccount(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return user;
        }

    }
}
