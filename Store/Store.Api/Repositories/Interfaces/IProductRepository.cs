using Store.Api.Models;

namespace Store.Api.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IReadOnlyCollection<Product> GetAll();
    }
}
