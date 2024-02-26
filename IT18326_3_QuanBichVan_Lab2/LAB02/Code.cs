using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB02
{
    public class Code
    {
        public static void bai_1()
        {
            double a, b;
            string kq;
            Console.WriteLine("nhap a");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("nhap b");
            b = Convert.ToInt16(Console.ReadLine());
            if (a == 0)
            { //ax+b = 0
                if (b == 0)
                {
                    kq = "pt có vô số nghiệm";
                }
                else
                {
                    kq = "pt vô nghiệm";
                }
            }
            else
            {
                kq = "pt có 1 nghiệm x= " + -b / a;
            }
            Console.WriteLine(kq);
        }



        public static void bai_2()
        {
            string kq;
            double a, b, c, del;
            Console.WriteLine("nhap a");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("nhap b");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("nhap c");
            c = Convert.ToInt16(Console.ReadLine());
            del = Math.Pow(b, 2) - 4 * a * c;
            if (del < 0)
            {
                kq = "pt vô nghiệm";
            }
            else if (del == 0)
            {
                kq = "pt có 1 nghiệm kép x= " + (float)(-b) / 2 * a;
            }
            else
            {
                kq = "pt có 2 nghiệm x= " + (-b + Math.Sqrt(del)) / 2 * a + " x= " + (-b + Math.Sqrt(del)) / 2 * a;
            }
            Console.WriteLine(kq);
        }




        public static void bai_3()
        {
            int ngay, thang, nam;
        // đặt nhãn
        Nhap_lai:
            Console.WriteLine("Nhap vao ngay:");
            ngay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao thang:");
            thang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao nam:");
            nam = Convert.ToInt32(Console.ReadLine());
            // Điều kiện nếu sai thi bắt nhập lại
            while (ngay <= 0 || ngay > 31 || thang <= 0 || thang > 12 || nam < 0)
            {
                Console.WriteLine("Nhap ngay thang nam sai, nhap lai:");
                goto Nhap_lai;
            }
            while ((ngay == 31 && thang == 2) || (ngay == 31 && thang == 4) || (ngay == 31 && thang == 6) || (ngay == 31 && thang == 9) || (ngay == 31 && thang == 11) || (ngay == 30 && thang == 2))
            {
                Console.WriteLine("Nhap sai, cac thang 2 4 6 9 11 khong co ngay 31");
                goto Nhap_lai;
            }
            // điều kiện năm nhuận và không nhuận
            // nếu năm nhuận đoạn code này sẽ chạy
            if ((nam % 400 == 0) || (nam % 4 == 0 && nam % 100 != 0))
            {
                Console.WriteLine("Nam {0} la nam nhuan", nam);
                if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
                {
                    Console.WriteLine("Thang {0} co 31 ngay", thang);
                }
                else if (thang == 2)
                {
                    Console.WriteLine("Thang {0} co 29 ngay", thang);
                }
                else
                {
                    Console.WriteLine("Thang {0} co 30 ngay", thang);
                }
                Console.WriteLine("Ngay vua nhap la {0}/{1}/{2}", ngay, thang, nam);
                Console.WriteLine("Ngay truoc do la {0}/{1}/{2}", ngay - 1, thang, nam);
                if ((ngay == 31 && thang == 1) || (ngay == 31 && thang == 3) || (ngay == 31 && thang == 5) || (ngay == 31 && thang == 7) || (ngay == 31 && thang == 8) || (ngay == 31 && thang == 10) || (ngay == 31 && thang == 12))
                {
                    Console.WriteLine("Ngay sau do la {0}/{1}/{2}", 1, thang + 1, nam);
                }
                else if ((ngay == 30 && thang == 4) || (ngay == 30 && thang == 6) || (ngay == 30 && thang == 9) || (ngay == 30 && thang == 11))
                {
                    Console.WriteLine("Ngay sau do la {0}/{1}/{2}", 1, thang + 1, nam);
                }
                else if (ngay == 29 && thang == 2)
                {
                    Console.WriteLine("Ngay sau do la {0}/{1}/{2}", 1, thang + 1, nam);
                }
                else if ((ngay < 31 && thang == 1) || (ngay < 31 && thang == 3) || (ngay < 31 && thang == 5) || (ngay < 31 && thang == 7) || (ngay < 31 && thang == 8) || (ngay < 31 && thang == 10) || (ngay < 31 && thang == 12))
                {
                    Console.WriteLine("Ngay sau do la {0}/{1}/{2}", ngay + 1, thang, nam);
                }
                else if ((ngay < 30 && thang == 4) || (ngay < 30 && thang == 6) || (ngay < 30 && thang == 9) || (ngay < 30 && thang == 11))
                {
                    Console.WriteLine("Ngay sau do la {0}/{1}/{2}", ngay + 1, thang, nam);
                }
            }
            // nếu năm không nhuận thì đoạn code dưới đây sẽ chạy
            else
            {
                Console.WriteLine("Nam {0} la nam khong nhuan", nam);
                if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
                {
                    Console.WriteLine("Thang {0} co 31 ngay", thang);
                }
                else if (thang == 2)
                {
                    Console.WriteLine("Thang {0} co 28 ngay", thang);
                }
                else
                {
                    Console.WriteLine("Thang {0} co 30 ngay", thang);
                }
                Console.WriteLine("Ngay vua nhap la {0}/{1}/{2}", ngay, thang, nam);
                Console.WriteLine("Ngay truoc do la {0}/{1}/{2}", ngay - 1, thang, nam);
                if ((ngay == 31 && thang == 1) || (ngay == 31 && thang == 3) || (ngay == 31 && thang == 5) || (ngay == 31 && thang == 7) || (ngay == 31 && thang == 8) || (ngay == 31 && thang == 10) || (ngay == 31 && thang == 12))
                {
                    Console.WriteLine("Ngay sau do la {0}/{1}/{2}", 1, thang + 1, nam);
                }
                else if ((ngay == 30 && thang == 4) || (ngay == 30 && thang == 6) || (ngay == 30 && thang == 9) || (ngay == 30 && thang == 11))
                {
                    Console.WriteLine("Ngay sau do la {0}/{1}/{2}", 1, thang + 1, nam);
                }
                else if (ngay == 28 && thang == 2)
                {
                    Console.WriteLine("Ngay sau do la {0}/{1}/{2}", 1, thang + 1, nam);
                }
                else if ((ngay < 31 && thang == 1) || (ngay < 31 && thang == 3) || (ngay < 31 && thang == 5) || (ngay < 31 && thang == 7) || (ngay < 31 && thang == 8) || (ngay < 31 && thang == 10) || (ngay < 31 && thang == 12))
                {
                    Console.WriteLine("Ngay sau do la {0}/{1}/{2}", ngay + 1, thang, nam);
                }
                else if ((ngay < 30 && thang == 4) || (ngay < 30 && thang == 6) || (ngay < 30 && thang == 9) || (ngay < 30 && thang == 11))
                {
                    Console.WriteLine("Ngay sau do la {0}/{1}/{2}", ngay + 1, thang, nam);
                }
                // trường hợp người nhập cố tình nhập ngày 29 tháng 2 trong năm không nhuận, chương trình sẽ bắt nhập lại
                while (ngay == 29 && thang == 2)
                {
                    Console.WriteLine("Thang 2 nam {0} khong co ngay 29", nam);
                    goto Nhap_lai;
                }
            }
        }




        public static void bai_4()
        {
            int x;
            int bien_dem = 0;
            Console.WriteLine("Nhap vao x:");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i < x - 1; i++)
            {
                if (x % i == 0)
                {
                    bien_dem = bien_dem + 1;
                    break;
                }
                i++;
            }
            if (bien_dem == 1)
            {
                Console.WriteLine("{0} khong phai la so nguyen to", x);
            }
            else
            {
                Console.WriteLine("{0} la so nguyen to", x);
            }
        }

        
    }
}
