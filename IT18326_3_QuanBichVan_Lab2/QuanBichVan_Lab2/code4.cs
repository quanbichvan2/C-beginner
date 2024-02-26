using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanBichVan_Lab2
{
    internal class code4
    {
        public static void bai4()
        {
            Boolean check = true;
            Console.Write("Nhập số = ");
            double number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= Math.Round(number / 2); i++)
            {
                if (number % i == 0)
                {
                    check = false;
                    break;
                }
            }
            if (check == true)
            {
                Console.WriteLine("{0} là số nguyên tố", number);
            }
            else
            {
                Console.WriteLine("{0} không phải số nguyên tố", number);
            }

            /*
            quick test
            13
            */
        }
    }
}
