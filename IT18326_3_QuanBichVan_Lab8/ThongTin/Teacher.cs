using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.ThongTin
{
    public class Teacher : Personal
    {
        public string LopDay { get; set; }
        public double LuongMotGioDay { get; set; }
        public double SoGioDayTrongThang { get; set; }

        public Teacher(string LopDay, double LuongMotGioDay, double SoGioDayTrongThang, string HoTen, string GioiTinh, string DiaChi, string NgaySinh) :
            base(HoTen, GioiTinh, DiaChi, NgaySinh)
        {
            getHoTen = HoTen;
            getNgaySinh = NgaySinh;
            getDiaChi = DiaChi;
            getGioiTinh = GioiTinh;

            //tạo lớp teacher gồm lớp dạy (phải bắt đầu bằng 1 trong các chữ G,H,I,K,L,M) 
            if (!LopDay.StartsWith("G") && !LopDay.StartsWith("H") && !LopDay.StartsWith("I") && !LopDay.StartsWith("K") && !LopDay.StartsWith("L") && !LopDay.StartsWith("M"))
            {
                throw new ArgumentException("Lớp dạy không hợp lệ.");
            }
            this.LopDay = LopDay;
            this.LuongMotGioDay = LuongMotGioDay;
            this.SoGioDayTrongThang = SoGioDayTrongThang;
        }
        // dùng base để biêt lấy lun thông tin của personal
        public Teacher() : base() { }

        // tu khai bao getter setter
        public override void InputInfo()
        {
            base.InputInfo();
            LopDay = Console.ReadLine();
            LuongMotGioDay = Convert.ToDouble(Console.ReadLine());
            SoGioDayTrongThang = Convert.ToDouble(Console.ReadLine());
        }


        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("lớp dạy là: {0}", LopDay);
            Console.WriteLine("lương một giờ dạy là: {0}", LuongMotGioDay);
            Console.WriteLine("Số giờ dạy trong tháng là: {0}", SoGioDayTrongThang);
        }

        public double TinhLuongThucNhan()
        {
            // "StartsWith" là một phương thức được sử dụng để kiểm tra xem một chuỗi có bắt đầu bằng một chuỗi khác hay không.
            if (LopDay.StartsWith("G") || LopDay.StartsWith("H") || LopDay.StartsWith("I") || LopDay.StartsWith("K"))
            {
                return LuongMotGioDay * SoGioDayTrongThang;
            }
            else if (LopDay.StartsWith("L") || LopDay.StartsWith("M"))
            {
                return LuongMotGioDay * SoGioDayTrongThang + 200000;
            }
            else
            {
                throw new ArgumentException("Lớp dạy không hợp lệ.");
            }
        }
    }
}
