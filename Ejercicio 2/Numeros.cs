using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Numeros
    {
        public List<double> e_Lista { get; set; }

        public Numeros()
        {
            e_Lista = new List<double>();
        }

        public void InsertarNumero(double numero)
        {
            e_Lista.Add(numero);
        }

        public void OrdenarAscendente()
        {
            e_Lista.Sort();
        }

        public void OrdenarDescendente()
        {
            e_Lista.Sort((a, b) => b.CompareTo(a));
        }

        public bool BuscarNumero(double numero)
        {
            return BuscarNumeroRecursivo(e_Lista, numero, 0);
        }

        private bool BuscarNumeroRecursivo(List<double> lista, double numero, int index)
        {
            if (index >= lista.Count)
                return false;
            if (lista[index] == numero)
                return true;
            return BuscarNumeroRecursivo(lista, numero, index + 1);
        }

        public void EliminarNumero(double numero)
        {
            e_Lista.Remove(numero);
        }

        public void MostrarLista()
        {
            Console.WriteLine(string.Join(", ", e_Lista));
        }
    }
}