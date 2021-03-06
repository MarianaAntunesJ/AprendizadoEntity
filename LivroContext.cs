using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo
{

    public class LivroContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-EBARGUA\SQLEXPRESS;Database=EFCore.Demo;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Livro>().ToTable("Livro");

            modelBuilder.Entity<Livro>().HasKey(p => p.Id);

            modelBuilder.Entity<Livro>().Property(p => p.Titulo).HasColumnType("varchar(50)");
        }
    }
}