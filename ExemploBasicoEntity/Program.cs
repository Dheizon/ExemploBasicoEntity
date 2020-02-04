using ExemploBasicoEntity.Context;
using ExemploBasicoEntity.Models;
using System;
using System.Linq;

namespace ExemploBasicoEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                //Lendo e criando um novo blog
                Console.Write("Insira o nome do Blog: ");
                var name = Console.ReadLine();

                var blog = new Blog();
                blog.Name = name;

                db.Blogs.Add(blog);
                db.SaveChanges();

                //Mostra todos os blogs encontrado no banco de dados
                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                Console.WriteLine("Todos os blogs na base de dados:");

                foreach (var item in query)
                {
                    Console.WriteLine("Id: " + item.BlogId + " Nome do blog: " + item.Name);
                }

                Console.WriteLine("Pressione uma tecla para sair...");
                Console.ReadKey();

            }

            
        }
    }
    
}
