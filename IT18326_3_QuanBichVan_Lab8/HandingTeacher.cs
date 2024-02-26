using Lab8.ThongTin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class HandingTeacher
    {
        List<Teacher> teachers = new List<Teacher>();
        public HandingTeacher() { }

        
        //hàm nhập
        public Teacher InputInfo()
        {
            Console.Write("Nhập Họ tên: ");
            string name = Console.ReadLine();
            Console.Write("Nhập giới tính: ");
            string sex = Console.ReadLine();
            Console.Write("Nhập ngày sinh gv: ");
            string bornDay = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            string address = Console.ReadLine();

            Console.Write("Lớp dạy phải bắt đầu bằng 1 trong các chữ G,H,I,K,L,M \nNhập lớp dạy: ");
            string id = Console.ReadLine();
            Console.Write("Nhập Lương dạy trong một giờ: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập Số giờ dạy trong 1 tháng: ");
            double teachingHours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("--------------------------------------------------------------------");
            Teacher giangVien = new Teacher(id, salary, teachingHours, name, sex, bornDay, address);
            return giangVien;
        }

        // hàm hứng trả về (quan trọng!!!)
        public void AddTeacher()
        {
            int n = 0;
            Console.WriteLine("Nhập số lượng giảng viên cần thêm: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Teacher giangVien = InputInfo();
                teachers.Add(giangVien);
            }
        }

        // xuất
        public void ShowTeacher()
        {
            foreach(Teacher item in teachers)
            {
                item.ShowInfo();
            }
        }

        public void ShowMaxTeachingHours()
        {
            Teacher highestTeachingHours = teachers[0];
            for (int i = 1; i < teachers.Count; i++)
            {
                if (teachers[i].SoGioDayTrongThang > highestTeachingHours.SoGioDayTrongThang)
                {
                    highestTeachingHours = teachers[i];
                }
            }
            Console.WriteLine("Người có điểm số cao nhất là {0} với số điêm {1}", highestTeachingHours.getHoTen, highestTeachingHours.SoGioDayTrongThang);
        }
        public void ShowSalaryHighest()
        {
            Teacher highestSalary= teachers[0];
            for(int i=1; i < teachers.Count; i++)
            {
                // TinhLuongThucNhan () 
                //Nếu bạn viết TinhLuongThucNhan (không có dấu ngoặc đơn ở cuối), thì đó không phải là cách gọi phương thức.
                //Thay vào đó, đó là tên của phương thức và bạn đang tham chiếu đến phương thức đó thay vì gọi phương thức.
                // lưu ý vì ở lớp Teacher bạn có thêm phương thức 
                if (teachers[i].TinhLuongThucNhan() > highestSalary.TinhLuongThucNhan())
                {
                    highestSalary = teachers[i];
                }
            }
            Console.WriteLine("Giáo Viên Có lương cao nhất:" +highestSalary.getHoTen);
            Console.WriteLine("- Lớp Dạy: " + highestSalary.LopDay);
            Console.WriteLine("- Lương dạy một giờ: " + highestSalary.LuongMotGioDay);
            Console.WriteLine("- Số giờ dạy trong tháng: " + highestSalary.SoGioDayTrongThang);
            Console.WriteLine("- Lương thựcc nhận: " + highestSalary.TinhLuongThucNhan());
        }

    }
}
