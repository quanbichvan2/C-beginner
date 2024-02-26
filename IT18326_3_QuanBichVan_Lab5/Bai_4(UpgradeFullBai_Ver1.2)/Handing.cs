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
                string choices = Console.ReadLine();
                switch (choices)
                {
                    case "1":
                        {
                            sortPointDown();
                            break;
                        }
                    case "2":
                        {
                            sortPointUp();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Error");
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
                        if (i.getDiem()>9)
                        {
                            Console.WriteLine(i.ToString());
                            Console.WriteLine("--------------------------------------------------");
                        }
                        break;
                    case 2:
                        if (i.getDiem() < 9)
                        {
                            Console.WriteLine(i.ToString());
                            Console.WriteLine("--------------------------------------------------");
                        }
                        break;
                    case 3:
                        if (i.getDiem() < 7.5)
                        {
                            Console.WriteLine(i.ToString());
                            Console.WriteLine("--------------------------------------------------");
                        }
                        break;
                    case 4:
                        if (i.getDiem() < 6.5)
                        {
                            Console.WriteLine(i.ToString());
                            Console.WriteLine("--------------------------------------------------");
                        }
                        break;
                    case 5:
                        if (i.getDiem() < 5)
                        {
                            Console.WriteLine(i.ToString());
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
                Console.Write("Chose type student 1: SinhVienBiz; 2: SinhVienIT: ");
                int type =  Convert.ToByte(Console.ReadLine());
                switch(type)
                {
                    case 1:
                        Console.WriteLine("Nhap thong tin sinh vien biz");
                        Console.Write("Name: ");
                        string nameBiz = Console.ReadLine();
                        Console.Write("sales: ");
                        double sales = Convert.ToDouble(Console.ReadLine());
                        Console.Write("mkt: ");
                        double mkt = Convert.ToDouble(Console.ReadLine());
                        sv = new SinhVienBiz(nameBiz, "Biz", sales, mkt);
                        listSinhVien.Add(sv);
                        break;
                    case 2:
                        Console.WriteLine("Nhap thong tin sinh vien it");
                        Console.Write("Name: ");
                        string nameIT = Console.ReadLine();
                        Console.Write("java: ");
                        double java = Convert.ToDouble(Console.ReadLine());
                        Console.Write("css: ");
                        double css = Convert.ToDouble(Console.ReadLine());
                        Console.Write("html: ");
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
                //i.xuat();
                Console.WriteLine(i.ToString());
                Console.WriteLine("--------------------------------------------------");
            });
        }
    }
}