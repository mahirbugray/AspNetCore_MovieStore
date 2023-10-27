using AspNetCoreMvc_MovieSales.Interfaces;
using AspNetCoreMvc_MovieSales.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;

namespace AspNetCoreMvc_MovieSales.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepo;
        public MovieController(IMovieRepository movieRepo)
        {
            _movieRepo = movieRepo;
        }
        SepetDetay siparis = new SepetDetay();
        public IActionResult Index(int? id, string search)
        {
            var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet") ?? new List<SepetDetay>();
            TempData["ToplamAdet"] = siparis.ToplamAdet(sepet).ToString();
            //TempData["ToplamTutar"] = siparis.ToplamTutar(sepet).ToString();

            var movies = _movieRepo.GetAll();
            if(search != null)
            {
                movies = movies.Where(m => m.Name.ToLower().Contains(search.ToLower())).ToList();
            }
            else
            {
                if(id != null)
                {
                    movies = movies.Where(m => m.GenreId == id).ToList();
                }
            }
            return View(movies);
        }
        public IActionResult Details(int id)
        {
            var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet") ?? new List<SepetDetay>();
            TempData["ToplamAdet"] = siparis.ToplamAdet(sepet).ToString();

            var movie = _movieRepo.GetById(id);

            return View(movie);
        }
        public IActionResult Populer()
        {
            var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet") ?? new List<SepetDetay>();
            TempData["ToplamAdet"] = siparis.ToplamAdet(sepet).ToString();
            var movies = _movieRepo.GetAll().Where(m => m.IsPopuler == true).ToList();
            return View();
        }
        public IActionResult Local(bool isLocal)
        {
            var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet") ?? new List<SepetDetay>();
            TempData["ToplamAdet"] = siparis.ToplamAdet(sepet).ToString();
            var movies = _movieRepo.GetAll();
            if (isLocal)
            {
                movies = movies.Where(m => m.IsLocal == true).ToList();
                ViewBag.Local = "Yerli";
            }
            else
            {
                movies = movies.Where(m => m.IsLocal == false).ToList();
                ViewBag.Local = "Yabancı";
            }
            return View();
        }
    }
}
