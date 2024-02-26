using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
public interface IBook
{
    String? tenSach { get; set; }
    String? tenTacGia { get; set; }
    String? nhaSanXuat { get; set; }
    int namXuatBan { get; set; }
    string? isbn { get; set; }
    string? danhMuc { get; set; }

    void Nhap();
    void Xuat();
}

