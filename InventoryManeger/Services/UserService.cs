using InventoryManeger.Contract.Services;
using InventoryManeger.Entity;
using InventoryManeger.Repository;

namespace InventoryManeger.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _repository;

        public UserService()
        {
            _repository = new UserRepository();
        }

        public bool Login(string username, string password)
        {
            var user = _repository.GetUser(username);

            if (user == null)
            {
                return false;
            }
            else
            {
                _repository.PasswordIsValid(username, password);
                if (user.UserName == username && user.Passwrod == password)
                {
                    return true;
                }
            }
            return false;
        }



        public void Register(string name, string lastName, string userName, string password)
        {
            if(name != null && lastName != null)
            {
                if (userName.Length > 4 && password !=null)
                {
                    User user = new User() { Name = name, LastName = lastName, Passwrod = password, UserName = userName };
                   _repository.Register(user);  
                }
            }
        }
    }
}
