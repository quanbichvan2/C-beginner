using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm2
{
    internal class Chay
    {
       static List<SinhVien> dssv = new List<SinhVien>();
        static void Main(string[] args)
        {
            //List<SinhVien> dssv = new List<SinhVien>();

            nhapDS();
            XuatDS();


           Console.ReadKey();
        }

        //nhap
         static void nhapDS()
        {
            while (true)
            {
                SinhVien x = new SinhVien();
                x.nhap();
                dssv.Add(x);

                Console.WriteLine("Nhap tiep khong ? (yes/no)");
                if (Console.ReadLine().Equals("no"))
                {
                    break;
                }
            }         
        }

        //xuat
        static void XuatDS()
        {
            foreach (var k in dssv)
            {
                k.xuat();
            }
        }
    }
}
