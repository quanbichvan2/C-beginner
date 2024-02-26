using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2
{
    internal class SinhVien
    {
        public string hoTen { get; set; }
        public double diem { get; set; }
        public string email { get; set; }

        public string ketQua() //tinh hoc luc
        {
            if (diem >=5 )
            {
                return "dau";
            }
            else { return "rot"; }
        }


        public void nhap()
        {
            Console.WriteLine("Nhap ho ten");
            hoTen = Console.ReadLine();
            Console.WriteLine("Nhap diem");
            diem = Convert.ToDouble(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine(hoTen+"    "+diem+"    "+ketQua());
        }


        
        //public string hoTen { get; set; }
        //private string hoTen;

        //public string HoTen { get => hoTen; set => hoTen = value; }
        //public string HoTen { get => hoTen; set { Console.WriteLine("Vua nhap roi do"); } }

    }
}
