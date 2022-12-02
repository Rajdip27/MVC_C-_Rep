using EF.Core.Repository.Manager;
using MvcRepsetiory.Data;
using MvcRepsetiory.Interfaces.Manager;
using MvcRepsetiory.Models;
using MvcRepsetiory.Repository;

namespace MvcRepsetiory.Manager
{
    public class ProductManager:CommonManager<Product>,IProductManager
    {
        public ProductManager(ApplicationDBContext dbContext):base(new ProductRepository(dbContext))
        {

        }

        public Product GetById(int id)
        {
            return GetFirstOrDefault(c => c.ProductId == id);
        }
    }
}
