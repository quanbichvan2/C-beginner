using System.Text;

namespace Hinh
{
    internal class ChuNhat
    {
        private double rong { get; set; }
        private double dai { get; set; }
        public ChuNhat(double rong, double dai)
        {
            this.dai = dai;
            this.rong = rong;
        }

        public double getChuVi()
        {
            return (this.rong + this.dai) * 2;
        }
        public double getDienTich()
        {
            return this.rong * this.dai;
        }

        public virtual void xuat()
        {
            Console.WriteLine($"\nDiện tích hình chữ nhật: {getDienTich()}");
            Console.WriteLine($"Chu vi hình chữ nhật: {getChuVi()}");
        }
    }
    class Vuong : ChuNhat
    {
        public double canh { get; set; }
        public Vuong(double canh) : base(canh, canh)
        {

        }
        public override void xuat()
        {
            Console.WriteLine($"\nDiện tích hình vuông: {getDienTich()}");
            Console.WriteLine($"Chu Vi hình vuông: {getChuVi()}");
        }
    }
    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            ChuNhat cn = new ChuNhat(4, 2);
            Vuong v = new Vuong(3);
            cn.xuat();
            v.xuat();
        }
    }
}