using AdvancedDatabaseandORMConcepts.Data;
using AdvancedDatabaseandORMConcepts.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AdvancedDatabaseandORMConcepts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FullStackMusicContext _musicContext;

        public HomeController(ILogger<HomeController> logger , FullStackMusicContext context)
        {
            _logger = logger;
            _musicContext = context;
        }

        public IActionResult Index()
        {
            return _musicContext.Artists != null ?
                          View(_musicContext.Artists.ToList()) :
                          Problem("Entity set 'MusicStreamingContext.Artists' is null.");
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