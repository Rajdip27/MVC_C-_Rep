using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using MvcRepsetiory.Interfaces.Repository;
using MvcRepsetiory.Models;

namespace MvcRepsetiory.Repository
{
    public class ProductRepository:CommonRepository<Product>,IProductRepository
    {
        public ProductRepository(DbContext dbContext):base(dbContext)
        {

        }

    }
}
