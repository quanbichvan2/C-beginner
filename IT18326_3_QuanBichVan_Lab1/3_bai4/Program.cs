class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap 3 canh: a,b,c :");
        float a,b,c;
        double delta;
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        c = float.Parse(Console.ReadLine());
        Console.WriteLine("tinh delta ");
        delta = Math.Pow(b, 2) - 4*a*c;
        Console.WriteLine(delta);
        if (delta < 0)
        {
            Console.WriteLine("phuong trinh vo nghiem");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("can delta la: ");
            Console.WriteLine(Math.Round(Math.Sqrt(delta),2));
            Environment.Exit(0);
        }
    }
}
