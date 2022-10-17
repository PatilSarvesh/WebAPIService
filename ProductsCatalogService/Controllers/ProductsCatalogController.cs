using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsCatalogService.Model.Data;
using ProductsCatalogService.Model.Entities;

namespace ProductsCatalogService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsCatalogController : ControllerBase
    {
        IProductsCatalogRepository repo = new ProductsCatalogEFRepository();
        public List<Product> GetProducts()
        {
            return repo.GetProducts();
        }

        [Route("{id}")]
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

        //get products by company
        [Route("Brand/{company}")]
        public List<Product> GetAllProductsByBrand(string company)
        {
            return repo.GetAllProductsByBrand(company);
        }

        //get productrs by catagory
        [Route("Catagory/{catagory}")]
        public List<Product> GetAllProductsByCatagory(string catagory)
        {
            return repo.GetAllProductsByCatagory(catagory);
        }

        //get productrs by Country
        [Route("Country/{country}")]
        public List<Product> GetAllProductsByCountry(string country)
        {
            return repo.GetAllProductsByCountry(country);
        }

        //get productrs by Price
        [Route("Price/{price}")]
        public List<Product> GetAllProductsByPrice(int price)
        {
            return repo.GetAllProductsByPrice(price);
        }

        //get productrs by Costliest
        [Route("Costliest")]
        public Product GetCostliestProduct()
        {
            return repo.GetCostliestProduct();
        }

        //get productrs by Cheapest
        [Route("Cheapest")]
        public Product GetCheapestProduct()
        {
            return repo.GetCheapestProduct();
        }

        //get productrs by Availability
        [Route("Avail")]
        public List<Product> GetAvailProduct()
        {
            return repo.GetAllProductsByAvailability();
        }
    }
}
