using ExamenIIP.Model;
using ExamenIIP.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenIIP.UI
{
    public partial class Main : Form
    {
        private ClientDB cdb;
        private ExtinguisherDB edb;
        public Main()
        {
            cdb = new ClientDB();
            edb = new ExtinguisherDB();
            InitializeComponent();
            /*Client def = new Client(0, "Jose Manuel", "Perez Soza", "001-010190-0024G", "12345678", "jose.perez@aol.com",
                "de donde no hay luz, dos cuadras al este", "Managua", "Managua");
            cdb.create(def);
            edb.create(new Extinguisher(0, 'A', "Amerex", 0, (float)12.5, "lt", "Sala de estar", DateTime.Now, def));*/
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            ClientGrid.Rows.Clear();
            ExtGrid.Rows.Clear();
            List<Client> cl = cdb.read();
            updateClients(cl);
            edb.setClients(cl);
            updateExt(edb.read());
            
        }
        private void updateClients(List<Client> cl)
        {
            ClientGrid.Rows.Clear();
            foreach (var i in cl)
            {
                ClientGrid.Rows.Add(i.ToArray());
            }
        }
        private void updateExt(List<Extinguisher> ext)
        {
            ExtGrid.Rows.Clear();
            foreach (var i in ext)
            {
                if(i.date<=DateTime.Now.AddYears(1))
                {
                    MessageBox.Show(i.VoidAdvice()+" está proximo a vencerse"
                        , "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                ExtGrid.Rows.Add(i.ToArray());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int opt = searchclcmb.SelectedIndex;
            List<Client> all = cdb.read();
            switch (opt)
            {
                default:
                    {
                        updateClients(all);
                        return;
                    }
                case 0:
                    {
                        List<Client> list= new List<Client>{cdb.QueryByID(Int32.Parse(searchclientField.Text))};
                        updateClients(list);
                        break;
                    }
                case 1:
                    {
                        var list = (from Client x in all where x.cedula.Equals(searchclcmb.Text) select x).ToList();
                        updateClients(list);
                        break;
                    }
                case 2:
                    {
                        var list = (from Client x in all where x.surname.Equals(searchclcmb.Text) select x).ToList();
                        updateClients(list);
                        break;
                    }
            }
        }

        private void extintorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtDLG dlg = new ExtDLG(cdb, edb);
            dlg.isModify = false;
            dlg.ShowDialog();
            updateExt(edb.read());
        }

        private void extintorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Helper help = new Helper(false);
            help.ShowDialog();
            int id = help.input();
            Extinguisher xd = edb.QueryByID(id);
            if (xd == null)
            {
                MessageBox.Show("No se encontro ese extintor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ExtDLG dlg = new ExtDLG(cdb, edb);
            dlg.isModify = true;
            dlg.ext = xd;
            dlg.ShowDialog();
        }

        private void clientecreate_Click(object sender, EventArgs e)
        {
            ClienteDLG dlg = new ClienteDLG(cdb);
            dlg.isModify=false;
            dlg.ShowDialog();
            updateClients(cdb.read());
        }

        private void clienteupdate_Click(object sender, EventArgs e)
        {
            Helper help = new Helper(true);
            help.ShowDialog();
            int id = help.input();
            Client cl = cdb.QueryByID(id);
            ClienteDLG dlg = new ClienteDLG(cdb);
            dlg.isModify = false;
            dlg.cl = cl;
            dlg.ShowDialog();
            updateClients(cdb.read());
        }

        private void searchextbtn_Click(object sender, EventArgs e)
        {
            int opt = searchextcmb.SelectedIndex;
            List<Extinguisher> all = edb.read();
            List<Extinguisher> list=null;
            switch (opt)
            {
                default:
                    {
                        updateExt(all);
                        return;
                    }
                case 0:
                    {
                        list = (from Extinguisher x in all where x.brand.Equals(searchextfield.Text) select x).ToList();
                        break;
                    }
                case 1:
                    {
                        list = (from Extinguisher x in all where x.cat == searchextfield.Text[0] select x).ToList();
                        break;
                    }
                case 2:
                    {
                        list = (from Extinguisher x in all where x.und.Equals(searchextfield.Text) select x).ToList();
                        break;
                    }
                case 3:
                    {
                        list = (from Extinguisher x in all where x.cap == Single.Parse(searchextfield.Text) select x).ToList();
                        break;
                    }
                case 4:
                    {
                        list = (from Extinguisher x in all where x.owner.id == Int32.Parse(searchextfield.Text) select x).ToList();
                        break;
                    }
            }
            updateExt(list);
        }
    }
}
