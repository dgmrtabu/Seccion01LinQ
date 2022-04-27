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
            //OrdenNumeros();
            //OrdenNombres();
            FiltroNumeros();
            Console.Read();
        }

        //private static void OrdenNombres()
        //{
        //    var lista = Utilidades.ObtenerListaNombres();
        //    Console.WriteLine(string.Join(" - ", lista));

        //    var listaAsc = lista.OrderBy(x => x).ToList();
        //    Console.WriteLine(string.Join(" - ", listaAsc));

        //    var listaDes = lista.OrderByDescending(x => x).ToList();
        //    Console.WriteLine(string.Join(" - ", listaDes));

        //    var listaReversada = lista.AsEnumerable().Reverse().ToList();
        //    Console.WriteLine(string.Join(" - ", listaReversada));

        //}

        //private static void OrdenNumeros()
        //{
        //    var lista = Utilidades.ObtenerListaNumeros();
        //    Console.WriteLine(string.Join(" - ", lista));

        //    var listaAsc = lista.OrderBy(x => x).ToList();
        //    Console.WriteLine(string.Join(" - ", listaAsc));

        //    var listaDes = lista.OrderByDescending(x => x).ToList();
        //    Console.WriteLine(string.Join(" - ", listaDes));

        //    var listaReversada = lista.AsEnumerable().Reverse().ToList();
        //    Console.WriteLine(string.Join(" - ", listaReversada));


        //}

        private static void FiltroNumeros()
        {
            var lista = Utilidades.ObtenerListaNumeros();
            Console.WriteLine("Lista Original");
            Console.WriteLine(string.Join(" - ", lista));

            Console.WriteLine($"Todos los elementos son mayores a 25:{ lista.All(x => x > 25)}");
            Console.WriteLine($"Todos los elementos son mayores a 0:{ lista.All(x => x > 0)}");

            Console.WriteLine($"Al menos un elemento es mayor a 100:{ lista.Any(x => x > 100)}");
            Console.WriteLine($"Al menos un elemento es mayor a 10000:{ lista.Any(x => x > 10000)}");

            Console.WriteLine($"La lista contiene el elemento 25: {lista.Contains(25)}");
            Console.WriteLine($"La lista contiene el elemento 55: {lista.Contains(55)}");

            var listaMayor10 = lista
                                    .Where(x => x > 10)
                                    .ToList();
            Console.WriteLine("Lista Mayor a 10");
            Console.WriteLine(string.Join(" - ", listaMayor10));

            Console.WriteLine();

            var listaNumeros = new List<int> { 5, 47, 65, 1000 };

            var lista2 = lista
                            .Where(x => listaNumeros.Contains(x))
                            .ToList();
            Console.WriteLine("Lista existente");
            Console.WriteLine(string.Join(" - ", lista2));

            Console.WriteLine();

            Console.WriteLine($"Existen elemntos comunes entre las 2 listas: {lista.Any(x => listaNumeros.Contains(x))}");
            Console.WriteLine($"Existen elemntos comunes entre las 2 listas: {lista.Any(x => new List<int> { 47, 65 }.Contains(x))}");

            Console.WriteLine();


        }

    }
}
