using Lab7;
using Lab7.DienThoai;
using System.Text;

class Program
{
    public static int choices;
    public static void Main()
    {
        PhoneBook phoneBook = new PhoneBook();
        try
        {
            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                try
                {
                    choices = Context.Menu();
                }
                catch (System.Exception)
                {
                    choices = 6;
                }

                switch (choices)
                {

                    case 1:
                        {
                            Context.CenterWrite(17);
                            Console.Write("Fill your name: ");
                            string name = Console.ReadLine();
                            Context.CenterWrite(17);
                            Console.Write("Fill your phone: ");
                            string phone = Console.ReadLine();
                            phoneBook.InsertPhone(name, phone);
                            Console.WriteLine("----------------------------------------------------------------------------------------------------");
                            // cho nó data và list
                            Context.Notification1();
                            break;
                        }
                    case 2:
                        {

                            Context.CenterWrite(17);
                            Console.WriteLine("Remove a phone number");
                            Context.CenterWrite(17);
                            Console.Write("Fill the name want to remove: ");
                            string name = Console.ReadLine();
                            phoneBook.RemovePhone(name);
                            Console.WriteLine("----------------------------------------------------------------------------------------------------");
                            // cho nó data và lis
                            Context.Notification1();
                            break;
                        }
                    case 3:
                        {
                            Context.CenterWrite(17);
                            Console.Write("Fill the name want to update: ");
                            string name = Console.ReadLine();
                            Context.CenterWrite(17);
                            Console.Write("Update a new number: ");
                            string phone = Console.ReadLine();
                            phoneBook.UpdatePhone(name, phone);

                            phoneBook.log();
                            Console.WriteLine("----------------------------------------------------------------------------------------------------");
                            // cho nó data và lis
                            Context.Notification1();
                            break;
                        }
                    case 4:
                        {
                            Context.CenterWrite(17);
                            Console.Write("Sreach Phonebook: ");
                            string name = Console.ReadLine();
                            phoneBook.SearchPhone(name);
                            Console.WriteLine("----------------------------------------------------------------------------------------------------");
                            // cho nó data và lis
                            Context.Notification1();
                            break;
                        }
                    case 5:
                        {
                            Context.CenterWrite(17);
                            Console.WriteLine("Sort a list of phonebook");
                            phoneBook.Sort();
                            Console.WriteLine("----------------------------------------------------------------------------------------------------");
                            // cho nó data và lis
                            Context.Notification1();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("----------------------------------------------------------------------------------------------------");
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
        //PhoneBookBasic phoneBookBasic = new PhoneBookBasic();
        //    phoneBookBasic.InsertPhone("Cong", "123456");
        //    phoneBookBasic.InsertPhone("An", "123456");
        //    phoneBookBasic.InsertPhone("Vinh", "123456");
        //    phoneBookBasic.UpdatePhone("Cong", "999999");
        //    phoneBookBasic.log();


    }
}