using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Mantenimiento_Numeros : Form
    {
        public Numeros e_Numeros;
        public Mantenimiento_Numeros()
        {
            InitializeComponent();
            e_Numeros = new Numeros();
        }
        private void btn_agregar_n_Click(object sender, EventArgs e)
        {
            try
            {
                double e_numero = double.Parse(txtnumero.Text);
                e_Numeros.InsertarNumero(e_numero);
                ActualizarLista();
                txtnumero.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }
        private void ActualizarLista()
        {
            lsb_num.DataSource = null;
            lsb_num.DataSource = e_Numeros.e_Lista;
        }

        private void btn_or_as_Click(object sender, EventArgs e)
        {
            e_Numeros.OrdenarAscendente();
            ActualizarLista();
        }

        private void btn_or_des_Click(object sender, EventArgs e)
        {
            e_Numeros.OrdenarDescendente();
            ActualizarLista();
        }

        private void btn_busca_n_Click(object sender, EventArgs e)
        {
            try
            {
                double e_numero = double.Parse(txt_buscar_n.Text);
                bool e_encontrado = e_Numeros.BuscarNumero(e_numero);
                if (e_encontrado)
                {
                    List<double> e_listaTemporal = new List<double>();
                    e_listaTemporal.Add(e_numero);
                    lsb_num.DataSource = e_listaTemporal;
                    MessageBox.Show("Número encontrado.");
                }
                else
                {
                    MessageBox.Show("Número no encontrado.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btn_eliminar_b_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    double e_numero = double.Parse(txt_buscar_n.Text);
                    e_Numeros.EliminarNumero(e_numero);
                    ActualizarLista();
                    MessageBox.Show("Número eliminado.");
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, ingrese un número válido.");
                }
            }
        }
    }
}
