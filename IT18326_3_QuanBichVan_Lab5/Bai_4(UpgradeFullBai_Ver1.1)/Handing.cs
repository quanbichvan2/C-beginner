using Bai_4;
using Bai_4.SinhVien;

namespace QuanLySinhVien
{
    class Handing
    {
        private static List<SinhVienPoly> listSinhVien = new List<SinhVienPoly>();
        public static void program4()
        {
            Context.CenterWrite(17); Console.WriteLine("Chương trình số 4");
            if (listSinhVien.Count == 0)
            {
                Context.NotificationNoDataBase();
            }
            else
            {
                Console.WriteLine("\n1. Sắp xếp giảm dần\n2. Sắp xếp tăng dần\n");
                int choices = Convert.ToInt32(Console.ReadLine());

                switch (choices)
                {
                    case 1:
                        {
                            sortPointDown();
                            break;
                        }
                    case 2:
                        {
                            sortPointUp();
                            break;
                        }

                    default:
                        {
                            break;
                        }
                }
            }
            Context.Notification1();
        }
        public static void program3()
        {
            Context.CenterWrite(17); Console.WriteLine("Chương trình số 3");
            if (listSinhVien.Count == 0)
            {
                Context.NotificationNoDataBase();
            }
            else
            {
                Filterrank();
            }
            Context.Notification1();
        }
        public static void program2()
        {
            Context.CenterWrite(17); Console.WriteLine("Chương trình số 2");
            if (listSinhVien.Count == 0)
            {
                Context.NotificationNoDataBase();
            }
            else
            {
                Output();//Xuất list sinh viên
            }
            Context.Notification1();
        }
        public static void program1()
        {
            Context.CenterWrite(17); Console.WriteLine("Chương trình số 1");
            Input();//Nhập list sinh viên
            Context.Notification1();
        }
        public static void Filterrank()//Lọc xếp loại học lực
        {
            Console.WriteLine("\n1. Xuất sắc\n2. Giỏi\n3. Khá\n4. Trung bình\n5. Yếu");
            Byte rank;
            do
            {
                try
                {
                    Context.CenterWrite(6); Console.Write("Nhập: ");
                    rank = Convert.ToByte(Console.ReadLine());
                }
                catch (Exception)
                {
                    rank = 6;
                }
            }
            while (rank > 5);

            listSinhVien.ForEach(i =>
            {
                switch (rank)
                {
                    case 1:
                        if (i.getHocLuc().Contains("Xuất sắc"))
                        {
                            i.xuat();
                            Console.WriteLine("--------------------------------------------------");
                        }
                        break;
                    case 2:
                        if (i.getHocLuc().Contains("Giỏi"))
                        {
                            i.xuat();
                            Console.WriteLine("--------------------------------------------------");
                        }
                        break;
                    case 3:
                        if (i.getHocLuc().Contains("Khá"))
                        {
                            i.xuat();
                            Console.WriteLine("--------------------------------------------------");
                        }
                        break;
                    case 4:
                        if (i.getHocLuc().Contains("Trung Bình"))
                        {
                            i.xuat();
                            Console.WriteLine("--------------------------------------------------");
                        }
                        break;
                    case 5:
                        if (i.getHocLuc().Contains("Yếu"))
                        {
                            i.xuat();
                            Console.WriteLine("--------------------------------------------------");
                        }
                        break;
                    default:
                        break;
                }

            });

        }

        public static void sortPointUp()
        {
            listSinhVien.Sort((a, b) => a.getDiem() > b.getDiem() ? 1 : -1);
            Context.CenterWrite(45); Console.WriteLine("Danh sách sinh viên tăng dần sắp xếp hoàn tất");
        }
        public static void sortPointDown()
        {
            listSinhVien.Sort((a, b) => a.getDiem() < b.getDiem() ? 1 : -1);
            Context.CenterWrite(45); Console.WriteLine("Danh sách sinh viên giảm dần sắp xếp hoàn tất");
        }

        public static void Input()
        {
            for (int i = 0; ; i++)
            {
                SinhVienPoly sv;
                Console.WriteLine("Chọn ngành sinh viên: ");
                Console.WriteLine("1: SinhVienBiz ");
                Console.WriteLine("2: SinhVienIT ");
                int type =  Convert.ToByte(Console.ReadLine());
                switch(type)
                {
                    case 1:
                        Console.WriteLine("Nhập thông tin sinh viên BIZ");
                        Console.Write("Tên: ");
                        string nameBiz = Console.ReadLine();
                        Console.Write("Điểm sales: ");
                        double sales = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Điểm marketing: ");
                        double mkt = Convert.ToDouble(Console.ReadLine());
                        sv = new SinhVienBiz(nameBiz, "Biz", sales, mkt);
                        listSinhVien.Add(sv);
                        break;
                    case 2:
                        Console.WriteLine("Nhập thông tin sinh viên IT");
                        Console.Write("Tên: ");
                        string nameIT = Console.ReadLine();
                        Console.Write("Điểm Java: ");
                        double java = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Điểm Css: ");
                        double css = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Điểm Html: ");
                        double html = Convert.ToDouble(Console.ReadLine());
                        sv = new SinhVienIT(nameIT, "IT", java, css, html);
                        listSinhVien.Add(sv);
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
                Console.Write("Bạn có muốn nhập tiếp không?  (y/n): ");
                string? n = Console.ReadLine();
                if (n == "n" || n == "N")
                {
                    break;
                }
            }
        }
        public static void Output()//xuất ra danh sách sinh viên
        {
            listSinhVien.ForEach(i =>
            {
                i.xuat();
                Console.WriteLine("--------------------------------------------------");
            });
        }
    }
}