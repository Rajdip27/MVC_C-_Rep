using System.ComponentModel.DataAnnotations;

namespace MvcRepsetiory.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Please Enter Item Name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Please Enter Description ")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Please Enter Price")]
        public decimal Price { get; set; }

    }
}
