using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Handing
    {
        static List<Book> danhSach = new List<Book>();
        public static void NhapMang()
        {
            Context.CenterWrite(17); Console.WriteLine("Chương trình số 1");
            int n = 0;
            Console.WriteLine("nhập số lượng sách cần thêm: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Book sachMoi = new Book();
                sachMoi.Nhap();
                danhSach.Add(sachMoi);
            }
            Context.Notification1();
        }
        public static void XuatMang()
        {
            Context.CenterWrite(17); Console.WriteLine("Chương trình số 2");
            if (danhSach.Count == 0)
            {
                Context.NotificationError();
            }
            else
            {
                for (int i = 0; i < danhSach.Count; i++) // .count là số lượng thành phần trong mảng 
                {
                    danhSach[i].Xuat(); // in danh sách
                }
            }
            Context.Notification1();
        }
        public static void Program3()
        {
            if (danhSach.Count == 0)
            {
                Context.NotificationError();
            }
            else
            {
                Console.WriteLine("\n1. Sắp xếp theo tên tác giả \n2. Sắp xếp theo tên sách \n3. Sắp xếp theo năm xuất bản");
                string choices = Console.ReadLine();
                switch (choices)
                {
                    case "1":
                        {
                            SapXepTenTacGia();
                            break;
                        }
                    case "2":
                        {
                            SapXepTenSach();
                            break;
                        }
                    case "3":
                        {
                            SapXepNamXuatBan();
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
        public static void SapXepTenTacGia()
        {
            IComparer<Book> comparer = new MyCompare();
            danhSach.Sort(comparer);
            //0 1 -1    
            //xuatMang();
            //for (int i = 0; i < danhSach.Count; i++)
            //{
            //    for (int j = 1; j < danhSach.Count-1; j++)
            //    {
            //        int result = danhSach[i].tenTacGia.CompareTo(danhSach[j]);
            //        if (result == 1)
            //        {
            //            Book tmp;
            //            tmp = danhSach[i];
            //            danhSach[i] = danhSach[j];
            //            danhSach[j] = tmp;
            //        }
            //        else
            //        {
            //            continue;
            //        }
                  
            //    }
                
            //}

        }
        public static void SapXepTenSach()
        {
            danhSach.Sort(
                // delegate tức là ủy quyền, phân quyền cho 1 hàm do mình định nghĩa. (only in c#)
                // dùng delegate thì không cần phải thêm add class Mycompare
                // lợi ích không tốn bộ nhớ vào những hàm con nhỏ (ví dụ từ khóa new)
                delegate (Book x, Book y)
                {
                    int result = x.tenSach.CompareTo(y.tenSach);
                    if (result == 0)
                        result = x.tenTacGia.CompareTo(y.tenTacGia);

                    if (result == 0)
                        result = x.namXuatBan.CompareTo(y.namXuatBan);

                    return result;
                }
            );
            XuatMang();
        }

        public static void SapXepNamXuatBan()
        {
            // linq ban đầu sắp xếp theo năm xuất bản -> if năm xuất bản = nhau thì sắp xếp theo tên tác giả
            // -> if tên tác giả bằng nhau thì sắp xếp tiếp theo nhà sản xuất
            // linq biến cái danh sách thành 1 cái bảng trong SQL, sau đó thực hiện thao tác với dữ liệu như là các câu lệnh trong SQL (linq only in c#)
            danhSach = danhSach.OrderBy(x=>x.namXuatBan).ThenBy(x=>x.tenTacGia).ThenBy(x=>x.nhaSanXuat).ToList();
            XuatMang();
        }


    }
}
