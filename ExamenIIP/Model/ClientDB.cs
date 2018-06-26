
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenIIP.Objects;
using ExamenIIP.Data;

namespace ExamenIIclient.Model
{
    public class ClientDB : DAODB<Client>
    {
        private const int SIZE = 413;
        private List<Client> clients;
        private Client client;
        private BinaryReader putin;
        private BinaryWriter putout;

        public ClientDB()
        {
            streamGenerator();
        }

        public bool create(Client t)
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
            putout.Write(nVarChar(t.name, 45));
            putout.Write(nVarChar(t.surname, 45));
            putout.Write(nVarChar(t.cedula, 10));
            putout.Write(nVarChar(t.cel, 8));
            putout.Write(nVarChar(t.address, 45));
            putout.Write(nVarChar(t.city, 15));
            putout.Write(nVarChar(t.state, 15));
            putout.BaseStream.Seek(0, SeekOrigin.Begin);
            putout.Write(++n);
            putout.Write(++k);
            return true;
        }

        public bool delete(Client t)
        {
            throw new NotImplementedException();
        }

        public List<Client> read()
        {
            clients = new List<Client>();
            putin.BaseStream.Seek(0, SeekOrigin.Begin);
            int n = putin.ReadInt32();
            for (int i = 1; i <= n; i++)
            {
                client = QueryByID(i);
                if (client != null)
                {
                    //autoborrador
                    clients.Add(client);
                }
            }
            return clients;
        }

        public bool update(Client t)
        {
            if(t == null)
            {
                return false;
            }
            int i = t.id;
            long pos = 8 + SIZE * (i - 1);
            putout.BaseStream.Seek(pos, SeekOrigin.Begin);
            putout.Write(t.id);
            putout.Write(nVarChar(t.name, 45));
            putout.Write(nVarChar(t.surname, 45));
            putout.Write(nVarChar(t.cedula, 10));
            putout.Write(nVarChar(t.cel, 8));
            putout.Write(nVarChar(t.email, 20));
            putout.Write(nVarChar(t.address, 45));
            putout.Write(nVarChar(t.city, 15));
            putout.Write(nVarChar(t.state, 15));
            putout.BaseStream.Seek(0, SeekOrigin.Begin);
            return true;
        }
        public Client QueryByID(int ID)
        {
            putin.BaseStream.Seek(0, SeekOrigin.Begin);
            int n = putin.ReadInt32();
            if (ID > n || ID <= 0)
            {
                return null;
            }
            long pos = 8 + SIZE * (ID - 1);
            putin.BaseStream.Seek(pos, SeekOrigin.Begin);
            client = new Client();
            client.id = putin.ReadInt32();
            client.name = putin.ReadString().Trim();
            client.surname = putin.ReadString().Trim();
            client.cedula = putin.ReadString().Trim();
            client.cel=putin.ReadString().Trim();
            client.address= putin.ReadString().Trim();
            client.email= putin.ReadString().Trim();
            client.city= putin.ReadString().Trim();
            client.state= putin.ReadString().Trim();
            return client;
        }
        private void streamGenerator()
        {
            FileStream fs = GeneralFiler.getFS(Application.StartupPath+@"\\clients.dat");
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
