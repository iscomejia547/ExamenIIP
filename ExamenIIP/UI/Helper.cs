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
    public partial class Helper : Form
    {
        private bool forClient;
        private Int32 id=0;
        public void setID(Int32 id)
        {
            this.id = id;
        }
        public Helper(bool forClient)
        {
            this.forClient = forClient;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id =Int32.Parse(inputBox.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public int input()
        {
            return this.id;
        }
        private void Helper_Shown(object sender, EventArgs e)
        {
            if (forClient)
            {
                label1.Text = "Ingrese el ID del cliente a seleccionar";
            }
            else
            {
                label1.Text = "Ingrese el ID del extintor a seleccionar";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
