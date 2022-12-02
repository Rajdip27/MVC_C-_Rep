using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcRepsetiory.Data;
using MvcRepsetiory.Interfaces.Manager;
using MvcRepsetiory.Manager;
using MvcRepsetiory.Models;

namespace MvcRepsetiory.Controllers
{
    
    public class ProductController : Controller
    {
        private ApplicationDBContext _dbContext;
        IProductManager _productManager;
        public ProductController(ApplicationDBContext dbContext)
        {
            _dbContext=dbContext;
            _productManager = new ProductManager(_dbContext);
        }

        public IActionResult Index()
        {
            var products = _productManager.GetAll();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            string mgs = "";
            bool isSave=  _productManager.Add(product);
            if (isSave)
            {
                return Redirect("index");

            }
            else
            {
                mgs = "Product Save Filed";
            }

            ViewBag.mgs = mgs;

            return View();

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _productManager.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);

        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            bool IsUpdate=_productManager.Update(product);
            if (IsUpdate)
            {
                return RedirectToAction ("index");
            }
            return View(product);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var product=_productManager.GetById(id);
            if(product == null)
            {
                return NotFound();

            }

            return View(product);
        }
        public IActionResult Delete(int id)
        {
            var product=_productManager.GetById(id);
            if (product == null)
            {
                return NotFound();

            }
            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            bool IsDelete=_productManager.Delete(product);

            if (IsDelete)
            {
                return RedirectToAction("index");
            }
            return View(product);

        }

    }
}
