using InventoryManeger.Dtos;
using InventoryManeger.Entity;

namespace InventoryManeger.Contract.Repository
{
    public interface IProductRepository
    {
        Product GetProduct(int id);
        List<ProductDto> GetAll();
        void ChangeQuentity(int quentity);
        void DeleteProduct(int id);
        void AddProduct(Product product);
        bool IsAvailabel(int id);

    }
}
