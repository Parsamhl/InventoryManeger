using InventoryManeger.Contract.Repository;
using InventoryManeger.DataBase;
using InventoryManeger.Entity;


namespace InventoryManeger.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository()
        {
            _context = new AppDbContext();
        }

        public User GetUser(string username)
        {
            var user = _context.Users.FirstOrDefault(x => x.UserName == username);
            if (user != null)
            {
                return user;
            }
            return null;
        }
        public bool PasswordIsValid(string userName, string password)
        
           => _context.Users.Any(x => x.UserName == userName && x.Passwrod == password);

        public void Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public List<Product> UserProducts(string username)
        {
            throw new NotImplementedException();
        }
    }
}
