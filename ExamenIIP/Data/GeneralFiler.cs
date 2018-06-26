using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenIIP.Data
{
    class GeneralFiler
    {
        static FileStream fs;
        public static FileStream getFS(string PATH)
        {
            if (PATH == null)
            {
                throw new ArgumentNullException("Debe asignar la ruta correspondiente!!");
            }
            if (!File.Exists(PATH))
            {
                fs = new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                fs.Seek(0, SeekOrigin.Begin);
                BinaryWriter w = new BinaryWriter(fs);
                w.Write(0);
                w.Write(0);
            }
            else
            {
                fs = new FileStream(PATH, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                fs.Seek(0, SeekOrigin.Begin);
            }
            return fs;
        }
    }
}
