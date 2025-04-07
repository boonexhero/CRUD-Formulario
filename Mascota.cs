using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2_FUNPRO
{
    public class Mascota
    {
        public string e_Nombre_mascota { get; set; }
        public int e_edad { get; set; }
        public string e_raza { get; set; }
        public Dueño e_dueño { get; set; }

        public Mascota(string nombre_mascota, int edad, string raza)
        {
            e_Nombre_mascota = nombre_mascota;
            e_edad = edad;
            e_raza = raza;
        }

        public static void AgregarMascota(List<Mascota> mascotasRegistradas, Mascota nuevaMascota)
        {
            mascotasRegistradas.Add(nuevaMascota);
        }

        public static List<object> BuscarMascotas(List<Mascota> mascotasRegistradas, string textoBusqueda)
        {
            return mascotasRegistradas
                        .Where(m => m.e_Nombre_mascota.ToLower().Contains(textoBusqueda.ToLower()))
                        .Select(m => new
                        {
                            Nombre = m.e_Nombre_mascota,
                            Edad = m.e_edad,
                            Raza = m.e_raza,
                            Dueño = m.e_dueño != null ? m.e_dueño.e_Nombre_Apellido : "Desconocido"
                        })
                        .ToList<object>();
        }
    }
}
