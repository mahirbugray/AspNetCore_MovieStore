using AspNetCoreMvc_MovieSales.Interfaces;
using AspNetCoreMvc_MovieSales.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMvc_MovieSales.Controllers
{
    public class SepetController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        public SepetController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        List<SepetDetay> sepet;
        SepetDetay siparis = new SepetDetay();
        public IActionResult Index()
        {
            sepet = SepetAl();
            TempData["ToplamAdet"] = siparis.ToplamAdet(sepet).ToString();
            TempData["ToplamTutar"] = siparis.ToplamTutar(sepet).ToString();
            return View(sepet);
        }
        public IActionResult Ekle(int Id,  int Adet) 
        {
            var movie = _movieRepository.GetById(Id);
            sepet = SepetAl();
            SepetDetay siparis = new SepetDetay();
            siparis.MovieId = movie.Id;
            siparis.MovieName = movie.Name;
            siparis.MovieQuantity = Adet;
            siparis.MoviePrice = movie.Price;
            sepet = siparis.SepeteEkle(sepet, siparis);
            SepetKaydet(sepet);
            TempData["ToplamAdet"] = siparis.ToplamAdet(sepet).ToString();
            TempData["ToplamTutar"] = siparis.ToplamTutar(sepet).ToString();
            return RedirectToAction("Index");
        }
        public IActionResult Sil(int id)
        {
            sepet = SepetAl();
            sepet = siparis.SepettenSil(sepet, id);
            SepetKaydet(sepet);
            return RedirectToAction("Index");
        }
        public List<SepetDetay> SepetAl()
        {
            var sepet = HttpContext.Session.GetJson<List<SepetDetay>>("sepet")?? new List<SepetDetay>();
            return sepet;
        }
        public void SepetKaydet(List<SepetDetay> sepet)
        {
            HttpContext.Session.SetJson("sepet", sepet);
        }
        public IActionResult SepetSil()
        {
            HttpContext.Session.Clear();    //Oturumda bulunan tüm session'ları siler.
            //HttpContext.Session.Remove("sepet"); sadece ismi belirtilen session'ı siler.
            return RedirectToAction("Index");
        }

    }
}
