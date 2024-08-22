using Entities.Models;
using IProductRepositories.Contracts;

namespace Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {
     
        }

        public IQueryable<Product> GetAllProducts(bool trackChanges)=>FindAll(trackChanges);
    }
}