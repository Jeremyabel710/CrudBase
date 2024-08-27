using Microsoft.EntityFrameworkCore;

namespace CrudBase.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasKey(c => c.ID_CLIE); // Configura la clave primaria

            modelBuilder.Entity<Client>()
                .Property(c => c.ID_CLIE)
                .HasColumnName("ID_CLIE");

            modelBuilder.Entity<Client>()
                .Property(c => c.NOM_CLIE)
                .HasColumnName("NOM_CLIE");

            modelBuilder.Entity<Client>()
                .Property(c => c.APE_CLIE)
                .HasColumnName("APE_CLIE");

            modelBuilder.Entity<Client>()
                .Property(c => c.CONTACTO)
                .HasColumnName("CONTACTO");
        }
    }

    public class Client
    {
        public int ID_CLIE { get; set; }
        public string NOM_CLIE { get; set; }
        public string APE_CLIE { get; set; }
        public int CONTACTO { get; set; }
    }
}