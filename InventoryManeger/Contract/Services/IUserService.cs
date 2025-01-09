using InventoryManeger.Entity;

namespace InventoryManeger.Contract.Services
{
    public interface IUserService
    {
        bool Login (string username, string password);
        void Register(string name , string lastName , string userName , string password );


    }
}
