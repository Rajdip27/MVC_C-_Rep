using EF.Core.Repository.Interface.Manager;
using MvcRepsetiory.Models;

namespace MvcRepsetiory.Interfaces.Manager
{
    public interface IProductManager:ICommonManager<Product>
    {
        Product GetById(int id);
    }
}
