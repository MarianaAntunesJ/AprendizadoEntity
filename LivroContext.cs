using Microsoft.EntityFrameworkCore;

public class LivroContext
{
    public DbSet<Livro> Livros { get; set; }
}