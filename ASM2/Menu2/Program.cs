using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu2
{
    internal class Program
    {
        public int n;
        public string[] maSV, hoTen, eMail;
        public double[] diem;
        public double diemMin, diemMax;
        public char hocLuc;
        public string nhapMaSV;
        public void menu()
        {
            int luaChon;

            do
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Chọn 1: Thực hiện chức năng 1 ");
                Console.WriteLine("Chọn 2: Thực hiện chức năng 2 ");
                Console.WriteLine("Chọn 3: Thực hiện chức năng 3 ");
                Console.WriteLine("Chọn 4: Thực hiện chức năng 4 ");
                Console.WriteLine("Chọn 5: Thực hiện chức năng 5 ");
                Console.WriteLine("Chọn 6: Thực hiện chức năng 6 ");
                Console.WriteLine("Chọn 7: Thực hiện chức năng 7 ");
                Console.WriteLine("Chọn 8: Thực hiện chức năng 8 ");
                Console.WriteLine("Chọn 9: Thực hiện chức năng 9 ");
                Console.WriteLine("Chọn 10: Thực hiện chức năng 10 ");
                Console.WriteLine("Chọn 0 Để thoát ");
                Console.WriteLine("------------------------------");

                Console.Write("Mời chọn: ");
                luaChon = Convert.ToInt32(Console.ReadLine());
                switch (luaChon)
                {
                    case 1:
                        Nhap();
                        break;
                    case 2:
                        Xuat();
                        break;
                    case 3:
                        timKiemDiem();
                        break;
                    case 4:
                        timHocLuc();
                        break;
                    case 5:
                        timMaSo();
                        break;
                    case 6:
                        sapXepDiem();
                        break;
                    case 7:
                        xuatDiemMax();
                        break;
                    case 8:
                        diemTB();
                        break;
                    case 9:
                        xuatHVTrenTB();
                        break;
                    case 10:
                        tongSoHV();
                        break;
                    case 0:
                        Console.WriteLine("Tạm biệt");
                        //Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Mời bạn chọn lại!");
                        break;
                }
                Console.ReadKey();
            } while (luaChon != 0);
        }

        public void Nhap() //nhập mảng sinh viên
        {
            Console.WriteLine("Chức năng 1");
            Console.WriteLine("Nhập danh sách học viên");
            Console.WriteLine("========================");
            Console.Write("Mời bạn nhập số sinh viên: ");
            n = Convert.ToInt32(Console.ReadLine());
            maSV = new string[n];
            hoTen = new string[n];
            eMail = new string[n];
            diem = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Mã số sinh viên: ");
                maSV[i] = Console.ReadLine();

                Console.Write("Họ và tên: ");
                hoTen[i] = Console.ReadLine();

                Console.Write("Điểm: ");
                diem[i] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Email: ");
                eMail[i] = Console.ReadLine();
            }

        }
        public void Xuat() //xuất mảng sinh viên
        {
            Console.WriteLine("Chức năng 2");
            Console.WriteLine("Xuất danh sách học viên");
            Console.WriteLine("========================");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Mã số sinh viên: " + maSV[i]);
                Console.WriteLine("Họ và tên: " + hoTen[i]);
                Console.WriteLine("Điểm: " + diem[i]);
                Console.WriteLine("Email: " + eMail[i]);
                if (diem[i] < 3)
                {
                    Console.WriteLine("Yếu");
                }
                else if (diem[i] < 5)
                {
                    Console.WriteLine("Yếu");
                }
                else if (diem[i] < 6.5)
                {
                    Console.WriteLine("Trung bình");
                }
                else if (diem[i] < 7.5)
                {
                    Console.WriteLine("Khá");
                }
                else if (diem[i] < 9)
                {
                    Console.WriteLine("Giỏi");
                }
                else
                {
                    Console.WriteLine("Xuất sắc");
                }
            }
        }
        public void timKiemDiem()
        {
            Console.WriteLine("Chức năng 3");
            Console.WriteLine("Tìm kiếm học viên theo khoảng điểm");
            Console.WriteLine("========================");
            Console.WriteLine("Nhập điểm thấp nhất: ");
            diemMin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập điểm cao nhất: ");
            diemMax = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (diemMin <= diem[i] && diem[i] <= diemMax)
                {
                    Console.WriteLine("Họ và tên: " + hoTen[i]);
                    Console.WriteLine("Điểm: " + diem[i]);
                }
            }
        }
        public void timHocLuc()
        {
            Console.WriteLine("Chức năng 4");
            Console.WriteLine("Tìm kiếm học viên theo học lực");
            Console.WriteLine("========================");
            hocLuc = Console.ReadKey().KeyChar;
            switch (hocLuc)
            {
                case 'a': //kém
                    for (int i = 0; i < n; i++)
                    {
                        if (diem[i] < 3)
                        {
                            Console.WriteLine("Họ và tên " + hoTen[i]);
                        }
                    }
                    break;
                case 'b': //yếu
                    for (int i = 0; i < n; i++)
                    {
                        if (diem[i] < 5)
                        {
                            Console.WriteLine("Họ và tên " + hoTen[i]);
                        }
                    }
                    break;
                case 'c': //trung bình
                    for (int i = 0; i < n; i++)
                    {
                        if (diem[i] < 6.5)
                        {
                            Console.WriteLine("Họ và tên " + hoTen[i]);
                        }
                    }
                    break;
                case 'd': // khá
                    for (int i = 0; i < n; i++)
                    {
                        if (diem[i] < 7.5)
                        {
                            Console.WriteLine("Họ và tên " + hoTen[i]);
                        }
                    }
                    break;
                case 'e': // giỏi, xuất sắc
                    for (int i = 0; i < n; i++)
                    {
                        if (diem[i] < 9)
                        {
                            Console.WriteLine("Họ và tên " + hoTen[i]);
                        }
                    }
                    break;
            }
        }
        public void timMaSo()
        {
            Console.WriteLine("Chức năng 5");
            Console.WriteLine("Tìm học viên theo mã số và cập nhật thông tin học viên");
            Console.WriteLine("========================");
            Console.WriteLine("Mời bạn nhập mã sinh viên: ");
            nhapMaSV = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                //if(maSV[i]==nhapMaSV)
                if (maSV[i].Equals(nhapMaSV))
                {
                    Console.WriteLine("Thông tin cũ:");
                    Console.WriteLine("Họ và tên: " + hoTen[i]);
                    Console.WriteLine("Điểm: " + diem[i]);
                    Console.WriteLine("Cập nhật họ tên");
                    hoTen[i] = Console.ReadLine();
                    Console.WriteLine("Cập nhật điểm");
                    diem[i] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Cập nhật email");
                    eMail[i] = Console.ReadLine();
                }
            }
        }
        public void sapXepDiem()
        {
            Console.WriteLine("Chức năng 6");
            Console.WriteLine("Sắp xếp học viên theo điểm");
            Console.WriteLine("========================");
            for (int i = 0; i < n; i++)//đưa ra 1 người
            {
                for (int j = 0; i < n - 1; j++)//đưa ra 1 người
                {
                    if (diem[j] < diem[j + 1])
                    {
                        double diemTam = diem[j];
                        diem[j] = diem[j + 1];
                        diem[j + 1] = diemTam;

                        string hotenTam = hoTen[j];
                        hoTen[j] = hoTen[j + 1];
                        hoTen[j + 1] = hotenTam;
                    }

                }
            }
        }
        public void xuatDiemMax()
        {
            Console.WriteLine("Chức năng 7");
            Console.WriteLine("Xuất 5 học viên có điểm cao nhất");
            Console.WriteLine("========================");
            sapXepDiem();
            if (n > 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Mã số sinh viên: " + maSV[i]);
                    Console.WriteLine("Họ và tên: " + hoTen[i]);
                    Console.WriteLine("Điểm: " + diem[i]);
                    Console.WriteLine("Email: " + eMail[i]);
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Mã số sinh viên: " + maSV[i]);
                    Console.WriteLine("Họ và tên: " + hoTen[i]);
                    Console.WriteLine("Điểm: " + diem[i]);
                    Console.WriteLine("Email: " + eMail[i]);
                }
            }
        }
        public void diemTB()
        {
            double tongDiem = 0;
            double dtb = 0;
            Console.WriteLine("Chức năng 8");
            Console.WriteLine("Tính điểm trung bình của lớp");
            Console.WriteLine("========================");
            for (int i = 0; i < n; i++)
            {
                tongDiem = tongDiem + diem[i];
            }
            dtb = tongDiem / n;
            Console.WriteLine("Điểm trung bình lớp là: " + dtb);
        }
        public void xuatHVTrenTB()
        {
            Console.WriteLine("Chức năng 9");
            Console.WriteLine("Xuất danh sách học viên có điểm trên điểm trung bình của lớp");
            Console.WriteLine("========================");
            for (int i = 0; i < n; i++)
            {
                if (diem[i] > 5)
                {
                    Console.WriteLine("Mã số sinh viên: " + maSV[i]);
                    Console.WriteLine("Họ và tên: " + hoTen[i]);
                    Console.WriteLine("Điểm: " + diem[i]);
                    Console.WriteLine("Email: " + eMail[i]);
                }
            }
        }
        public void tongSoHV()
        {
            Console.WriteLine("Chức năng 10");
            Console.WriteLine("Tổng hợp số học viên theo học lực");
            Console.WriteLine("========================");
            for (int i = 0; i < n; i++)
            {
                //int demBeHon3 = 0;
                //int demBeHon5 = 0;
                //int demBeHon65 = 0;
                //int demBeHon75 = 0;
                //int demBeHon9 = 0;
                //int demLonHon9 = 0;
                if (diem[i] < 3)
                {
                    //demBeHon3 += 1;
                    //Console.WriteLine("Có {0} sinh viên có điểm bé hơn 3!", demBeHon3);
                    Console.WriteLine("Học lực kém!");
                    Console.WriteLine("Mã số sinh viên: " + maSV[i]);
                    Console.WriteLine("Họ và tên: " + hoTen[i]);
                    Console.WriteLine("Điểm: " + diem[i]);
                    Console.WriteLine("Email: " + eMail[i]);
                }
                else if (diem[i] < 5)
                {
                    //demBeHon3 += 1;
                    //Console.WriteLine("Có {0} sinh viên có điểm bé hơn 5!", demBeHon5);
                    Console.WriteLine("Học lực yếu!");
                    Console.WriteLine("Mã số sinh viên: " + maSV[i]);
                    Console.WriteLine("Họ và tên: " + hoTen[i]);
                    Console.WriteLine("Điểm: " + diem[i]);
                    Console.WriteLine("Email: " + eMail[i]);
                }
                else if (diem[i] < 6.5)
                {
                    //demBeHon3 += 1;
                    //Console.WriteLine("Có {0} sinh viên có điểm bé hơn 6,5!", demBeHon65);
                    Console.WriteLine("Học lực trung bình!");
                    Console.WriteLine("Mã số sinh viên: " + maSV[i]);
                    Console.WriteLine("Họ và tên: " + hoTen[i]);
                    Console.WriteLine("Điểm: " + diem[i]);
                    Console.WriteLine("Email: " + eMail[i]);
                }
                else if (diem[i] < 7.5)
                {
                    //demBeHon3 += 1;
                    //Console.WriteLine("Có {0} sinh viên có điểm bé hơn 7,5!", demBeHon75);
                    Console.WriteLine("Học lực khá!");
                    Console.WriteLine("Mã số sinh viên: " + maSV[i]);
                    Console.WriteLine("Họ và tên: " + hoTen[i]);
                    Console.WriteLine("Điểm: " + diem[i]);
                    Console.WriteLine("Email: " + eMail[i]);
                }
                else if (diem[i] < 9)
                {
                    //demBeHon3 += 1;
                    //Console.WriteLine("Có {0} sinh viên có điểm bé hơn 9!", demBeHon9);
                    Console.WriteLine("Học lực giỏi!");
                    Console.WriteLine("Mã số sinh viên: " + maSV[i]);
                    Console.WriteLine("Họ và tên: " + hoTen[i]);
                    Console.WriteLine("Điểm: " + diem[i]);
                    Console.WriteLine("Email: " + eMail[i]);
                }
                else
                {
                    //demBeHon3 += 1;
                    //Console.WriteLine("Có {0} sinh viên có điểm lớn hơn 9!", demLonHon9);
                    Console.WriteLine("Học lực xuất sắc!");
                    Console.WriteLine("Mã số sinh viên: " + maSV[i]);
                    Console.WriteLine("Họ và tên: " + hoTen[i]);
                    Console.WriteLine("Điểm: " + diem[i]);
                    Console.WriteLine("Email: " + eMail[i]);
                }

            }
        }

    }
}

//fix lại ràng buộc điểm
//fix mail