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
                    choices = Handing.menu();
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

                            Handing.endingProgram();
                            System.Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Handing.notificationError();

                            break;
                        }
                }
            } while (choices != 0);
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
Nguyen van d
5
nguyend@gmail.com
n
 */