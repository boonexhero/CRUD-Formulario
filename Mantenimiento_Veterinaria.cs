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
    public partial class Mantenimiento_Veterinaria : Form
    {
        private List<Dueño> e_dueñosRegistrados = new List<Dueño>();
       

        private List<Mascota> e_mascotasRegistradas = new List<Mascota>();
        public Mantenimiento_Veterinaria()
        {
            InitializeComponent();
            ActualizarComboBoxDueños();
        }

        private void Mantenimiento_Veterinaria_Load(object sender, EventArgs e)
        {

        }

        private void ActualizarComboBoxDueños()
        {
            cbo_dueño.DataSource = null;
            cbo_dueño.DataSource = e_dueñosRegistrados;
            cbo_dueño.DisplayMember = "e_Nombre_Apellido";
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nomape.Text.Trim()) || string.IsNullOrEmpty(txt_direccion.Text.Trim()) || string.IsNullOrEmpty(txt_telefono.Text.Trim()))
            {
                MessageBox.Show("Todos los campos deben ser completados.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_telefono.Text.Trim().Length < 9)
            {
                MessageBox.Show("El teléfono debe tener al menos 9 números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txt_telefono.Text.Trim().All(char.IsDigit))
            {
                MessageBox.Show("El teléfono solo debe contener números.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dueño e_nuevoDueño = new Dueño(txt_nomape.Text.Trim(), txt_direccion.Text.Trim(), txt_telefono.Text.Trim());
            Dueño.AgregarDueño(e_dueñosRegistrados, e_nuevoDueño);

            ActualizarComboBoxDueños();

            MessageBox.Show("Dueño registrado exitosamente");

            lsb_dueño.DisplayMember = "Lista_dueño_Registrado";
            lsb_dueño.Items.Add(e_nuevoDueño);
            LimpiarTextBox();
        }
        private void LimpiarTextBox()
        {
            txt_nomape.Clear();
            txt_direccion.Clear();
            txt_telefono.Clear();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBox();
        }

        private void btn_registrar_m_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nom_mas.Text) ||
                string.IsNullOrWhiteSpace(txt_edad_m.Text) ||
                string.IsNullOrWhiteSpace(txt_raza_m.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Dueño e_dueñoSeleccionado = cbo_dueño.SelectedItem as Dueño;
            if (e_dueñoSeleccionado == null)
            {
                MessageBox.Show("Por favor, seleccione un dueño válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int edadMascota = int.Parse(txt_edad_m.Text);

                Mascota e_nuevaMascota = new Mascota(txt_nom_mas.Text, edadMascota, txt_raza_m.Text)
                {
                    e_dueño = e_dueñoSeleccionado
                };

                Mascota.AgregarMascota(e_mascotasRegistradas, e_nuevaMascota);

                MessageBox.Show("Mascota registrada exitosamente");

                LimpiarTextBoxMascota();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese una edad válida para la mascota.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarTextBoxMascota()
        {
            txt_nom_mas.Clear();
            txt_edad_m.Clear();
            txt_raza_m.Clear();
            cbo_dueño.SelectedIndex = -1; 
        }

        private void btn_buscar_m_Click(object sender, EventArgs e)
        {
            string e_textoBusqueda = txt_mascota_b.Text.Trim().ToLower();

            var e_resultados = Mascota.BuscarMascotas(e_mascotasRegistradas, e_textoBusqueda);

            data_mascota.DataSource = e_resultados;

            if (e_resultados.Count == 0)
            {
                MessageBox.Show("No se encontraron mascotas con ese nombre.");
            }
        }

        private void btn_limpiar_m_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxMascota();
        }
    }
}
