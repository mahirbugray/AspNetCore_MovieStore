namespace AspNetCoreMvc_MovieSales.Models
{
    public class SepetDetay
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int MovieQuantity { get; set; }
        public decimal MoviePrice { get; set; }

        public List<SepetDetay> SepeteEkle(List<SepetDetay> sepet, SepetDetay siparis)
        {
            if(sepet.Any(sd => sd.MovieId == siparis.MovieId))
            {
                //Daha önceden sepette olan bir ürün sepete eklenmişse;
                foreach(SepetDetay sd in sepet)     
                {
                    if(sd.MovieId == siparis.MovieId)
                    {
                        sd.MovieQuantity += siparis.MovieQuantity;  //ürünün miktarını artır.
                    }
                }
            }
            else
            {
                sepet.Add(siparis);  //yeni siparişi sepete ekler.
            }
            return sepet;
        }
        public List<SepetDetay> SepettenSil(List<SepetDetay> sepet, int id)
        {
            sepet.RemoveAll(s => s.MovieId == id);
            return sepet;
        }
        public int ToplamAdet(List<SepetDetay> sepet)
        {
            var toplamAdet = sepet.Sum(s => s.MovieQuantity);
            return toplamAdet;
        }
        public decimal ToplamTutar(List<SepetDetay> sepet)
        {
            var toplamTutar = sepet.Sum(s => s.MovieQuantity * s.MoviePrice);
            return toplamTutar;
        }
    }
}
