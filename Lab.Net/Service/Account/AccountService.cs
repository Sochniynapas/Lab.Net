using Lab.Net.Data;
using Lab.Net.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab.Net.Service.Account
{
    public class AccountService : IAccountService
    {
        private readonly DataBaseContext db;

        public AccountService(DataBaseContext db)
        {
            this.db = db;
        }



        public string Registration(UserRegisterModel model)
        {

            string password = BCrypt.Net.BCrypt.HashPassword(model.Password);
            var user = new UserRegisterModel
            {
                FullName = model.FullName,
                Password = password,
                Email = model.Email,
                Address = model.Address,
                BirthDate = model.BirthDate,
                Gender = model.Gender,
                PhoneNumber = model.PhoneNumber,
            };
            var userDto = new UserDto
            {
                FullName = user.FullName,
                Password = user.Password,
                Email = user.Email,
                Address = user.Address,
                BirthDate = user.BirthDate,
                Gender = user.Gender,
                PhoneNumber = user.PhoneNumber,
            };
            db.Users.Add(userDto);
            db.SaveChanges();

            return "";
        }
        public string Login(LoginCredentials credentials)
        {

            var loginData = new LoginCredentials
            {
                
                Password = credentials.Password,
                Email = credentials.Email,
               
            };
            var user = db.Users.FirstOrDefault(u => u.Email == loginData.Email);

            if (user == null)
            {
                return "No users";
            }

            if(!BCrypt.Net.BCrypt.Verify(loginData.Password, user.Password))
            {
                return "Wrong password";
            }


            return "Authorized";
        }


    }
}
