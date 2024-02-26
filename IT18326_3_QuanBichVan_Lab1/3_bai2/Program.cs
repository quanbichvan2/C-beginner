class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("nhap chieu dai va rong hcn: ");
        int d, r;
        d = int.Parse(Console.ReadLine());
        r = int.Parse(Console.ReadLine());
        Console.WriteLine("chu vi hcn la: ");
        Console.WriteLine((d + r) * 2);
        Console.WriteLine("dien tich hcn la ");
        Console.WriteLine(d * r);
        Console.WriteLine("canh nho nhat: ");
        Console.WriteLine(Math.Min(d, r));
    }
}