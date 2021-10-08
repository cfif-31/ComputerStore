using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore.Types.Products
{
    public class Monitor: Product
    {
        public float diagonal;

        public override void GetInfo(User user)
        {
            base.GetInfo(user);
            Console.WriteLine("diagonal " + diagonal);
        }
    }
}
