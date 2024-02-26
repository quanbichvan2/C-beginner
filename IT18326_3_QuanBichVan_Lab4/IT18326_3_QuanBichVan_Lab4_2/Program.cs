
using System.Text;

namespace Product
{
    internal class SanPham
    {
        private string? name { get; set; }
        private double price { get; set; }
        private double discount { get; set; }
        public double GetincomeTax()
        {
            return Math.Round(price * 0.1, 1);
        }
        public void input()
        {
            Console.Write("Nhập tên: ");
            this.name = Console.ReadLine();
            Console.Write("Nhập giá: ");
            this.price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập giá giảm: ");
            this.discount = Convert.ToDouble(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine($"\nTên: {name}");
            Console.WriteLine($"Giá: {price}");
            Console.WriteLine($"Giảm giá: {discount}");
            Console.WriteLine($"Thuế nhập khẩu: {GetincomeTax()}");

        }
        //Sử dụng phương thức Sản Phẩm để tăng bảo mật và để nhập vào List
        public SanPham()
        {
            input();
        }
    }
}
namespace Product
{
    class Program
    {
        /*List chứa danh sách sản phẩm*/
        public static List<SanPham> listProduct = new List<SanPham>();
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 0; ; i++)
            {
                inputListProduct(i);/*Tham chiếu i vào để thân thiện với với người nhập*/

                /*Nhập liệu với số lượng sản phẩm không biết trước*/
                Console.Write("Gõ 'stop' để dừng/ Nhấn Enter nhập tiếp: ");
                if (Console.ReadLine() == "stop")
                {
                    break;
                }
            }
            for (int i = 0; i < listProduct.Count; i++)
            {
                outputListProduct(i);/*Tham chiếu i vào để thân thiện với với người đọc*/
            }
        }
        /*Hàm nhập dữ liệu vào List*/
        private static void inputListProduct(int i)
        {
            Console.WriteLine("------------------");
            Console.WriteLine($"Sản Phẩm {i + 1}");
            listProduct.Add(new SanPham());
        }
        /*Hàm xuất dữ liệu trong List ra ngoài Console*/
        private static void outputListProduct(int i)
        {
            Console.WriteLine($"Sản Phẩm {i + 1}");
            listProduct[i].output();
            Console.WriteLine("------------------");
        }
    }
}

/*
Test case:

Đậu
10000
1000

Cơm
15000
5000

Cá
20000
2000

Gà
30000
1000
stop

*/