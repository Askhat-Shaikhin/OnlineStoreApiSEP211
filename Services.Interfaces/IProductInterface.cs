using OnlineStore.Model;

namespace Services.Interfaces
{
    public interface IProductInterface
    {
        Task<Product> GetProduct();
        Task<List<Product>> GetProducts();
    }
}
