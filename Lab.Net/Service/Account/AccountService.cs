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

        //public string Login(LoginCredentials model)
        //{
        //    var userData = new LoginCredentials
        //    {
        //        Email = model.Email,
        //        Password = model.Password
        //    };
        //}

        public string Registration(UserRegisterModel model)
        {

            var user = new UserRegisterModel
            {
                FullName = model.FullName,
                Password = model.Password,
                Email = model.Email,
                Address = model.Address,
                BirthDate = model.BirthDate,
                Gender = model.Gender,
                PhoneNumber = model.PhoneNumber



            };
            var dataForUsers = new UserDto
            {
                FullName = user.FullName,
                Password = user.Password,
                Email = user.Email,
                Address = user.Address,
                BirthDate = user.BirthDate,
                Gender = user.Gender,
                PhoneNumber = user.PhoneNumber
            };

            db.Users.Add(dataForUsers);


            db.SaveChanges();

            return "Юзер зарегистрирован";
        }

    }
}
