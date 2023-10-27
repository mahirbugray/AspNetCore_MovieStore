using AspNetCoreMvc_MovieSales.Models;

namespace AspNetCoreMvc_MovieSales.Interfaces
{
    public interface IGenreRepository
    {
        public List<Genre> GetAll();
        public Genre GetById(int id);
        public void Add(Genre genre);
        public void Update(Genre genre);
        public void Delete(Genre genre);
    }
}
