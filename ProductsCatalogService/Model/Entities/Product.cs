using System.ComponentModel.DataAnnotations;

namespace ProductsCatalogService.Model.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public int Price { get; set; }
        public string Catagory { get; set; }
        public string Brand { get; set; }
        public double Rating { get; set; }
        
        public string Color { get; set; }

        public string Country { get; set; }
        public bool InStock { get; set; }

    }
}
