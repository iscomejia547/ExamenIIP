using ExamenIIP.Data;
using ExamenIIP.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenIIP.Model
{
    class ExtinguisherDB : DAODB<Extinguisher>
    {
        private const int SIZE = 221;
        private List<Extinguisher> extinguishers;
        private Extinguisher extinguisher;
        private BinaryReader putin;
        private BinaryWriter putout;
        private List<Client> clients=null;

        public ExtinguisherDB()
        {
            streamGenerator();
        }
        public void setClients(List<Client> clients)
        {
            this.clients = clients;
        }
        public bool create(Extinguisher t)
        {
            putin.BaseStream.Seek(0, SeekOrigin.Begin);
            int n = putin.ReadInt32();
            int k = putin.ReadInt32();
            t.id = k + 1;
            if (t.id <= k || t.id <= n)
            {
                throw new ArgumentException("ID: " + t.id + " ya esta ocupado");
            }
            long pos = 8 + (t.id - 1) * SIZE;
            putout.BaseStream.Seek(pos, SeekOrigin.Begin);
            putout.Write(t.id);
            putout.Write(t.cat);
            putout.Write(nVarChar(t.brand, 45));
            putout.Write((int)t.type);
            putout.Write(t.cap);
            putout.Write(nVarChar(t.und, 6));
            putout.Write(nVarChar(t.place, 45));
            putout.Write(t.date.ToFileTimeUtc());
            putout.Write(t.owner.id);
            putout.BaseStream.Seek(0, SeekOrigin.Begin);
            putout.Write(++n);
            putout.Write(++k);
            return true;
        }

        public bool delete(Extinguisher t)
        {
            throw new NotImplementedException();
        }

        public List<Extinguisher> read()
        {
            extinguishers = new List<Extinguisher>();
            putin.BaseStream.Seek(0, SeekOrigin.Begin);
            int n = putin.ReadInt32();
            for (int i = 1; i <= n; i++)
            {
                extinguisher = QueryByID(i);
                if (extinguisher != null)
                {
                    extinguishers.Add(extinguisher);
                }
            }
            return extinguishers;
        }

        public bool update(Extinguisher t)
        {
            if (t == null)
            {
                return false;
            }
            int i = t.id;
            long pos = 8 + SIZE * (i - 1);
            putout.BaseStream.Seek(pos, SeekOrigin.Begin);
            putout.Write(t.id);
            putout.Write(t.cat);
            putout.Write(nVarChar(t.brand, 45));
            putout.Write((int)t.type);
            putout.Write(t.cap);
            putout.Write(nVarChar(t.und, 6));
            putout.Write(nVarChar(t.place, 45));
            putout.Write(t.date.ToFileTimeUtc());
            putout.Write(t.owner.id);
            putout.BaseStream.Seek(0, SeekOrigin.Begin);
            return true;
        }
        public Extinguisher QueryByID(int ID)
        {
            if (clients == null)
            {
                throw new ArgumentException("NON VALID");
            }
            putin.BaseStream.Seek(0, SeekOrigin.Begin);
            int n = putin.ReadInt32();
            if (ID > n || ID <= 0)
            {
                return null;
            }
            //ClientDB db = new ClientDB();
            long pos = 8 + SIZE * (ID - 1);
            putin.BaseStream.Seek(pos, SeekOrigin.Begin);
            extinguisher = new Extinguisher();
            extinguisher.id = putin.ReadInt32();
            extinguisher.cat = putin.ReadChar();
            extinguisher.brand = putin.ReadString().Trim();
            extinguisher.type = (Extinguisher.TYPE)putin.ReadInt32();
            extinguisher.cap = putin.ReadSingle();
            extinguisher.und = putin.ReadString().Trim();
            extinguisher.place = putin.ReadString().Trim();
            extinguisher.date = DateTime.FromFileTimeUtc(putin.ReadInt64());
            int y = putin.ReadInt32();
            var client = (from Client x in clients where x.id == y  select x).ToArray()[0];
            extinguisher.owner = client;
            return extinguisher;
        }
        private void streamGenerator()
        {
            FileStream fs = GeneralFiler.getFS(Application.StartupPath + @"\\extinguishers.dat");
            putin = new BinaryReader(fs);
            putout = new BinaryWriter(fs);
        }
        private string nVarChar(string s, int n)
        {
            StringBuilder sb = null;
            if (s == null || s == "")
            {
                sb = new StringBuilder(n);
            }
            else
            {
                sb = new StringBuilder(s);
                sb.Length = n;
            }
            return sb.ToString();
        }
    }
}
