using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanBichVan_Lab2
{
    internal class code2
    {
        public static void bai2()
        {
            Console.WriteLine("Phương trình bậc 2: ax^2 + bx + c = 0");
            double a, b, c;
            Console.WriteLine("nhập a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhập b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhập c: ");
            c = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                if(b==0)
                {
                    if(c==0)
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
                    Console.WriteLine("phương trình có 1 nghiệm: x = " + (-c/b) + "\n");
                }
            }
            else
            {   
                double del;
                del = Math.Pow(b, 2) - 4*a*c;
                Console.WriteLine("denta = " + del);
                if (del < 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm \n");
                }
                else if (del == 0)
                {
                    Console.WriteLine("Phương trình có 1 nghiệm kép x= " + ((-b) / 2 * a) + "\n");
                }
                else
                {
                    Console.WriteLine("Phương trình có 2 nghiệm x = " + (-b + Math.Sqrt(del)) / 2 * a + " x= " + (-b + Math.Sqrt((del)) / 2 * a) + "\n");
                }
            }
        }
    }
}
