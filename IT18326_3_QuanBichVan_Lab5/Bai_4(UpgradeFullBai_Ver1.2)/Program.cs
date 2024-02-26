using Bai_4;
using System.Text;

namespace QuanLySinhVien
{
    class program
    {
        public static int choices;
        public static void Main()
        {
            try
            {
                Console.OutputEncoding = Encoding.Unicode;
                do
                {
                    try
                    {
                        choices = Context.Menu();
                    }
                    catch (System.Exception)
                    {
                        choices = 5;
                    }
                    switch (choices)
                    {
                        case 1:
                            {
                                Handing.program1();
                                break;
                            }
                        case 2:
                            {
                                Handing.program2();
                                break;
                            }
                        case 3:
                            {
                                Handing.program3();
                                break;
                            }
                        case 4:
                            {
                                Handing.program4();
                                break;
                            }
                        case 0:
                            {

                                Context.EndingProgram();
                                System.Environment.Exit(0);
                                break;
                            }
                        default:
                            {
                                Context.NotificationError();
                                break;
                            }
                    }
                } while (choices != 0);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
           
    }
}

/*
test Program: 1
vân quan
8
vanquan@gmail.com
y
Nguyen van a
9
nguyena@gmail.com
y
nguyen van b
4
nguyenb@gmail.com
y
Nguyen van c
7
nguyenc@gmail.com
y
 */