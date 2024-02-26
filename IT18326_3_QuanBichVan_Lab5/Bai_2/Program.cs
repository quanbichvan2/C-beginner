namespace Lab_5
{
    public abstract class SinhVienPoly
    {
        private string? hoTen { get; set; }
        private string? nganh { get; set; }

        public SinhVienPoly(string hoTen, string nganh)
        {
            this.hoTen = hoTen;
            this.nganh = nganh;
        }

        public abstract double getDiem(); // trừu tượng
        public string getHocLuc()
        {
            if (getDiem() < 5)
            {
                return "Yếu";
            }
            else if (getDiem() < 6.5)
            {
                return "Trung Bình";
            }
            else if (getDiem() < 7.5)
            {
                return "Khá";
            }
            else if (getDiem() < 9)
            {
                return "Giỏi";
            }
            else
            {
                return "Xuất sắc";
            }
        }
        public void xuat()
        {
            Console.WriteLine($"Họ tên: {this.hoTen}");
            Console.WriteLine($"Ngành: {this.nganh}");
            Console.WriteLine($"Điểm: {getDiem()}");
            Console.WriteLine($"Học lực: {getHocLuc()}");
        }
    }
    public class IT : SinhVienPoly
    {
        public IT(string hoTen, string nganh) : base(hoTen, nganh)
        {

        }
        //ghi đè phương thức trừu tượng
        public override double getDiem(){
            return 9;// điểm 9 để demo
        }
    }

    public class Program
    {
        public static void Main()
        {
            IT sv1 = new IT("Vân Quan", "IT");
            sv1.xuat();
        }
    }
}