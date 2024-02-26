using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    internal class Handing
    {
        List<HocVien> Student = new List<HocVien>();

        public void Nhap()
        {
            Console.Write("Nhập mã số sv: ");
            string id = Console.ReadLine();
            Console.Write("Nhập Họ tên: ");
            string name = Console.ReadLine();
            Console.Write("Nhập Điểm: ");
            double point = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập Email: ");
            string email = Console.ReadLine();
            HocVien sinhvien = new HocVien(id, name, email, point);
            Student.Add(sinhvien);
        }
        public void Xuat()
        {
            foreach (HocVien vien in Student)
            {
                Console.WriteLine("mã số sv: {0}", vien.getMaSV);
                Console.WriteLine("họ tên sv: {0}", vien.getHoten);
                Console.WriteLine("Email sv: {0}", vien.getEmail);
                Console.WriteLine("Điểm sv: {0}", vien.getDiem);
                Console.WriteLine("Học lực sv: {0}", Rank(vien.getDiem));
            }

        }

        public string Rank(double diem)
        {
            if (diem < 3)
            {
                return "Yếu";
            }
            else if (diem < 5)
            {
                return "Yếu";
            }
            else if (diem < 6.5)
            {
                return "Trung bình";
            }
            else if (diem < 7.5)
            {
                return "Khá";
            }
            else if (diem < 9)
            {
                return "Giỏi";
            }
            else
            {
                return"Xuất sắc";
            }
        }
        public void SreachPoint(double diem)
        {
            Console.WriteLine("\nTìm kiếm học viên theo khoảng điểm:");
            Console.Write("Nhập điểm thấp nhất: ");
            double minDiem = Convert.ToDouble(diem);
            Console.Write("Nhập điểm cao nhất: ");
            double maxDiem = Convert.ToDouble(diem);
            Console.WriteLine("\nKết quả tìm kiếm:");
            Console.WriteLine("{0,-20}{1,-10}{2,-20}{3}", "Họ và tên", "Điểm", "Email", "Học lực");
            foreach (HocVien hocVien in Student)
            {
                if (hocVien.getDiem >= minDiem && hocVien.getDiem <= maxDiem)
                {
                    Xuat();
                }
            }
        }


    }
}
