using EF.Core.Repository.Interface.Repository;
using MvcRepsetiory.Models;

namespace MvcRepsetiory.Interfaces.Repository
{
    public interface IProductRepository:ICommonRepository<Product>
    {
    }
}
