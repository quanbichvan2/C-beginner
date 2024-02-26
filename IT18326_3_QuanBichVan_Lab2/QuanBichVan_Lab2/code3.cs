using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanBichVan_Lab2
    {
        internal class code3
        {

            public static void bai3()
            {
                Console.OutputEncoding = Encoding.UTF8;
                int n, t, soNgay;
                Console.WriteLine("nhập ngày: ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập tháng: ");
                t = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("kiểm tra ngày tháng");
                //check(n, t);
                while (check(n, t) == false)
                {
                    Console.WriteLine("nhập lại ngày tháng: ");
                    Console.WriteLine("nhập ngày: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhập tháng: ");
                    t = Convert.ToInt32(Console.ReadLine());
                }
                switch (t)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        soNgay = 31;
                        Console.WriteLine("Tháng " + t + " nhập có 31 ngày \n");
                        Console.WriteLine("ngày hôm sau của ngày " + n + " của tháng " + t + " đã nhập là: ");
                        Console.WriteLine(tinhNgaySau(n, t));
                        //tinhNgaySau(n, t, soNgay);
                        Console.WriteLine("ngày hôm trước của ngày " + n + " của tháng " + t + " đã nhập là: ");
                        Console.WriteLine(tinhNgayTruoc(n, t, soNgay));
                        //tinhNgayTruoc(n, t, soNgay);
                        break;

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        soNgay = 30;
                        Console.WriteLine("Tháng " + t + " nhập có 30 ngày \n");
                        Console.WriteLine("ngày hôm sau của ngày " + n + " của tháng " + t + " đã nhập là: ");
                        Console.WriteLine(tinhNgaySau(n, t));
                        //tinhNgaySau(n, t, soNgay);
                        Console.WriteLine("ngày hôm trước của ngày " + n + " của tháng " + t + " đã nhập là: ");
                        Console.WriteLine(tinhNgayTruoc(n, t, soNgay));
                        // tinhNgayTruoc(n, t, soNgay);
                        break;

                    case 2:
                        soNgay = 29;
                        Console.WriteLine("Tháng " + t + " nhập có 29 ngày \n");
                        Console.WriteLine("ngày hôm sau của ngày " + n + " của tháng " + t + " đã nhập là: ");
                        Console.WriteLine(tinhNgaySau(n, t));
                        //tinhNgaySau(n, t, soNgay);
                        Console.WriteLine("ngày hôm trước của ngày " + n + " của tháng " + t + " đã nhập là: ");
                        Console.WriteLine(tinhNgayTruoc(n, t, soNgay));
                        //tinhNgayTruoc(n, t, soNgay);
                        break;
                }
            }

            static Boolean check(int n, int t)
            {
                // nếu ngày sai -> ko hợp lệ
                if (n < 1 || n > 31)
                {
                    Console.WriteLine("Ngày không hợp lệ ");
                    return false;
                }

                // nếu tháng sai -> ko hợp lệ
                else if (t < 1 || t > 12)
                {
                    Console.WriteLine("Tháng không hợp lệ \n");
                    return false;
                }

                // nếu ngày đúng -> kiểm tra tháng 
                else if (n == 31)
                {
                    if (t == 1 || t == 3 || t == 5 || t == 7 || t == 8 || t == 10 || t == 12)
                    {
                        Console.WriteLine("Ngày tháng hợp lệ \n");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Ngày không hợp lệ \n");
                        return false;
                    }
                }

                // nếu tháng thuộc tháng 2
                else if (t == 2)
                {
                    if (n > 0 && n <= 29)
                    {
                        Console.WriteLine("Ngày tháng hợp lệ \n");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Ngày tháng không hợp lệ \n");
                        return false;
                    }
                }
                // nếu tháng đúng 
                else
                {
                    Console.WriteLine("Ngày tháng hợp lệ \n");
                    return true;
                }
            }

            //cách 1: dùng toán tử 3 ngôi, bỏ bớt biến soNgay, trả về int
            static int tinhNgaySau(int n, int t)
            {
                if (t == 2)
                {
                    return n == 29 ? 1 : n += 1;
                }
                else if (t == 1 || t == 3 || t == 5 || t == 7 || t == 8 || t == 10 || t == 12)
                {
                    return n == 31 ? 1 : n += 1;
                }
                else
                {
                    return n == 30 ? 1 : n += 1;
                }
            }
            //cách 2: 
            //static void tinhNgaySau(int n, int t, int soNgay)
            //{
            //    n = n + 1;
            //    if (n > soNgay)
            //    {
            //        n = 1;
            //        t = t + 1;
            //        Console.WriteLine("Ngày " + n + " Tháng " + t);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ngày " + n + " Tháng " + t);
            //    }
            //}

            //cách 1
            static int tinhNgayTruoc(int n, int t, int soNgay)
            {
                if (n == 1)
                {
                    if (t == 3)
                    {
                        return 28;
                    }
                    else if (t == 1 || t == 2 || t == 4 || t == 6 || t == 8 || t == 9 || t == 12)
                    {
                        return 31;
                    }
                    else
                    {
                        return 30;
                    }
                }
                else
                {
                    return n -= 1;
                }
            }



            // cách 2
            //static void tinhNgayTruoc(int n, int t, int soNgay)
            //{
            //    n = n - 1;
            //    // tính lùi tháng
            //    if (n == 0)
            //    {   
            //        // nếu 1/3 lùi về 29/2
            //        if (t == 3)
            //        {
            //            soNgay = 29;
            //            n = soNgay;
            //            t = t-1;
            //            Console.WriteLine("Ngày " + n + " Tháng " + t + "\n");
            //        }
            //        // 1/1 lùi về 31/12
            //        else if (t == 1)
            //        {
            //            n = 31;
            //            t = 12;
            //            Console.WriteLine("Ngày " + n + " Tháng " + t + "\n");
            //        }
            //        // nếu 1/2 lùi về 31 tháng 1
            //        else if (t == 2) 
            //        {
            //            soNgay = 31;
            //            n = soNgay;
            //            t = t-1;
            //            Console.WriteLine("Ngày " + n + " Tháng " + t + "\n");
            //        }
            //        // nếu 1/8 lùi về 31/7
            //        else if(t == 8)
            //        {
            //            n =soNgay;
            //            t = t-1;
            //            Console.WriteLine("Ngày " + n + " Tháng " + t + "\n");
            //        }

            //        // 1,3,5, (7,8) ,10,12 (31 ngày) còn lại 4,6,9,11 (30 ngày)
            //        else
            //        {
            //            // 1/4 -> 31/3
            //            n = soNgay+1;
            //            if (n == 32)
            //            {
            //                n = soNgay -1;
            //                t = t - 1;
            //                Console.WriteLine("Ngày " + n + " Tháng " + t + "\n");
            //            }
            //            else
            //            {
            //                n = 31;
            //                t = t - 1;
            //                Console.WriteLine("Ngày " + n + " Tháng " + t + "\n");
            //            }

            //        }

            //    }
            //    //nếu không lùi tháng
            //    else
            //    {
            //        //n = n - 1;
            //        t = t - 1;
            //        Console.WriteLine("Ngày " + n + " Tháng " + t + "\n");
            //    }
            //}
        }
    }


