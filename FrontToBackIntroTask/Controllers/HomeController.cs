using FrontToBackIntroTask.DAL;
using FrontToBackIntroTask.Models;
using FrontToBackIntroTask.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBackIntroTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Product> products = _context.Products
                .Include(p => p.Images)
                .ToList();
            List<Slider> sliders = _context.Sliders.ToList();

            HomeVM vm = new HomeVM()
            {
                Products = products,
               Sliders = sliders
            };
            return View(vm);
        }
        public IActionResult Details(int Id)
        {
            return View();
        }
    }
}
