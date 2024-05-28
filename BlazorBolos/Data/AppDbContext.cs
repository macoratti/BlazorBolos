using Microsoft.EntityFrameworkCore;

namespace BlazorBolos.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
    public DbSet<Bolo> Bolos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bolo>().HasData(
            new Bolo
            {
                Id = 1,
                Nome = "Bolo de banana",
                Descricao = "Bolo de banana",
                Preco = 23.00m,
                ImagemUrl = "https://macoratti.net/Imagens/bolos/bolo_banana.jpg"
            },
            new Bolo
            {
                Id = 2,
                Nome = "Bolo Brigadeiro",
                Descricao = "Bolo brigadeiro",
                Preco = 31.50m,
                ImagemUrl = "https://macoratti.net/Imagens/bolos/bolo_brigadeiro.jpg"
            },
             new Bolo
             {
                 Id = 3,
                 Nome = "Bolo de Chocolate",
                 Descricao = "Bolo de Chocolate",
                 Preco = 41.00m,
                 ImagemUrl = "https://macoratti.net/Imagens/bolos/bolo_chocolate.jpg"
             },
            new Bolo
            {
                Id = 4,
                Nome = "Bolo de Laranja",
                Descricao = "Bolo de laranja",
                Preco = 35.00m,
                ImagemUrl = "https://macoratti.net/Imagens/bolos/bolo_laranja"
            }
        );
    }
}
