using FrontToBackIntroTask.Models;
using FrontToBackIntroTask.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBackIntroTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
{
    new Product
    {
        Id = 1,
        Title = "Jack Daniel's Old No.7",
        ImageURL = "prod-1.jpg",
        Price = 45.99m
    },
    new Product
    {
        Id = 2,
        Title = "Johnnie Walker Black Label",
        ImageURL = "prod-2.jpg",
        Price = 55.50m
    },
    new Product
    {
        Id = 3,
        Title = "Chivas Regal 12 Years",
        ImageURL = "prod-3.jpg",
        Price = 48.00m
    },
    new Product
    {
        Id = 4,
        Title = "Absolut Vodka",
        ImageURL = "prod-4.jpg",
        Price = 30.25m
    },
    new Product
    {
        Id = 5,
        Title = "Bacardi Superior Rum",
        ImageURL = "prod-5.jpg",
        Price = 28.90m
    },
    new Product
    {
        Id = 6,
        Title = "Hennessy VS Cognac",
        ImageURL ="prod-6.jpg" ,
        
        Price = 75.00m
    },
    new Product
    {
        Id = 7,
        Title = "Martini Extra Dry",
        ImageURL = "prod-7.jpg",
        Price = 22.40m
    },
    new Product
    {
        Id = 8,
        Title = "Captain Morgan Spiced Rum",
        ImageURL = "prod-8.jpg",
        Price = 26.75m
    }
};

            List<Slider> sliders = new List<Slider>
            {
                new Slider
                {
                    Id = 1,
                    Title = "Hot Drink/",
                    Desc = "It is interesting."
                },
                new Slider
                {
                    Id = 2,
                    Title = "Cold Drink/",
                    Desc = "It is Cool."
                }
            };

            HomeVM vm = new HomeVM()
            {
                Products = products,
                Sliders = sliders
            };
            return View(vm);
        }
    }
}
