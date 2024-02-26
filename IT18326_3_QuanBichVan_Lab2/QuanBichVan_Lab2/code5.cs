using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanBichVan_Lab2
{
    internal class code5
    {
        public static void bai5()
        {
            Console.WriteLine("Xuất bảng cửu chương 1x10");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    Console.Write("\t{0}x{1}={2}", j, i, i * j);
                }
                Console.WriteLine("");
            }
        }
    }
}
