using AspNetCoreMvc_MovieSales.Models;
using Microsoft.EntityFrameworkCore;
using AspNetCoreMvc_MovieSales.ViewModels;

namespace AspNetCoreMvc_MovieSales.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MovieSale> MovieSales { get; set; }
        public DbSet<MovieSaleDetail> MovieSaleDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API validation
            modelBuilder.Entity<Genre>().
                Property(g => g.Name).HasMaxLength(100);
            modelBuilder.Entity<Movie>().
                Property(m => m.Name).HasMaxLength(200);
            modelBuilder.Entity<Movie>().
                Property(m => m.IsPopuler).HasDefaultValue(true);
            modelBuilder.Entity<Customer>().
                Property(c => c.Name).HasMaxLength(200);
            modelBuilder.Entity<Movie>().
                Property(m => m.ImageUrl).HasDefaultValue("/images/filmAdi.jpg");

            //Seed Data
            modelBuilder.Entity<Genre>().HasData(
                    new Genre() { Id = 1, Name = "Dram", Description = "Acılı, hüzünlü, dramatik" },
                    new Genre() { Id = 2, Name = "Komedi", Description = "Komik, neşeli, eğlenceli" },
                    new Genre() { Id = 3, Name = "Romantik Komedi", Description = "Hem komik, hem romantik, eğlenceli" },
                    new Genre() { Id = 4, Name = "Korku, Gerilim", Description = "Çok korkunç" },
                    new Genre() { Id = 5, Name = "Savaş", Description = "Tarihi savaş ve aksiyon" }
                );
            modelBuilder.Entity<Movie>().HasData(
                    new Movie() { Id = 1, Name = "Truva", Director = "Wolfgan Pettersen", Cast = "Bradd Pitt, Orlando Bloom", Stock = 12, Price = 250, Summary = "Eski çağlarda ünlü truva savaşından kesitler", ReleaseDate = Convert.ToDateTime("01.01.1992"), ImageUrl="/images/Barbie.jpg", GenreId = 5 },
                    new Movie() { Id = 2, Name = "Baskın", Director = "Gareth Evans", Cast = "Ananda George, Donny Alamsyah", Stock = 10, Price = 250, Summary = "Operasyon timinin uyuşturucu baskınları", ReleaseDate = Convert.ToDateTime("01.01.1998"), ImageUrl = "/images/BlueBeetle.jpg", GenreId = 5 },
                    new Movie() { Id = 3, Name = "Titanic", Director = "James Cameron", Cast = "Leonardo Di Caprio, Cate Winslet", Stock = 10, Price = 250, Summary = "Lüks Titanic gemisinin hazin öyküsü", ReleaseDate = Convert.ToDateTime("01.01.1999"), ImageUrl = "/images/CehennemMelekleri.jpg", GenreId = 1 },
                    new Movie() { Id = 4, Name = "Fight Club", Director = "David Lyinch", Cast = "Bradd Pitt, Edward Norton", Stock = 10, Price = 250, Summary = "Dövüş kulübü, ilk kural bahsetmemek", ReleaseDate = Convert.ToDateTime("01.01.2002"), ImageUrl = "/images/Doru.jpg", GenreId = 1 },
                    new Movie() { Id = 5, Name = "Soysuzlar Çetesi", Director = "Quantin Tarantino", Cast = "Bradd Pitt, Christoph Wals", Stock = 10, Price = 250, Summary = "2.Dünya savaşından kesitler", ReleaseDate = Convert.ToDateTime("01.01.2006"), ImageUrl = "/images/Efsunlu3.jpg", GenreId = 5 },
                new Movie() { Id = 6, Name = "Soysuzlar Çetesi", Director = "Quantin Tarantino", Cast = "Bradd Pitt, Christoph Wals", Stock = 10, Price = 250, Summary = "2.Dünya savaşından kesitler", ReleaseDate = Convert.ToDateTime("01.01.2006"), ImageUrl = "/images/GranTurismo.jpg", GenreId = 2 }, 
                new Movie() { Id = 7, Name = "Soysuzlar Çetesi", Director = "Quantin Tarantino", Cast = "Bradd Pitt, Christoph Wals", Stock = 10, Price = 250, Summary = "2.Dünya savaşından kesitler", ReleaseDate = Convert.ToDateTime("01.01.2006"), ImageUrl = "/images/GucYuzukleri.jpg", GenreId = 4 }, 
                new Movie() { Id = 8, Name = "Soysuzlar Çetesi", Director = "Quantin Tarantino", Cast = "Bradd Pitt, Christoph Wals", Stock = 10, Price = 250, Summary = "2.Dünya savaşından kesitler", ReleaseDate = Convert.ToDateTime("01.01.2006"), ImageUrl = "/images/Hulk.webp", GenreId = 5 }, 
                new Movie() { Id = 9, Name = "Soysuzlar Çetesi", Director = "Quantin Tarantino", Cast = "Bradd Pitt, Christoph Wals", Stock = 10, Price = 250, Summary = "2.Dünya savaşından kesitler", ReleaseDate = Convert.ToDateTime("01.01.2006"), ImageUrl = "/images/Meg2.jpg", GenreId = 1 }
                );

            modelBuilder.Entity<Customer>().HasData(
                    new Customer() { Id = 1, Name = "Ali Uçar", Phone = "532 432 45 67", Address = "Beşiktaş-İstanbul", Email="ali@gmail.com", Password="123" },
                    new Customer() { Id = 2, Name = "Neşe Sever", Phone = "542 532 45 77", Address = "Kadıköy-İstanbul", Email = "nese@gmail.com", Password = "456" },
                    new Customer() { Id = 3, Name = "Oya Koşar", Phone = "537 132 88 99", Address = "Bakırköy-İstanbul", Email = "oya@gmail.com", Password = "789" }
                );
        }

        public DbSet<AspNetCoreMvc_MovieSales.ViewModels.CustomerViewModel> CustomerViewModel { get; set; } = default!;

    }
}
