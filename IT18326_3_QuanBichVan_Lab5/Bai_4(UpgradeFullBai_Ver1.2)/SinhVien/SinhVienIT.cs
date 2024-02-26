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
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"Họ tên: {getHoTen}   \n");
            stringBuilder.Append($"Ngành: IT");
            stringBuilder.Append($"Điểm Java: {diemJava}   \n"); //Rồi điểm C# đâu
            stringBuilder.Append($"Điểm Css: {diemCss}   \n");
            stringBuilder.Append($"Điểm Html: {diemHtml}  \n");
            stringBuilder.Append($"Tổng: {getDiem()}  \n");
            stringBuilder.Append($"Học lực: {getHocLuc()} \n");
            return stringBuilder.ToString();
        }
    }

}
