using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_FUNPRO
{
    public class Dueño
    {
        public string e_Nombre_Apellido { get; set; }
        public string e_Direccion { get; set; }
        public string e_Telefono { get; set; }

        //Vamos agregar comentarios en nuestra linea de codigo , para subirlo a GitHub

        public Dueño(string nombre_apellido, string direccion, string telefono)
        {
            e_Nombre_Apellido = nombre_apellido;
            e_Direccion = direccion;
            e_Telefono = telefono;
        }
        public static void AgregarDueño(List<Dueño> dueñosRegistrados, Dueño nuevoDueño)
        {
            dueñosRegistrados.Add(nuevoDueño);
        }
        public string Lista_dueño_Registrado
        {
            get { return $"{e_Nombre_Apellido} / {e_Direccion} / {e_Telefono}"; }
        }
    }
}
