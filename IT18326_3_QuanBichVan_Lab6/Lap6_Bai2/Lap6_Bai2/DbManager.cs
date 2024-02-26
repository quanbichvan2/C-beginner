using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap6_Bai2
{
   class DbManager
   {
        static void Main(string[] args)
        {
            IDbActrion db = new Order();
            db.Insert();

            db = new Product();
            db.Insert();

            Console.Read();
        }
    }
}
