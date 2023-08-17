using MagicVillage_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVillage_API.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre = "Villa real",
                    detalle = "Detalle de la villa ",
                    imagenUrl = "",
                    ocupantes = 5,
                    metrosCuadrados = 5,
                    tarifa = 150,
                    amenidad = "",
                    fechaCreacion = DateTime.Now,
                    fechaActualizacion = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Nombre = "Premium vista a la piscina",
                    detalle = "Detalle de la villa ",
                    imagenUrl = "",
                    ocupantes = 4,
                    metrosCuadrados = 40,
                    tarifa = 150,
                    amenidad = "",
                    fechaCreacion = DateTime.Now,
                    fechaActualizacion = DateTime.Now
                }
            );
        }
    }
}
