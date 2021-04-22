using System;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new LivroContext())
            {
                //db.Database.EnsureCreated();
                db.Livros.Add(new Livro { Titulo = "Cosmos", Autor = "Carl Sagan", AnoPublicacao = 1980 });
                db.Livros.Add(new Livro { Titulo = "1984", Autor = "George Orwell", AnoPublicacao = 1949 });
                db.SaveChanges();

                Console.WriteLine("RESULTADOS DA CONSULTA");
                db.Livros.ForEachAsync(x => Console.WriteLine($"Título: {x.Titulo} | Autor: {x.Autor} | Ano de publicação: {x.AnoPublicacao}"));
            }
        }
    }
}