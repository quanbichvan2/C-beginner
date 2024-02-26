using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace ASM2
{
    class Program
    {
        public static int choices;
        public static void Main()
        {
            Handing handing = new();
            try
            {
                // y chang như Encoding.UTF-8
                /*Console.OutputEncoding = Encoding.Unicode;*/
                //khác biệt duy nhất là dùng UTF-8 tiết kiệm bộ nhớ, còn dùng Unicode phù hợp hiển thị đầu ra cho nhiều loại ngôn ngữ và ký tự.
                Console.OutputEncoding = Encoding.UTF8;
                do
                {
                    try
                    {
                        choices = Context.Menu();
                    }
                    catch (System.Exception)
                    {
                        choices = 11;
                    }
                    switch (choices)
                    {
                        case 1:
                            {
                                Context.CenterWrite(17);
                                Console.WriteLine("Nhập số lượng sv cần thêm: ");
                                int numb = Convert.ToInt32(Console.ReadLine());
                                while (numb < 0)
                                {
                                    Context.CenterWrite(17);
                                    Console.WriteLine("Nhập lại số lượng sv cần thêm: ");
                                    numb = Convert.ToInt32(Console.ReadLine());
                                }
                                for (int i = 0; i < numb; i++)
                                {
                                    handing.Nhap();
                                }
                                break;
                            }
                        case 2:
                            {

                                break;
                            }
                        case 3:
                            {

                                break;
                            }
                        case 4:
                            {

                                break;
                            }
                        case 5:
                            {

                                break;
                            }
                        case 6:
                            {

                                break;
                            }
                        case 7:
                            {

                                break;
                            }
                        case 8:
                            {

                                break;
                            }
                        case 9:
                            {

                                break;
                            }
                        case 10:
                            {

                                break;
                            }
                        default:
                            {
                                Context.NotificationError();
                                break;
                            }
                    }
                }
                while (choices != 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


        }
    }
}
