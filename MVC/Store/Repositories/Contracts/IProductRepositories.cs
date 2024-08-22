using Entities.Models;
using Repositories.Contracts;

namespace IProductRepositories.Contracts
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IQueryable<Product> GetAllProducts(bool trackChanges );
    }
}