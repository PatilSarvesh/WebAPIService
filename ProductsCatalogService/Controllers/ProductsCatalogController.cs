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

        [Route("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = repo.GetProduct(id);
            if(product == null) //if no data found 
            {
                //return 404
                return NotFound();

            }
            //return 200 with data
            return Ok(product);
        }

        //get products by color
        [Route("Color/{color}")]
        public ActionResult<List<Product>> GetAllProdcutsByColor(string color)
        {
            var colors = repo.GetAllProductsByColor(color);
            if(colors.Count == 0)
            {
                return NotFound();
            }

            return Ok(colors);
        }

        //get products by company
        [Route("Brand/{company}")]
        public ActionResult<List<Product>> GetAllProductsByBrand(string company)
        {
            var companies = repo.GetAllProductsByBrand(company);
            if(companies.Count == 0)
            {
                return NotFound();
            }
            return Ok(companies);
        }

        //get productrs by catagory
        [Route("Catagory/{catagory}")]
        public ActionResult<List<Product>> GetAllProductsByCatagory(string catagory)
        {
            var catagories = repo.GetAllProductsByCatagory(catagory);

            if(catagories.Count == 0)
            {
                return NotFound();
            }
            return Ok(catagories);
        }

        //get productrs by Country
        [Route("Country/{country}")]
        public ActionResult<List<Product>> GetAllProductsByCountry(string country)
        {
            var countries = repo.GetAllProductsByCountry(country);

            if (countries.Count == 0)
            {
                return NotFound();
            }
            return Ok(countries);
        }

        //get productrs by Price
        [Route("Price/{price}")]
        public ActionResult<List<Product>> GetAllProductsByPrice(int price)
        {
            var prices = repo.GetAllProductsByPrice(price);

            if (prices.Count == 0)
            {
                return NotFound();
            }
            return Ok(prices);
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
        public ActionResult<List<Product>> GetAvailProduct()
        {
            //var prices = repo.GetAllProductsByPrice();

            //if (prices.Count == 0)
            //{
            //    return NotFound();
            //}
            //return Ok(prices);
        }
    }
}
