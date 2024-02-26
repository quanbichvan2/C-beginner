using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Lab7.DienThoai
{
    public class PhoneBook : Phone
    {
        // sử dụng hashTable / HashMap (trong Java) :  nó là 1 list, nó có 2 trường giá trị (key,value), nó không chứa giá trị có key trùng lập 
        // (key,value) đây là 1 cặp giá trị, key luôn đi đôi với value, key là 1 trường địa chỉ -> truy cập các value

        Hashtable hashtable = new Hashtable();

        //[cong][van][van]
        // Giờ cho 2 đứa tên Vân vào cái list rồi xóa 1 đứa cô xóa làm sao, thay vì dùng thêm 1 biến id thì ở đây e xin phép dùng luôn name làm trường unique thay cho id

        public override void InsertPhone(string name, string phone)
        {
            //Lưu ý: key không được null, value có thể null
            // nếu add trùng key thì value cũ sẽ bị xóa và thay bằng value mới
            if (hashtable.ContainsKey(name))
            {
                string newPhone = hashtable[name] + " : " + phone;
                hashtable[name] = newPhone;
            }
            else
            {
                hashtable[name] = phone;
            }

        }

        public override void RemovePhone(string name)
        {
            if (!hashtable.ContainsKey(name))
            {
                Context.CenterWrite(17);
                Console.WriteLine("the name doesn't exist");
                return;
            }
            else
            {
                hashtable.Remove(name);
                Context.CenterWrite(17);
                Console.WriteLine("Remove success");
            }

        }

        public override void SearchPhone(string name)
        {
            if (!hashtable.ContainsKey(name))
            {
                Context.CenterWrite(17);
                Console.WriteLine("the name doesn't exist");
                return;
            }
            else
            {
                Context.CenterWrite(17);
                // hashtable[name] : tức là lấy value tại key name -> nó sẽ in ra value là thằng phone thông qua key name
                Console.WriteLine($"PhoneNumber:  {hashtable[name]}");
            }

        }

        public override void Sort()
        {
            var sortedList = hashtable.Cast<DictionaryEntry>().OrderBy(entry => entry.Key).ToList();
            foreach (var p in sortedList)
            {
                Context.CenterWrite(17);
                Console.WriteLine("name: {0} \nphoneNumber: {1}", p.Key, p.Value);
            }

        }

        public override void UpdatePhone(string name, string newphone)
        {
            if (!hashtable.ContainsKey(name))
            {
                Context.CenterWrite(17);
                Console.WriteLine($"{name} doesnt exist ");
                return;
            }
            else
            {
                hashtable[name] = newphone;
            }

        }

        public override void log()
        {
            foreach (DictionaryEntry item in hashtable)
            {
                Context.CenterWrite(17);
                Console.WriteLine(item.Key);
                Context.CenterWrite(17);
                Console.WriteLine(item.Value);
            }
        }


    }
}
