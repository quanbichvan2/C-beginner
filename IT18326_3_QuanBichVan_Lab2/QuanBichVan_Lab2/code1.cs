using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanBichVan_Lab2
{
    internal class code1
    {
        public static void bai1()
        {
            int a, b;
            Console.WriteLine("phương trình ax + b = 0");
            Console.WriteLine("nhập a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhập b: ");
            b = Convert.ToInt32(Console.ReadLine());
            if(a == 0)
            {
                
                if(b == 0) 
                {
                    Console.WriteLine("phương trình vô số nghiệm \n");
                }
                else
                {
                    Console.WriteLine("phương trình vô nghiệm \n");
                }
            }
            else
            {
                Console.WriteLine("phương trình có 1 nghiệm: x = " + (-b / a) + "\n");
            }

        }
    }
}
