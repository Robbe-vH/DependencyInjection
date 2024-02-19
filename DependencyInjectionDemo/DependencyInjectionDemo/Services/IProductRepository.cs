using DependencyInjectionDemo.Models;

namespace DependencyInjectionDemo.Services
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        BaseResult Add(Product product);
    }
}
