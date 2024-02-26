using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Context
    {
        public static int width = 55;
        public static int Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            string menu = @"
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
                    ||        1. Nhập Sách                              ||
                    ||        2. Xuất sách                              ||
                    ||        3. Sắp xếp sách                           ||
                    ||__________________________________________________||
                    ||        0. Thoát chương trình                     ||
                    [[==================================================]]";
            Console.WriteLine(menu);
            Console.ResetColor();
            CenterWrite(6); Console.Write("Nhập: ");
            int choices = Convert.ToByte(Console.ReadLine());
            return choices;
        }
        public static void EndingProgram()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;//Đổi màu
            string text = @"    
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
            Notification1();
        }
        public static void Notification1()
        {
            Console.SetCursorPosition((width - 32) / 2, Console.CursorTop);
            Console.Write("Nhấn bất kì phím nào để tiếp tục");
            Console.ReadKey();
        }
        public static void NotificationError()
        {
            Console.SetCursorPosition((width - 13) / 2, Console.CursorTop);//13 là độ dài chuỗi "Lỗi nhập liệu"
            Console.WriteLine("Lỗi nhập liệu");
            Notification1();
        }
        public static void NotificationNoDataBase()
        {
            Console.SetCursorPosition((width - 31) / 2, Console.CursorTop);//13 là độ dài chuỗi "Lỗi nhập liệu"
            Console.WriteLine("Chưa có cơ sở dữ liệu sinh viên");
            Notification1();
        }
        public static void CenterWrite(int x)
        {
            Console.SetCursorPosition((width - x) / 2, Console.CursorTop);//Di chuyển vị trí con trỏ chuột

        }
    }
}
