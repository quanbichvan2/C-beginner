using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    internal class sinhVien
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
            public string? getHoTen
            {
                get { return this.hoTen; }
                set { }
            }

            public abstract double getDiem(); //trừu tượng
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
            public virtual void xuat()
            {
                Console.WriteLine($"Họ tên: {this.hoTen}");
                Console.WriteLine($"Ngành: {this.nganh}");
                Console.WriteLine($"Điểm: {getDiem()}");
                Console.WriteLine($"Học lực: {getHocLuc()}");
            }
        }
        public class sinhVienBiz : SinhVienPoly
        {
            public double diemMarketing { get; set; }
            public double diemSales { get; set; }
            //thực hiện kế thừa hoTen nganh từ SinhVienPoly
            public sinhVienBiz(string hoTen, string nganh, double diemSales, double diemMarketing) : base(hoTen, nganh)
            {
                this.diemSales = diemSales;
                this.diemMarketing = diemMarketing;
            }
            public override double getDiem()
            {
                return ((2 * diemMarketing) + diemSales) / 3;
            }
            public override void xuat()
            {
                Console.WriteLine($"\nHọ tên: {getHoTen}");
                Console.WriteLine($"Ngành: Biz");
                Console.WriteLine($"Điểm Sales: {this.diemSales}");
                Console.WriteLine($"Điểm Marketing: {this.diemMarketing}");
                Console.WriteLine($"Tổng: {getDiem()}");
                Console.WriteLine($"Học lực: {getHocLuc()}");
            }
        }
        public class sinhVienIT : SinhVienPoly
        {
            public double diemJava { get; set; }
            public double diemCss { get; set; }
            public double diemHtml { get; set; }
            //thực hiện kế thừa hoTen nganh từ SinhVienPoly
            public sinhVienIT(string hoTen, string nganh, double diemJava, double diemCss, double diemHtml) : base(hoTen, nganh)
            {
                this.diemJava = diemJava;
                this.diemCss = diemCss;
                this.diemHtml = diemHtml;
            }
            public override double getDiem()
            {
                return ((2 * diemJava) + diemHtml + diemCss) / 4;
            }
            public override void xuat()
            {
                Console.WriteLine($"\nHọ tên: {getHoTen}");
                Console.WriteLine($"Ngành: IT");
                Console.WriteLine($"Điểm Java: {this.diemJava}"); 
                Console.WriteLine($"Điểm Css: {this.diemCss}");
                Console.WriteLine($"Điểm Html: {this.diemHtml}");
                Console.WriteLine($"Tổng: {getDiem()}");
                Console.WriteLine($"Học lực: {getHocLuc()}");
            }
        }
    }
}
