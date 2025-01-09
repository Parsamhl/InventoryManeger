using InventoryManeger.Entity;

namespace InventoryManeger.Contract.Repository
{
    public interface IUserRepository
    {
        User GetUser(string username);
        bool PasswordIsValid(string userName, string password);
        List<Product> UserProducts(string username);
        void Register(User user);
    }
}
