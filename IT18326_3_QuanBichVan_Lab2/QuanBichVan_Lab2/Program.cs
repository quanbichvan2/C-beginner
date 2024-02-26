using QuanBichVan_Lab2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int choice;
while (true)
{
    Console.WriteLine("0. Thoát chương trình \n1. Phương trình bậc 1\n2. Phương trình bậc 2 \n3. Tính ngày tháng \n4. kiểm tra 1 số nguyên \n5. Bảng cửu chương");
    Console.WriteLine("nhập số tương ứng: ");
    choice = Convert.ToInt32(Console.ReadLine());
    while (choice < 0 || choice > 5)
    {
        Console.WriteLine("nhập lại số tương ứng");
        choice = Convert.ToInt32(Console.ReadLine());
    }
    switch (choice)
    {
        case 0:
            {
                Console.WriteLine("exit");
                Environment.Exit(0);
                break;
            }
        case 1:
            {
                Console.Clear();
                Console.WriteLine("Tính phương trình bậc 1: ");
                code1.bai1();
                break;
            }
        case 2:
            {
                Console.Clear();
                Console.WriteLine("Tính phương trình bậc 2: ");
                code2.bai2();
                break;
            }
        case 3:
            {
                Console.Clear();
                Console.WriteLine("Tính ngày tháng ");
                code3.bai3();
                break;
            }
        case 4:
            {
                Console.Clear();
                Console.WriteLine("Kiểm tra số nguyên tố ");
                code4.bai4();
                break;
            }
        case 5:
            {
                Console.Clear();
                Console.WriteLine("Bảng cửu chương ");
                code5.bai5();
                break;
            }

    }
}
