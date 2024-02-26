using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab7.DienThoai
{
    public class PhoneBookBasic : Phone
    {
        List<PhoneNumber> phoneNumbers = new List<PhoneNumber>();
        public override void InsertPhone(string name, string phone)
        {
            PhoneNumber phoneNumber = new PhoneNumber(name, phone);

            phoneNumbers.Add(phoneNumber);
        }

        public override void log()
        {
            foreach(PhoneNumber phone in phoneNumbers)
            {
                phone.Xuat();
            }
        }

        public override void RemovePhone(string name)
        {
            foreach (PhoneNumber phoneNumber in phoneNumbers)
            {
                if (phoneNumber.Name.Equals(name))
                {
                    phoneNumbers.Remove(phoneNumber);
                    return;
                }

            }
        }

        public override void SearchPhone(string name)
        {
            foreach(PhoneNumber phoneNumber in phoneNumbers)
            {
                if(phoneNumber.Name.Equals(name))
                {
                    phoneNumber.Xuat();
                }
            }
        }

        public override void Sort()
        {
           phoneNumbers.Sort((a,b) => a.Name.CompareTo(b.Name));
        }

        public override void UpdatePhone(string name, string newphone)
        {
            foreach(PhoneNumber phoneNumber in phoneNumbers)
            {
                if(phoneNumber.Name.Equals(name)) 
                {
                   phoneNumber.Phone = newphone;
                }
            }
        }
    }
}
