using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Luis_Manuel_Duarte_P2.Api.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<Accesorios> Accesorios { get; set; }
        public DbSet<Vehiculos_Detalle> Vehiculos_Detalle { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Accesorios>().HasData(new List<Accesorios>()
            {
                new Accesorios() { AccesorioId = 1, Descripcion = "Camara trasera" },
                new Accesorios() { AccesorioId = 2, Descripcion = "Pantalla interior" },
                new Accesorios() { AccesorioId = 3, Descripcion = "Interior en piel" },
                new Accesorios() { AccesorioId = 4, Descripcion = "Sun Roof" },
                new Accesorios() { AccesorioId = 5, Descripcion = "Aros de Lujo" }
            });
        }
    }
}
