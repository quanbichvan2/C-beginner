using Bai_4;
using System.Text;

namespace QuanLySinhVien
{
    class program
    {
        public static int choices;
        public static void Main()
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
    }
}

/*
test Program: 1
1
vân quan
8
7
y
1
thanh nhã
9
10
y
2
Nguyen van a
7
5
6
y
2
nguyen van b
4
3
5
y
2
Nguyen van c
8
9
8
y
1
nguyen van teo
7
4
n
 */