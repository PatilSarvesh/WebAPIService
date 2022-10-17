using ProductsCatalogService.Model.Entities;

namespace ProductsCatalogService.Model.Data
{
    public class ProductsCatalogEFRepository : IProductsCatalogRepository
    {
        private ProductsCatalogDbContext db = new ProductsCatalogDbContext();
        public void CreateProduct(Product product)
        {
            db.Products.Add(product);
           db.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            db.Products.Remove(GetProduct(id));
            db.SaveChanges();
        }

        public List<Product> GetAllProductsByAvailability()
        {
            return db.Products.Where(p => p.InStock == true).ToList();
        }

        public List<Product> GetAllProductsByBrand(string brand)
        {
            return db.Products.Where(p => p.Brand == brand).ToList();
        }

        public List<Product> GetAllProductsByCatagory(string catagory)
        {
           return db.Products.Where(p => p.Catagory == catagory).ToList();
        }

        public List<Product> GetAllProductsByColor(string color)
        {
            return db.Products.Where(p => p.Color == color).ToList();
        }

        public List<Product> GetAllProductsByCountry(string country)
        {
            return db.Products.Where(p => p.Country == country).ToList();
        }

        public List<Product> GetAllProductsByPrice(int price)
        {
            return db.Products.Where(p => p.Price <= price).ToList();
        }

        public Product GetCheapestProduct()
        {
            return db.Products.OrderByDescending(p => p.Price).LastOrDefault();
        }

        public Product GetCostliestProduct()
        {
            return db.Products.OrderByDescending(p => p.Price).FirstOrDefault();
        }

        public Product GetProduct(int id)
        {
            return db.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public void UpdateProduct(Product product)
        {
            db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
