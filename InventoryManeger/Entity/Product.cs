

namespace InventoryManeger.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int quentity { get; set; }
        public bool IsAvailabel { get; set; }


        public User BorrowedBy { get; set; }
        
    }
}
