using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.DienThoai
{
    public abstract class Phone
    {
        public abstract void InsertPhone(string name, string phone);
        public abstract void RemovePhone(string name);
        public abstract void UpdatePhone(string name, string newphone);
        public abstract void SearchPhone(string name);
        public abstract void Sort();

        public abstract void log();
    }
}


