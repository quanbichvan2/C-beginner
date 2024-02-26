using System.Text;

namespace Product
{
    /*Đối tượng sản phẩm*/
    internal class SanPham
    {
        private static string? name { get; set; }/*Tên sản phẩm*/
        private static double price { get; set; }/*Giá sản phẩm*/
        private static double discount { get; set; }/*Giảm giá*/

        /*Hàm trả về về giá trị thuế*/
        private static double GetincomeTax()
        {
            return Math.Round(price * 0.1, 1);
        }

        /*Nhập dữ liệu vào class Sản Phẩm */
        public void input()
        {
            Console.Write("Nhập tên: ");
            name = Console.ReadLine();
            Console.Write("Nhập giá: ");
            price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập giá giảm: ");
            discount = Convert.ToDouble(Console.ReadLine());
        }

        /*Xuất dữ liệu trong class Sản Phẩm */
        public void output()
        {
            Console.WriteLine($"\nTên: {name}");
            Console.WriteLine($"Giá: {price}");
            Console.WriteLine($"Giảm giá: {discount}");
            Console.WriteLine($"Thuế nhập khẩu: {GetincomeTax()}");

        }
    }
}

/*Chương trình chính phải chung vùng Product với class SanPham*/
namespace Product
{
    /*Chương trình chạy ở đây*/
    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            SanPham Sp = new SanPham();/*Khởi tạo Sản Phẩm */
            Sp.input();/*Nhập sản phầm*/
            Sp.output();/*Xuất sản phẩm*/
        }

    }
}

/*
Test case:

Dau
10000
1000

*/