using System;


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
    public override void xuat()
    {
        Console.WriteLine($"\nHọ tên: {getHoTen}");
        Console.WriteLine($"Ngành: Biz");
        Console.WriteLine($"Điểm Sales: {this.diemSales}");
        Console.WriteLine($"Điểm Marketing: {this.diemMarketing}"); //Rồi điểm C# đâu
        Console.WriteLine($"Tổng: {getDiem()}");
        Console.WriteLine($"Học lực: {getHocLuc()}");
    }


}
