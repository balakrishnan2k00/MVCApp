using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDBContext _dbContext; // need to create to access db
        public HomeController(ILogger<HomeController> logger, ApplicationDBContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;//always
        }

        public IActionResult Index()
        {
            //lazy loading - default
                IEnumerable<Villa> villas1 = _dbContext.villas;

                List<Villa> villas = _dbContext.villas.ToList();


                //for loop
                    //var totalVilla = villas.Count();

                    ////Console.WriteLine(totalVilla);

                    //for (int i = 0; i<totalVilla; i++)
                    //{
                    //    villas[i].VillaAmenity = _dbContext.villaAmenities.Where(u => u.VillaId == villas[i].Id).ToList();
                    //}
                //foreach loop
            
                foreach(var villa in villas)
                {
                    villa.VillaAmenity = _dbContext.villaAmenities.Where(u => u.VillaId == villa.Id).ToList();
                }

            //Eager Loading





            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
