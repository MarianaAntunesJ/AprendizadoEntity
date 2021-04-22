using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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

                List<Livro> livros = db.Livros.ToList();

                Console.WriteLine("RESULTADOS DA CONSULTA");
                //db.Livros.ForEachAsync(x => Console.WriteLine($"Título: {x.Titulo} | Autor: {x.Autor}"));
                foreach (var livro in livros)
                {
                    Console.WriteLine($"Título: {livro.Titulo} | Autor: {livro.Autor}");
                }
            }
        }
    }
}