using DependencyInjectionDemo.Data;
using DependencyInjectionDemo.Models;

namespace DependencyInjectionDemo.Services
{
    public class ProductRepository : IProductRepository
    {
        ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;                
        }

        public IEnumerable<Product> Products => _context.Products;

        public BaseResult Add(Product product)
        {
            var result = new BaseResult();
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                result.Succeeded = true;
            }
            catch (Exception)
            {
                result.Succeeded = false;
            }

            return result;
        }
    }
}
