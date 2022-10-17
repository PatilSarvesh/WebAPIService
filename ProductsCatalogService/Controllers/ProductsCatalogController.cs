using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsCatalogService.Model.Data;
using ProductsCatalogService.Model.Entities;

namespace ProductsCatalogService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsCatalogController : ControllerBase
    {
        IProductsCatalogRepository repo = new ProductsCatalogEFRepository();
        public List<Product> GetProducts()
        {
            return repo.GetProducts();
        }

        [Route("ID/{id}")]
        public Product GetProduct(int id)
        {
            return repo.GetProduct(id);
        }

        //get products by color
        [Route("Color/{color}")]
        public List<Product> GetAllProdcutsByColor(string color)
        {
            return repo.GetAllProductsByColor(color);
        }
    }
}
