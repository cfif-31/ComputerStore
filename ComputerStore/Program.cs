using ComputerStore.Types;
using ComputerStore.Types.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Product product = new Product();
            product.ProductName = "Пылесос LG";
            product.Price = 2100;
            products.Add(product);
            products.Add(new Product { ProductName = "Мышь компьютерная", Price = 250.99m });

            Monitor monitor = new Monitor { ProductName = "Монитор Philips", Price = 16999.99m, diagonal = 16.3f };
           // monitor.GetInfo();
            products.Add(monitor);

            User user = new User { login = "ivan", password = "123", name = "Ivanov Ivan", ShopCount = 5 };

            while (true)
            {

                for (int i = 0; i < products.Count; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine(i + ":");
                    products[i].GetInfo(user);
                }

                if (Int32.TryParse(Console.ReadLine(), out int n))
                {
                    Buy(user, products[n]);
                }
            }
        }

        static void Buy(User user, Product product) {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("__________________________________________________________");
            user.ShopCount++;
            Console.WriteLine(user.name  + " " + user.ShopCount+ " buy " + product.ProductName);
        }
    }
}
