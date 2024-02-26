using Lab8.ThongTin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// tạo abstract để có tính trừu tượng , mún đa hình có a
public abstract class Personal : IPerson
{
    // dùng field là một trường thông tin, những thông tin này phải giấu đi. 
    // properties là những thuộc tính mình mún ngta lấy ra
    private string HoTen;
    private string GioiTinh;
    private string DiaChi;
    private string NgaySinh;

    // lấy field ra get set
    public string getHoTen
    {
        get { return HoTen; }
        set { HoTen = value; }
    }
    public string getGioiTinh
    {
        get { return GioiTinh; }
        set { GioiTinh = value; }
    }
    public string getNgaySinh
    {
        get { return NgaySinh; }
        set { NgaySinh = value; }
    }
    public string getDiaChi
    {
        get { return DiaChi; }
        set { DiaChi = value; }
    }
    //constructor ko tham số
    public Personal()
    {

    }

    //constructor đầy đủ tham số
    public Personal(string NgaySinh, string HoTen, string GioiTinh, string DiaChi)
    {
        //gán ngày sinh (được truyền từ parameter) vào 1 thuộc tính của lớp  
        this.NgaySinh = NgaySinh;
        this.HoTen = HoTen;
        this.GioiTinh = GioiTinh;
        this.DiaChi = DiaChi;
    }


    public virtual void InputInfo()
    {
        NgaySinh = Console.ReadLine();
        HoTen = Console.ReadLine();
        GioiTinh = Console.ReadLine();
        DiaChi = Console.ReadLine();
    }

    public virtual void ShowInfo()
    {   
        Console.WriteLine("Địa chỉ là: {0}",DiaChi);
        Console.WriteLine("Họ và tên: {0}",HoTen);
        Console.WriteLine("ngày tháng năm sinh: {0}",NgaySinh);
        Console.WriteLine("Giới tính là: {0}",GioiTinh);
        
    }
}


