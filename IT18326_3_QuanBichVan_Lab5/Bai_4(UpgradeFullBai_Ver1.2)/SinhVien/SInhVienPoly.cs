using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        get { return hoTen; }
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
    public override string ToString()
    {
        StringBuilder stringBuilder = new ();
        stringBuilder.Append($"Họ tên: {hoTen} \n");
        stringBuilder.Append($"Ngành: {nganh} \n");
        stringBuilder.Append($"Điểm: {getDiem()} \n");
        stringBuilder.Append($"Học lực: {getHocLuc()} \n");
        return stringBuilder.ToString();
    }

}