using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lap6_Bai2
{
    interface IDbActrion
    {
        void Insert();

        void Update();

        void Delete();

        void Select();

    }
}
