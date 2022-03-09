using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Forms
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmForm1 formulario = new frmForm1();
            formulario.Dock = DockStyle.Fill;
            formulario.TopLevel = false;

            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(formulario);

            formulario.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmForm2 formulario = new frmForm2();
            formulario.Dock = DockStyle.Fill;
            formulario.TopLevel = false;

            pnlContenedor.Controls.Clear();
            pnlContenedor.Controls.Add(formulario);

            formulario.Show();
        }
    }
}
