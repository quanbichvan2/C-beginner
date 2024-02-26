using System;
using System.Text;

public class SinhVienBiz :SinhVienPoly
{
    public double diemMarketing { get; set; }
    public double diemSales { get; set; }
    //thực hiện kế thừa hoTen nganh từ SinhVienPoly
    public SinhVienBiz(string hoTen, string nganh, double diemSales, double diemMarketing) : base(hoTen, nganh)
    {
        this.diemSales = diemSales;
        this.diemMarketing = diemMarketing;
    }
    public override double getDiem()
    {
        return ((2 * diemMarketing) + diemSales) / 3;
    }
    public override string ToString()
    {
        StringBuilder stringBuilder = new();
        stringBuilder.Append($"\nHọ tên: {getHoTen} \n");
        stringBuilder.Append($"Ngành: Biz");
        stringBuilder.Append($"Điểm Sales: {this.diemSales} \n");
        stringBuilder.Append($"Điểm Marketing: {this.diemMarketing}  \n"); //Rồi điểm C# đâu
        stringBuilder.Append($"Tổng: {getDiem()}   \n");
        stringBuilder.Append($"Học lực: {getHocLuc()}   \n");
        return stringBuilder.ToString();
    }


}
