using System.Text;

namespace Lab_5
{
   
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            sinhVien.sinhVienIT sv1 = new sinhVien.sinhVienIT("Hoàng Trần", "IT", 7, 5, 10);
            sv1.xuat();
            sinhVien.sinhVienBiz sv2 = new sinhVien.sinhVienBiz("Vân Quan", "Biz", 4, 10);
            sv2.xuat();
        }
    }
}