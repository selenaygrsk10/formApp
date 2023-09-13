using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _catogories = new();
        static Repository()
        {
        _catogories.Add(new Category{CategoryId = 1, Name="Telefon" });
        _catogories.Add(new Category{CategoryId = 2, Name="Bilgisayar" });

        _products.Add(new Product { ProductId =  1, Name = "IPhone 14",Price = 40000, IsActive = true, Image ="1.jpg", CategoryId = 1});
         _products.Add(new Product { ProductId =  2, Name = "IPhone 11",Price = 20000, IsActive = true, Image ="2.jpg", CategoryId = 1});
          _products.Add(new Product { ProductId =  3, Name = "IPhone S ",Price = 45000, IsActive = true, Image ="3.jpg", CategoryId = 1});
           _products.Add(new Product { ProductId =  4, Name = "IPhone 12",Price = 40900, IsActive = true, Image ="4.jpg", CategoryId =1});

            _products.Add(new Product { ProductId =  5, Name ="Macbook Pro",Price = 89000, IsActive = true, Image ="5.jpg",CategoryId=2});
        
        
        }
        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }
        public static List<Category> Categories
        {
            get
            {
                return _catogories;
            }
        }
    }
}