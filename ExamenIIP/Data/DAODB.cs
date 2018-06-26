using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIIP.Data
{
    interface DAODB<T>
    {
        bool create(T t);
        bool update(T t);
        bool delete(T t);
        List<T> read();
    }
}
