using InventoryManeger.Entity;

namespace InventoryManeger.Contract.Services
{
    public interface IProductService
    {

        void AddProduct(Product product);
        List<Product> GetAllProducts();

    }
}
