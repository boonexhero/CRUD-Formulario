using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T2_FUNPRO
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void mantenimientoDueñoMascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_Veterinaria p_form_mant = new Mantenimiento_Veterinaria();
            p_form_mant.MdiParent = this;
            p_form_mant.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
