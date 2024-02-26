namespace QuanLySinhVien
{
    class Handing
    {
        private static List<SinhVien> listSinhVien = new List<SinhVien>();
        private static List<SinhVien> tempList = new List<SinhVien>();
        public static int number = 0;
        public static int width = 55;

        public static void program4()
        {
            centerWrite(17); Console.WriteLine("Chương trình số 4");
            if (listSinhVien.Count == 0)
            {
                notificationNoDataBase();
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
            notification1();
        }
        public static void program3()
        {
            centerWrite(17); Console.WriteLine("Chương trình số 3");
            if (listSinhVien.Count == 0)
            {
                notificationNoDataBase();
            }
            else
            {
                Filterrank();
                OutputFilter();
            }
            notification1();
        }
        public static void program2()
        {
            centerWrite(17); Console.WriteLine("Chương trình số 2");
            if (listSinhVien.Count == 0)
            {
                notificationNoDataBase();
            }
            else
            {
                Output();//Xuất list sinh viên
            }
            notification1();
        }
        public static void program1()
        {
            centerWrite(17); Console.WriteLine("Chương trình số 1");
            Input();//Nhập list sinh viên
            notification1();
        }
        /*Xử lý việc xếp loại sinh viên*/
        #region Rank 
        public static void Filterrank()//Lọc xếp loại học lực
        {
            tempList.Clear();
            Console.WriteLine("\n1. Xuất sắc\n2. Giỏi\n3. Khá\n4. Trung bình\n5. Yếu");
            Byte rank;
            do
            {
                try
                {
                    centerWrite(6); Console.Write("Nhập: ");
                    rank = Convert.ToByte(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    rank = 6;
                }
            }
            while (rank > 5);
            switch (rank)
            {
                case 1:
                    {
                        string keyWordRank = "Xuất sắc";
                        handleRank(keyWordRank);
                        break;
                    }
                case 2:
                    {
                        string keyWordRank = "Giỏi";
                        handleRank(keyWordRank);
                        break;
                    }
                case 3:
                    {
                        string keyWordRank = "Khá";
                        handleRank(keyWordRank);
                        break;
                    }
                case 4:
                    {
                        string keyWordRank = "Trung bình";
                        handleRank(keyWordRank);
                        break;
                    }
                case 5:
                    {
                        string keyWordRank = "Yếu";
                        handleRank(keyWordRank);
                        break;
                    }
                default:
                    {
                        Handing.notificationError();
                        break;
                    }
            }
        }
        //nếu rank == list sinhvien.getrank thì cho nó vào templist để xuất ra
        //sử dụng templist tăng bảo mật
        public static void handleRank(string rank)
        {
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                if (rank == listSinhVien[i].getRank)
                {
                    tempList.Add(listSinhVien[i]);
                }
            }
        }
        #endregion

        //Sắp xếp điểm 
        #region SortPoint
        //Sắp xếp điểm tăng dần
        public static void sortPointUp()
        {
            tempList.Clear();
            tempList.Add(listSinhVien[0]);
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                for (int j = 0; j < listSinhVien.Count; j++)
                {
                    if (listSinhVien[i].getPoint < listSinhVien[j].getPoint)
                    {
                        tempList[0] = listSinhVien[i];
                        listSinhVien[i] = listSinhVien[j];
                        listSinhVien[j] = tempList[0];
                    }
                }
            }
            centerWrite(45); Console.WriteLine("Danh sách sinh viên tăng dần sắp xếp hoàn tất");
        }
        //Sắp xếp điểm giảm dần
        public static void sortPointDown()
        {
            tempList.Clear();
            tempList.Add(listSinhVien[0]);

            for (int i = 0; i < listSinhVien.Count; i++)
            {
                for (int j = 0; j < listSinhVien.Count; j++)
                {
                    if (listSinhVien[i].getPoint > listSinhVien[j].getPoint)
                    {
                        tempList[0] = listSinhVien[i];
                        listSinhVien[i] = listSinhVien[j];
                        listSinhVien[j] = tempList[0];
                    }
                }
            }
            centerWrite(45); Console.WriteLine("Danh sách sinh viên giảm dần sắp xếp hoàn tất");
        }
        #endregion

        /*Xử lý nhập xuất trên Console*/
        #region In&Out
        public static void Input()
        {
            for (int i = 0; ; i++)
            {
                SinhVien sv = new SinhVien();
                number += 1;
                sv.input(number);
                listSinhVien.Add(sv);
                Console.WriteLine();
                Console.Write("Bạn có muốn nhập tiếp không?  (y/n): ");
                String? n = Console.ReadLine();
                if (n == "n" || n == "N")
                {
                    break;
                }
            }
        }
        public static void Output()//xuất ra danh sách sinh viên
        {
            for (int i = 0; i < listSinhVien.Count; i++)
            {
                listSinhVien[i].output(i + 1);
            }
        }
        public static void OutputFilter()//Xuất list tạm đã xữ lý ra ngoài
        {
            for (int i = 0; i < tempList.Count; i++)
            {
                tempList[i].output(i + 1);
            }
        }
        #endregion

        /*Xử lý giao diện và thông báo cho chương trình*/
        #region UI
        public static int menu()
        {
            Console.Clear();
            string menu = "";
            Console.ForegroundColor = ConsoleColor.Yellow;

            menu = @"
[[==================================================]] 
||   _   .-')       ('-.       .-') _               ||    
||  ( '.( OO )_   _(  OO)     ( OO ) )              ||
||   ,--.   ,--.)(,------.,--./ ,--,' ,--. ,--.     ||
||   |   `.'   |  |  .---'|   \ |  |\ |  | |  |     ||
||   |         |  |  |    |    \|  | )|  | | .-')   ||
||   |  |'.'|  | (|  '--. |  .     |/ |  |_|( OO )  ||
||   |  |   |  |  |  .--' |  |\    |  |  | | `-' /  ||
||   |  |   |  |  |  `---.|  | \   | ('  '-'(_.-'   ||
||   `--'   `--'  `------'`--'  `--'   `-----'      ||
||--------------------------------------------------||
||        1. Nhập danh sách học viên                ||
||        2. Xuất danh sách học viên                ||
||        3. Danh sách sinh viên theo học lực       ||
||        4. Sắp xếp sinh viên theo điểm            ||
||__________________________________________________||
||        0. Thoát chương trình                     ||
[[==================================================]]";
            Console.WriteLine(menu);
            Console.ResetColor();

            centerWrite(6); Console.Write("Nhập: ");

            int choices = Convert.ToByte(Console.ReadLine());
            return choices;
        }
        public static void endingProgram()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;//Đổi màu
            string text = "";
            text = @"    
[[==================================================]]
||     (     (                                      ||
||     )\ )  )\ )  *   )                 (          ||
||    (()/( (()/(` )  /(                 )\ (       ||
||     /(_)) /(_))( )(_))___ `  )    (  ((_))\ )    ||
||    (_))_|(_)) (_(_())|___|/(/(    )\  _ (()/(    ||
||    | |_  | _ \|_   _|    ((_)_\  ((_)| | )(_))   ||
||    | __| |  _/  | |      | '_ \)/ _ \| || || |   ||
||    |_|   |_|    |_|      | .__/ \___/|_| \_, |   ||
||                          |_|             |__/    ||
[[==================================================]]";
            Console.WriteLine(text);
            Console.ResetColor();
            notification1();
        }
        public static void notification1()
        {
            Console.SetCursorPosition((width - 32) / 2, Console.CursorTop);
            Console.Write("Nhấn bất kì phím nào để tiếp tục");
            Console.ReadKey();
        }
        public static void notificationError()
        {
            Console.SetCursorPosition((width - 13) / 2, Console.CursorTop);//13 là độ dài chuỗi "Lỗi nhập liệu"
            Console.WriteLine("Lỗi nhập liệu");
            notification1();
        }
        public static void notificationNoDataBase()
        {
            Console.SetCursorPosition((width - 31) / 2, Console.CursorTop);//13 là độ dài chuỗi "Lỗi nhập liệu"
            Console.WriteLine("Chưa có cơ sở dữ liệu sinh viên");
            notification1();
        }
        public static void centerWrite(int x)
        {
            Console.SetCursorPosition((width - x) / 2, Console.CursorTop);//Di chuyển vị trí con trỏ chuột

        }
        #endregion
    }
}