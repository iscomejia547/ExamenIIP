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
        public Client cl { get; set; }
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

        private void okbtn_Click(object sender, EventArgs e)
        {
            foreach (var comp in fieldpanel.Controls)
            {
                TextBox bx = comp as TextBox;
                if (bx != null)
                {
                    if (bx.Text == "")
                    {
                        MessageBox.Show("No estan llenos todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            Client nw = new Client(cl.id, namefield.Text, snamefield.Text, cedufield.Text, celnumfield.Text, emailfield.Text,
                addressfield.Text, cityfield.Text, statefield.Text);
            if (isModify)
            {
                if (cdb.update(nw))
                {
                    MessageBox.Show("Se ha actualizado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (cdb.create(nw))
                {
                    MessageBox.Show("Se ha creado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Close();
        }
    }
}
