using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab7.DienThoai
{
    public class PhoneNumber
    {
        private string name { get; set; }
        private string phoneNumber { get; set; }
        //constructor với 2 tham số là name và phoneNum
        public PhoneNumber(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }
        ////constructor default (mặc định tự có không cần phải ghi)
        //public PhoneNumber() { }
        ////constructor có 1 tham số là name
        //public PhoneNumber(string name)
        //{
        //    this.name = name;
        //}
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Phone
        {
            get { return phoneNumber; }

            set { phoneNumber = value; }
        }
        public void Xuat() 
        {
            Console.WriteLine(name+ " " + phoneNumber);
        }
    }

}
