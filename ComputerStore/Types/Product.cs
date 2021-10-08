using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Types
{
    public class Product
    {
        public string ProductName;
        public decimal Price;

        public decimal GetPrice(User user) {
            if (user.ShopCount >= 10) {
                return (Price / 100) * 90;
            }
            return Price;
        }

        public virtual void GetInfo(User user) {
            Console.WriteLine("----------");
            Console.WriteLine(ProductName);
            Console.WriteLine(GetPrice(user));
        }
    }
}
