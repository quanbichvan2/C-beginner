using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true) {
             Console.WriteLine("1. Phương trình bậc 1\n2. Phương trình bậc 2 \n3. Tính ngày tháng \n4. kiểm tra 1 số nguyên");
                int choice;
                Console.WriteLine("Nhập số tương ứng với chương trình: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice > 1 && choice < 4)
                { 
                    Console.WriteLine("Nhập lại số tương ứng với chương trình từ 1 đến 4: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Environment.Exit(choice);
                }
                else
                {
                    switch (choice)
                    {
                        case 1:
                            {
                                Code.bai_1();
                                break;
                            }
                        case 2:
                            {
                                Code.bai_2();
                                break;
                            }
                        case 3:
                            {
                                Code.bai_3();
                                break;
                            }
                        case 4:
                            {
                                Code.bai_4();
                                break;
                            }
                    }
                }
            } 
        }
    }
}
