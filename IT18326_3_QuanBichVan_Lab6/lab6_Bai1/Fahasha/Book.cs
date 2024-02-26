using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Book : IBook
{
    public string? tenSach { get; set; }
    public string? tenTacGia { get; set; }
    public string? nhaSanXuat { get; set; }
    public int namXuatBan { get; set; }
    public string? isbn { get; set; }
    public string? danhMuc { get; set; }

    public void Nhap()
    {
        Console.Write("Nhập tên sách: ");
        tenSach= Console.ReadLine();
        Console.Write   ("Nhập tên tác giả: ");
        tenTacGia= Console.ReadLine();
        Console.Write("Nhập tên nhà sản xuất: ");
        nhaSanXuat= Console.ReadLine();
        Console.Write("Nhập tên năm xuất bản: ");
        namXuatBan = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập tên isbn: ");
        isbn = Console.ReadLine();
        Console.Write("Nhập tên danh mục: ");
        danhMuc = Console.ReadLine();
        Console.WriteLine("-----------------------------");
    }

    public void Xuat()
    {
        Console.WriteLine("tên sách là: " + this.tenSach);
        Console.WriteLine("tên tác giả là: " + this.tenTacGia);
        Console.WriteLine("nhà sản xuất là: " + this.nhaSanXuat);
        Console.WriteLine("năm xuất bản là: " + this.namXuatBan);
        Console.WriteLine("mã isbn là: " + this.isbn);
        Console.WriteLine("danh mục là: " + this.danhMuc);
        Console.WriteLine("------------------------------");
    }

}

