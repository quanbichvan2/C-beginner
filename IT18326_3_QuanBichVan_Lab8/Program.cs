using System.Text;

namespace Lab8
{
    class Program
    {
        
        public static void Wait()
        {
            Console.Write("Nhấn bất kì phím nào để tiếp tục");
            Console.ReadKey();
        }
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            bool isRunning = true;
            while (isRunning)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("======= MENU =======");
                Console.WriteLine("1. Quản Lý Sinh Viên");
                Console.WriteLine("2. Quản Lý Giảng Viên");
                Console.WriteLine("3. Thoát");

                Console.Write("Mời bạn chọn chức năng: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        QuanLySinhVien();
                        break;
                    case 2:
                        QuanLyGiangVien();
                        break;
                    case 3:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Mời chọn lại!");
                        Wait();
                        break;
                }
            }

            Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình!");
        }

        static void QuanLySinhVien()
        {
            Console.OutputEncoding = Encoding.UTF8;
            HandingStudent a = new HandingStudent();
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("======= QUẢN LÝ SINH VIÊN =======");
                Console.WriteLine("1. Nhập n sinh viên");
                Console.WriteLine("2. Xuất thông tin tất cả sinh viên");
                Console.WriteLine("3. Hiển thị sinh viên có điểm trung bình cao nhất và sinh viên có điểm trung bình thấp nhất");
                Console.WriteLine("4. Tìm kiếm sinh viên theo mã sinh viên");
                Console.WriteLine("5. Hiển thị tất cả sinh viên theo thứ tự tên trong bảng chữ cái từ A -> Z");
                Console.WriteLine("6. Hiển thị tất cả sinh viên nhận được học bổng");
                Console.WriteLine("7. Thoát");

                Console.Write("Mời bạn chọn chức năng: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Bạn đã chọn chức năng nhập n sinh viên.");
                        
                        a.AddStudent();
                        Wait();
                        break;
                    case 2:
                        Console.WriteLine("Bạn đã chọn chức năng xuất thông tin tất cả sinh viên.");
                        a.ShowStudent();
                        Wait(); 
                        break;
                    case 3:
                        Console.WriteLine("Bạn đã chọn chức năng hiển thị sinh viên có điểm trung bình cao nhất và sinh viên có điểm trung bình thấp nhất.");
                        a.FindMax();
                        a.FindMin();
                        Wait(); 
                        break;
                    case 4:
                        Console.WriteLine("Bạn đã chọn chức năng tìm kiếm sinh viên theo mã sinh viên.");
                        a.FindID();
                        Wait(); 
                        break;
                    case 5:
                        Console.WriteLine("Bạn đã chọn chức năng hiển thị tất cả sinh viên theo thứ tự tên trong bảng chữ cái từ A -> Z.");
                        a.SortName();
                        Wait(); 
                        break;
                    case 6:
                        Console.WriteLine("Bạn đã chọn chức năng hiển thị tất cả sinh viên nhận được học bổng.");
                        a.ListScholarship();
                        Wait(); 
                        break;
                    case 7:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Mời chọn lại!");
                        Wait(); 
                        break;
                }
            }
        }
        static void QuanLyGiangVien()
        {
            Console.OutputEncoding = Encoding.UTF8;
            HandingTeacher b = new HandingTeacher();
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("======= QUẢN LÝ GIẢNG VIÊN =======");
                Console.WriteLine("1. Nhập n giảng viên");
                Console.WriteLine("2. Xuất thông tin tất cả giảng viên");
                Console.WriteLine("3. Hiển thị giảng viên có số giờ dạy trong tháng cao nhất");
                Console.WriteLine("4. Hiển thị giảng viên có lương thực nhận cao nhất");
                Console.WriteLine("5. Thoát");

                Console.Write("Mời bạn chọn chức năng: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Bạn đã chọn chức năng nhập n giảng viên.");
                        b.AddTeacher();
                        Wait(); 
                        break;
                    case 2:
                        Console.WriteLine("Bạn đã chọn chức năng xuất thông tin tất cả giảng viên.");
                        b.ShowTeacher();
                        Wait(); 
                        break;
                    case 3:
                        Console.WriteLine("Bạn đã chọn chức năng hiển thị giảng viên có số giờ dạy trong tháng cao nhất.");
                        b.ShowMaxTeachingHours();
                        Wait(); 
                        break;
                    case 4:
                        Console.WriteLine("Bạn đã chọn chức năng Hiển thị giảng viên có lương thực nhận cao nhất.");
                        b.ShowSalaryHighest();
                        Wait(); 
                        break;
                    case 5:
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Mời chọn lại!");
                        Wait(); 
                        break;
                }
            }
        }
    }
}

/*test
quan vân
nữ
3.3.1999
432 ng van
ps287098
9
quanbichvan@gmail.com
hoàng phước
nam
30.8.1999
1234 ng van
ps286098
7
vanhoa@gmail.com
*/