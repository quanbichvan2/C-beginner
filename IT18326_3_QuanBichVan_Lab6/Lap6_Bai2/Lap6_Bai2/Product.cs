using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap6_Bai2
{
    class Product : IDbActrion
    {
        public void Delete()
        {
            Console.WriteLine("Product in Delete");
        }

        public void Insert()
        {
            Console.WriteLine("Product in Insert");
        }

        public void Select()
        {
            Console.WriteLine("Product in Select");
        }

        public void Update()
        {
            Console.WriteLine("Product in Update");
        }
    }
}
