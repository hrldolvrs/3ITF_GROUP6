using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheMask.Data;
using TheMask.Models;
using Microsoft.EntityFrameworkCore;

namespace TheMask.Controllers
{
    public class HomeController : Controller
    {
        /*private readonly ILogger<HomeController> _logger;*/

        private readonly AppDbContext _dbData;

        public HomeController(AppDbContext dbData)
        {
            _dbData = dbData;   
        }

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Makeup()
        {
            return View(_dbData.Products);
        }

        public IActionResult Skincare()
        {
            return View(_dbData.Products);
        }
        [HttpGet]
        public IActionResult Contact()
        {
            //when add to database maybe we can auto add the date it was added (if so remove datetime input in Contact.cshtml
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact newcontact)
        {
           
                if(!ModelState.IsValid) 
                return View();
                _dbData.Contacts.Add(newcontact);
                _dbData.SaveChanges();
                return View();
            
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
} 
