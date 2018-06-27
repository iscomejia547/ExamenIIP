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
            /*Client def = new Client(0, "Jose Manuel", "Perez Soza", "001-010190", "12345678", "jose.perez@aol.com",
                "de donde no hay luz, dos cuadras al este", "Managua", "Managua");
            cdb.create(def);
            edb.create(new Extinguisher(0, 'A', "Amerex", 0, 12.5f, "lt", "Sala de estar", DateTime.Now, def));*/
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
            foreach (var i in cl)
            {
                ClientGrid.Rows.Add(i.ToArray());
            }
        }
        private void updateExt(List<Extinguisher> ext)
        {
            foreach (var i in ext)
            {
                if(i.date<=new DateTime(i.date.Year+1, i.date.Month, i.date.Day))
                {
                    MessageBox.Show(i.VoidAdvice()+" está proximo a vencerse"
                        , "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                ExtGrid.Rows.Add(i.ToArray());
            }
        }

    }
}
