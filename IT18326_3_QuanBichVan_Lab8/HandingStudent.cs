using Lab8.ThongTin;

namespace Lab8
{
    public class HandingStudent
    {
        List<Student> students = new List<Student>();

        public HandingStudent()
        {

        }

        bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
        public Student InputInfo()
        {
            Console.Write("Nhập Họ tên: ");
            string name = Console.ReadLine();
            Console.Write("Nhập giới tính: ");
            string sex = Console.ReadLine();
            Console.Write("Nhập ngày sinh sv: ");
            string bornDay = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            string address = Console.ReadLine();

            Console.Write("Nhập mã số sinh viên: ");
            string id = Console.ReadLine();
            while (id.Length != 8)
            {
                Console.Write("Nhập lại mã số sinh viên chứa 8 ký tự: ");
                id = Console.ReadLine();
            }
            Console.Write("Nhập điểm: ");
            double point = Convert.ToDouble(Console.ReadLine());
            while (point < 0 && point > 10)
            {
                Console.Write("Nhập lại điểm từ 0 đến 10: ");
                point = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("Nhập email: ");
            string email = Console.ReadLine();
            while (IsValidEmail(email) == false)
            {
                Console.Write("Nhập lại email có @ và ko có ký tự khoảng trắng: ");
                email = Console.ReadLine();
            }
            Console.WriteLine("--------------------------------------------------------------------");
            Student sinhvien = new Student(id, point, email, name, sex, address, bornDay);
            return sinhvien;
        }

        // ghi như vậy đúng chuẩn, còn showInfo trong class student có sẵn thì thực tế nó bị thừa.(Viết theo đề bài yêu cầu override)
        //public void ShowInfo(Student sinhvien)
        //{
        //    Console.WriteLine("họ tên sv: {0}", sinhvien.getHoTen);
        //    Console.WriteLine("ngày sinh sv: {0}", sinhvien.getNgaySinh);
        //    Console.WriteLine("giới tính sv: {0}", sinhvien.getGioiTinh);
        //    Console.WriteLine("Địa chỉ sv: {0}", sinhvien.getDiaChi);
        //    Console.WriteLine("mã sv: {0}", sinhvien.MSV);
        //    Console.WriteLine("điểm sv: {0}", sinhvien.Diem);
        //    Console.WriteLine("email sv: {0}", sinhvien.Email);
        //}
        public void scholarShip(Student sinhvien)
        {
            // dòng if dưới là true (if của bool ko nhất thiết == với True), nếu muốn nó false thì dùng ! trước tên hàm (ví dụ: !CheckReward) 
            if (CheckReward(sinhvien.Diem))
            {
                Console.WriteLine("sinh viên {0} nhận được học bổng", sinhvien.getHoTen);
            }
            else
            {
                Console.WriteLine("sinh viên {0} không nhận được học bổng", sinhvien.getHoTen);
            }
        }

        public bool CheckReward(double point)
        {
            return point > 8 ? true : false; ;
        }
        public void AddStudent()
        {
            int n = 0;
            Console.WriteLine("Nhập số lượng sv: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Student sinhvien = InputInfo();
                students.Add(sinhvien);
            }
        }

        public void ShowStudent()
        {
            foreach (Student item in students)
            {
                item.ShowInfo();
            }
        }
        public void FindMax()
        {
            Student highestScoreStudent = students[0];
            for (int i = 1; i < students.Count; i++)
            {
                if (students[i].Diem > highestScoreStudent.Diem)
                {
                    highestScoreStudent = students[i];
                }
            }
            Console.WriteLine("Người có điểm số cao nhất là {0} với số điêm {1}", highestScoreStudent.getHoTen, highestScoreStudent.Diem);
        }

        public void FindMin()
        {
            Student lowestScoreStudent = students[0];
            for (int i = 1; i < students.Count; i++)
            {
                if (students[i].Diem < lowestScoreStudent.Diem)
                {
                    lowestScoreStudent = students[i];
                }
            }
            Console.WriteLine("Người có điểm số thấp nhất là {0} với số điêm {1}", lowestScoreStudent.getHoTen, lowestScoreStudent.Diem);
        }
        public void FindID()
        {
            Console.WriteLine("Nhập mã SV cần tìm: ");
            string name = Console.ReadLine();
            bool flag = false;
            foreach (Student student in students)
            {
                if (student.MSV.Equals(name))
                {
                    student.ShowInfo();
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Không có SV nào có mã là {0}", name);
            }
        }
        public void SortName()
        {
            students.Sort(delegate (Student x, Student y)
                {
                    int result = x.getHoTen.CompareTo(y.getHoTen);
                    return result;
                }
            );
            foreach (Student item in students)
            {
                item.ShowInfo();
            }
        }
        public void ListScholarship()
        {
            List<Student> temp = new List<Student>(); //danh sách này chỉ chứa những sinh viên có phần thưởng
            foreach (Student item in students)
            {
                if (CheckReward(item.Diem))
                {
                    temp.Add(item);
                }
            }
            temp.Sort(delegate (Student x, Student y)
                {
                    // so sánh toán tử 3 ngôi
                    int result = x.Diem < y.Diem ? 1 : -1;
                    return result;
                }
            );

            foreach (Student item in temp)
            {
                item.ShowInfo();
            }
        }


    }
}
