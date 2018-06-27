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
    public partial class ExtDLG : Form
    {
        public bool isModify = false;
        public Extinguisher ext { get; set; }
        private ClientDB cdb;
        private ExtinguisherDB edb;
        public ExtDLG(ClientDB cdb, ExtinguisherDB edb)
        {
            this.edb = edb;
            this.cdb = cdb;
            InitializeComponent();
        }

        private void ExtDLG_Load(object sender, EventArgs e)
        {
            typecmb.DataSource = Enum.GetValues(typeof(Extinguisher.TYPE));
            if (isModify)
            {
                catcmb.SelectedItem = ext.cat;
                brandfield.Text = ext.brand;
                typecmb.SelectedItem = ext.type;
                qtyfield.Text = ext.cap.ToString();
                unitcmb.SelectedItem = ext.und;
                placefield.Text = ext.place;
                datefield.Text = ext.date.ToShortTimeString();
                clfield.Text = ext.owner.id.ToString();
            }
            else
            {
                ext = new Extinguisher(0, 'x', "", 0, 0, "", "", DateTime.Now, null);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            foreach(var comp in fieldpanel.Controls)
            {
                TextBox txt = comp as TextBox;
                if (txt != null)
                {
                    if (txt.Text == "")
                    {
                        MessageBox.Show("No estan llenos todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            Client aux = cdb.QueryByID(Int32.Parse(clfield.Text));
            if (aux == null)
            {
                MessageBox.Show("El cliente ingresado no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("El cliente seleccionado es: " + aux.pair(), "", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
            {
                return;
            }
            Extinguisher nw = new Extinguisher(ext.id, Char.Parse(catcmb.SelectedItem.ToString()),brandfield.Text,
                typecmb.SelectedIndex, float.Parse(qtyfield.Text), unitcmb.SelectedItem.ToString(), placefield.Text,
                datefield.Value,aux);
            if (isModify)
            {
                if (edb.update(nw))
                {
                    MessageBox.Show("Se ha actualizado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (edb.create(nw))
                {
                    MessageBox.Show("Se ha guardado correctamente correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            Close();
        }
    }
}
