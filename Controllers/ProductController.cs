using btt2.Models;
using Microsoft.AspNetCore.Mvc;

namespace btt2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Product 1",
                    Price = 500000,
                    CreatedAt = new DateTime(2020, 12, 25),
                    Image = "https://images.unsplash.com/photo-1584917865442-de89df76afd3?w=500"
                },

                new Product
                {
                    Id = 2,
                    Name = "Product 2",
                    Price = 700000,
                    CreatedAt = new DateTime(2020, 12, 25),
                    Image = "https://images.unsplash.com/photo-1590874103328-eac38a683ce7?w=500"
                },

                new Product
                {
                    Id = 3,
                    Name = "Product 3",
                    Price = 600000,
                    CreatedAt = new DateTime(2020, 12, 25),
                    Image = "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=500"
                },

                new Product
                {
                    Id = 4,
                    Name = "Product 4",
                    Price = 500000,
                    CreatedAt = new DateTime(2020, 12, 25),
                    Image = "https://images.unsplash.com/photo-1594223274512-ad4803739b7c?w=500"
                }
            };

            return View(products);
        }
    }
}