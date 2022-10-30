using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product{ Id =1, Name="Beans" , Type="Food", Price=280.00 },
                new Product{ Id =2, Name="Soya Protien" , Type="Suppliment", Price=310.00 },
                new Product{ Id =3, Name="Beans" , Type="Food", Price=280.00 },
                new Product{ Id =4, Name="Canola Oil" , Type="Food", Price=530.00 },
                new Product{ Id =5, Name="Cod Oil" , Type="Suppliment", Price=280.00 },
                new Product{ Id =6, Name="Olive Oil" , Type="Food", Price=330.00 }
            };

            products
                .OrderBy(p => p.Price)
                .ToList()
                .ForEach(p => Console.WriteLine(p));

            Console.WriteLine();

            products
                .Where(p => p.Type == "Food")
                .ToList()
                .ForEach(p => Console.WriteLine(p));


            products
                .Select(p => new { p.Name, p.Price })
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Name.PadRight(30, ' ')} \t{x.Price:0.00}"));

            Console.WriteLine();
            products
                .GroupBy(p => p.Type)
                .Select(gr => gr)
                .ToList()
                .ForEach(gr =>
                {
                    Console.WriteLine(gr.Key);
                    gr
                    .ToList()
                    .ForEach(g => Console.WriteLine($"\t{g}"));
                });

            Console.WriteLine();
            products
                .Select(p => p.Type)
                .Distinct()
                .ToList()
                .ForEach(t => Console.WriteLine(t));




            Console.ReadKey();
        }//Main



    }//Clas
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type {get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return ($"{Id}\t{Name.PadRight(20, ' ')}  {Price:0.00} {Type}");
        }




    }
}//Namespace
