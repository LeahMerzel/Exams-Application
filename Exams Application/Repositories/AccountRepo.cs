using Exams_Application.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Exams_Application.Interfaces;

namespace Exams_Application.Repositories
{
    public class AccountRepo : IAccountRepo
    {
        private readonly ExamsDbContext db;

        public AccountRepo(ExamsDbContext dbContext)
        {
            db = dbContext;
        }
        public User CreateAccount(User user)
        {

            db.Users.Add(user);
            db.SaveChanges();
            return user;

        }
        //better bool or int? 
        public bool UpdateAccountDetails(User userUpdated)
        {

            var foundAccount = db.Users.SingleOrDefault(u => u.Id == userUpdated.Id);
            if (foundAccount != null)
            {
                foundAccount.UserName = userUpdated.UserName;
                foundAccount.Password = userUpdated.Password;
                foundAccount.PhoneNum = userUpdated.PhoneNum;
                foundAccount.IsAdmin = userUpdated.IsAdmin;
                foundAccount.FullName = userUpdated.FullName;

                db.SaveChanges();
                return true;
            }
            return false;

        }
        //better bool or int? 
        public bool DeleteAccount(int userId)
        {

            var foundAccount = db.Users.SingleOrDefault(u => u.Id == userId);
            if (foundAccount != null)
            {
                db.Users.Remove(foundAccount);
                db.SaveChanges();
                return true;
            }
            return false;

        }
        //should login be with Cookies too?
        public User? Login(string username, string password)
        {

            var user = db.Users.SingleOrDefault(u => u.UserName == username && u.Password == password);
            if (user != null)
            {
                return user;
            }
            return null;

        }

        //wait to learn Cookie logout
        public bool Logout(int userId)
        {

            return false;
        }

    }
}
