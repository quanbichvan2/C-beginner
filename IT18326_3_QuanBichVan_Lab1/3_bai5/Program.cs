using System.ComponentModel;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhap 3 canh: a,b,c :");
        double a, b, c;
        double delta; ;
            Console.WriteLine("nhap a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap b");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhap c");
            c = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            { 
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("phuong trinh vo so nghiem");
                        Environment.Exit(0);
                    }
                    Console.WriteLine("phuong trinh vo nghiem");
                    Environment.Exit(0);
            }
                Console.WriteLine("phuong trinh bac 1");
                Console.WriteLine("nghiem x la: ");
                Console.WriteLine(-c / b);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("tinh delta ");
                delta = Math.Pow(b, 2) - 4 * a * c;
                Console.WriteLine(delta);
                if (delta < 0)
                {
                    Console.WriteLine("phuong trinh vo nghiem");
                    Environment.Exit(0);
                }
                else if (delta == 0)
                {
                    Console.WriteLine("phuong trinh co 1 nghiem kep ");
                    Console.WriteLine((-b) / 2 * a);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Phuong trinh co 2 nghiem: ");
                    Console.WriteLine("nghiem x1: ");
                    Console.WriteLine(Math.Round(((-b + Math.Sqrt(delta)) / 2 * a), 2));
                    Console.WriteLine("nghiem x2: ");
                    Console.WriteLine(Math.Round(((-b - Math.Sqrt(delta)) / 2 * a), 2));
                    Environment.Exit(0);
                }
            }

        }
}


