using Lab.Net.Models;

namespace Lab.Net.Service.Account
{
    public interface IAccountService
    {
        public string Registration(UserRegisterModel model);
        public string Login(LoginCredentials credentials);
    }
}
