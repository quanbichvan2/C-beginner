
using System.ComponentModel;
using System.Text;

namespace lab6
{
    class Program
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
                                    Handing.NhapMang();
                                    break;
                                }
                            case 2:
                                {
                                    Handing.XuatMang();
                                    break;
                                }
                            case 3:
                                {
                                    Handing.Program3();
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
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                //Handing.nhapMang();
                //Console.WriteLine("--------------------------------------");
                //Handing.xuatMang();
                //Console.WriteLine("sap xep ten tac gia");
                //Handing.sapXepTenSach();

            }
    }

}
/* test 
a
b
a
2000
ps100
asd
c
a
c
2001
ps101
asb
b
c
b
1999
ps102
avc
*/

