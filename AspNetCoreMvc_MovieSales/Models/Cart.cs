namespace AspNetCoreMvc_MovieSales.Models
{
    public class Cart
    {
        //Sepet doğrudan veritabanı üzerinde tutulacaksa benzersiz bir sepet (Cart) oluşturulması gerekir.
        public int Id { get; set; }     //Sepeti benzersiz yapar (PK)
        public int UserId { get; set; } //Sepetin ait olduğu kullanıcıyı belirler.
        
        private List<CartLine> cartLines = new List<CartLine>();

        public List<CartLine> CartLines => cartLines;

    }
}
