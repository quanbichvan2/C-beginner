using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4.SinhVien
{
    internal class SinhVienIT : SinhVienPoly
    {
        public double diemJava { get; set; }
        public double diemCss { get; set; }
        public double diemHtml { get; set; }
        //thực hiện kế thừa hoTen nganh từ SinhVienPoly
        public SinhVienIT(string hoTen, string nganh, double diemJava, double diemCss, double diemHtml) : base(hoTen, nganh)
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
            Console.WriteLine($"Điểm Java: {this.diemJava}"); //Rồi điểm C# đâu
            Console.WriteLine($"Điểm Css: {this.diemCss}");
            Console.WriteLine($"Điểm Html: {this.diemHtml}");
            Console.WriteLine($"Tổng: {getDiem()}");
            Console.WriteLine($"Học lực: {getHocLuc()}");
        }
    }
    
}
