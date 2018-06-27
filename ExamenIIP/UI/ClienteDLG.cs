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
    
    public partial class ClienteDLG : Form
    {
        private ClientDB cdb;
        private Client cl;
        public bool isModify { get; set; }
        public ClienteDLG(ClientDB cdb)
        {
            this.cdb = cdb;
            InitializeComponent();
        }

        private void ClienteDLG_Shown(object sender, EventArgs e)
        {
            if (isModify)
            {
                namefield.Text = cl.name;
                snamefield.Text = cl.surname;
                cedufield.Text = cl.cedula;
                celnumfield.Text = cl.cel;
                emailfield.Text = cl.email;
                addressfield.Text = cl.address;
                cityfield.Text = cl.city;
                statefield.Text = cl.state;
            }
            else
            {
                cl = new Client(0, null, null, null, null, null, null, null, null);
            }
        }
    }
}
