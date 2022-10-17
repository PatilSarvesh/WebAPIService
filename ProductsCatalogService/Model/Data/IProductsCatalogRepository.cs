using ProductsCatalogService.Model.Entities;

namespace ProductsCatalogService.Model.Data
{
    public interface IProductsCatalogRepository
    {
        List<Product> GetProducts();
        Product GetProduct(int id);

        List<Product> GetAllProductsByCatagory(string catagory);
        List<Product> GetAllProductsByBrand(string brand);
        List<Product> GetAllProductsByColor (string color);
        List<Product> GetAllProductsByCountry (string country);
        List<Product> GetAllProductsByPrice (int price);
        List<Product> GetAllProductsByAvailability ();
        Product GetCostliestProduct();
        Product GetCheapestProduct();
        void DeleteProduct(int id); 
        void UpdateProduct(Product product);
        void CreateProduct(Product product);

    }
}
