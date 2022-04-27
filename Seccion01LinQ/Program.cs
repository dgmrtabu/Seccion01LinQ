using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion01LinQ
{
    class Program
    {
        static void Main(string [] args)
        {
            OrdenNumeros();
            OrdenNombres();
            Console.Read();
        }

        private static void OrdenNombres()
        {
            var lista = Utilidades.ObtenerListaNombres();
            Console.WriteLine(string.Join(" - ", lista));

            var listaAsc = lista.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(" - ", listaAsc));

            var listaDes = lista.OrderByDescending(x => x).ToList();
            Console.WriteLine(string.Join(" - ", listaDes));

            var listaReversada = lista.AsEnumerable().Reverse().ToList();
            Console.WriteLine(string.Join(" - ", listaReversada));

        }

        private static void OrdenNumeros()
        {
            var lista = Utilidades.ObtenerListaNumeros();
            Console.WriteLine(string.Join(" - ", lista));

            var listaAsc = lista.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(" - ", listaAsc));

            var listaDes = lista.OrderByDescending(x => x).ToList();
            Console.WriteLine(string.Join(" - ", listaDes));

            var listaReversada = lista.AsEnumerable().Reverse().ToList();
            Console.WriteLine(string.Join(" - ", listaReversada));


        }

    }
}
