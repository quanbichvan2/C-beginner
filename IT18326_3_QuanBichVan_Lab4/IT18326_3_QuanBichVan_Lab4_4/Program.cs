
using System.Text;

namespace Product
{
    internal class SanPham
    {
        private string? name { get; set; }
        private double price { get; set; }
        private double discount { get; set; }
        private double GetincomeTax()
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
        /*Hàm tạo 3 tham trị*/
        public SanPham(String? name, double price, double discount)
        {
            /*3 kiểu dữ liệu trong class phải 'non-static' mới dùng được 'this.'*/
            getName = name;
            getPrice = price;
            getDiscount = discount;
        }
        /*Hàm tạo 2 tham trị*/

        public SanPham(String? name, double price)
        {
            getName = name;
            getPrice = price;
        }

        public string? getName
        {
            get { return name; }
            set { this.name = value; }
        }
        public double getPrice
        {
            get { return price; }
            set
            {
                /*Nếu có người cố để giá sản phẩm < 0 thì bỏ giá trị*/
                if (value < 0)
                {
                    this.price = 0;
                }
                else
                {
                    this.price = value;
                }
            }
        }
        public double getDiscount
        {
            get { return discount; }
            set
            {
                /*
                Bởi vì đời đâu ai cho không nhau thứ gì
                Nhập về tốn tiền thuế rồi còn cho không nữa 
                Sống bằng gì?
                */
                if (value == this.price)
                {
                    this.discount = this.price * 0.9;
                }
                else if (this.price == 0)
                {
                    this.discount = 0;
                }
                else
                {
                    this.discount = value;
                }
            }
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
            /*Khởi tạo 4 sản phẩm*/
            inputListProduct();
            /*Xuất ra 4 sản phẩm*/
            outputListProduct();
        }
        /*Hàm input giá trị của 4 sản phẩm vào list*/
        private static void inputListProduct()
        {
            listProduct.Add(new SanPham("Bánh bao chay", 15000));
            listProduct.Add(new SanPham("Bánh bao chiên", 8000));
            listProduct.Add(new SanPham("Bánh Mỳ", -10000, 2000)); //test trường hợp sản phẩm âm tiền hay còn gọi là đồ free 
            listProduct.Add(new SanPham("Bánh thập cẩm", 15000, 15000));
        }

        /*Hàm xuất giá trị của 4 sản phẩm từ list ra Console*/
        private static void outputListProduct()
        {
            for (int i = 0; i < listProduct.Count; i++)
            {
                SanPham sp = listProduct[i];
                Console.WriteLine($"Sản phẩm {i + 1}");
                sp.output();
                Console.WriteLine("------------------");
            }
        }
    }
}

/*
Test case:
    
    
*/