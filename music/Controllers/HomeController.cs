using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using music.Models;
using System.Diagnostics;
using music.Data;

namespace music.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new MainPageViewModel
            {
                ArtistCount = _context.Artists.Count(),
                GenreCount = _context.Genres.Count(),
                SongCount = _context.MusicVideos.Count()
            };
            return View(viewModel);
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