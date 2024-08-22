using IProductRepositories.Contracts;
using Repositories.Contracts;

namespace Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IProductRepository _productrepository;
        private IProductRepository productRepository;

        public RepositoryManager(IProductRepository productRepository,RepositoryContext context)
        {
          
            _context = context;
            _productrepository = productRepository;
        }
 

       public IProductRepository Product => _productrepository;

       

       

       

        public void Save()
        {
          _context.SaveChanges();     
        }

        
    }
}