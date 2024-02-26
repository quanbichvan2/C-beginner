using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap6_Bai2
{
    class Order : IDbActrion
    {
        public void Delete()
        {
            Console.WriteLine("Order in Delete");
        }

        public void Insert()
        {
            Console.WriteLine("Order in Insert");
        }

        public void Select()
        {
            Console.WriteLine("Order in Select");
        }

        public void Update()
        {
            Console.WriteLine("Order in Update");
        }
    }
}
