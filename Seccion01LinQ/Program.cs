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
            // FiltroNumeros();
            //FiltroNombres();
            //FiltroPersonas();
            SeleccionNumeros();
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

        //private static void FiltroNumeros()
        //{
        //    var lista = Utilidades.ObtenerListaNumeros();
        //    Console.WriteLine("Lista Original");
        //    Console.WriteLine(string.Join(" - ", lista));

        //    Console.WriteLine($"Todos los elementos son mayores a 25:{ lista.All(x => x > 25)}");
        //    Console.WriteLine($"Todos los elementos son mayores a 0:{ lista.All(x => x > 0)}");

        //    Console.WriteLine($"Al menos un elemento es mayor a 100:{ lista.Any(x => x > 100)}");
        //    Console.WriteLine($"Al menos un elemento es mayor a 10000:{ lista.Any(x => x > 10000)}");

        //    Console.WriteLine($"La lista contiene el elemento 25: {lista.Contains(25)}");
        //    Console.WriteLine($"La lista contiene el elemento 55: {lista.Contains(55)}");

        //    var listaMayor10 = lista
        //                            .Where(x => x > 10)
        //                            .ToList();
        //    Console.WriteLine("Lista Mayor a 10");
        //    Console.WriteLine(string.Join(" - ", listaMayor10));

        //    Console.WriteLine();

        //    var listaNumeros = new List<int> { 5, 47, 65, 1000 };

        //    var lista2 = lista
        //                    .Where(x => listaNumeros.Contains(x))
        //                    .ToList();
        //    Console.WriteLine("Lista existente");
        //    Console.WriteLine(string.Join(" - ", lista2));

        //    Console.WriteLine();

        //    Console.WriteLine($"Existen elemntos comunes entre las 2 listas: {lista.Any(x => listaNumeros.Contains(x))}");
        //    Console.WriteLine($"Existen elemntos comunes entre las 2 listas: {lista.Any(x => new List<int> { 47, 65 }.Contains(x))}");

        //    Console.WriteLine();
        //}

        //private static void FiltroNombres()
        //{
        //    var lista = Utilidades.ObtenerListaNombres();
        //    Console.WriteLine("Lista Original");
        //    Console.WriteLine(string.Join(" - ", lista));
        //    Console.WriteLine();

        //    Console.WriteLine($"Todos los nombres son mayores a 4 caracteres: {lista.All(x => x.Length > 4)}");
        //    Console.WriteLine($"Todos los nombres son mayores a 3 caracteres: { lista.All(x => x.Length > 3)}");
        //    Console.WriteLine($"Existe un nombre de al menos 6 caracteres: { lista.Any(x => x.Length >= 6)}");
        //    Console.WriteLine($"Existe el nombre Javier:{ lista.Contains("JAVIER")}");
        //    Console.WriteLine();

        //    var listaNombresJ = lista
        //                            .Where(x => x.StartsWith("J"))
        //                            .ToList();

        //    Console.WriteLine("La lista con J");
        //    Console.WriteLine(string.Join(" - ", listaNombresJ));

        //    var listaNombresJImpar = lista
        //                            .Where((x, y)=> x.StartsWith("J")&& y % 2 != 0)
        //                            .ToList();

        //    Console.WriteLine("La lista con J impar");
        //    Console.WriteLine(string.Join(" - ", listaNombresJImpar));

        //    Console.WriteLine();

        //    var listaNombresA = lista
        //                .Where(x => x.Contains("A"))
        //                .ToList();

        //    Console.WriteLine("La lista con A");
        //    Console.WriteLine(string.Join(" - ", listaNombresA));

        //    Console.WriteLine();

        //}

        //private static void FiltroPersonas()
        //{
        //    var lista = Utilidades.ObtenerListaPersonas();
        //    Console.WriteLine($"Todas las personas tienen fecha y nacimiento: {lista.All(x => x.FechaNacimiento.HasValue)}");
        //    Console.WriteLine($"Hay al menos una persona nacida despues del 2000-01-01: {lista.Any(x => x.FechaNacimiento >= new DateTime(2000, 1, 1))}");
        //    Console.WriteLine($"Hay al menos una persona nacida despues del 2000-01-01: {lista.Any(x => x.FechaNacimiento >= new DateTime(2020, 1, 1))}");
        //    Console.WriteLine();

        //    var listaChile = lista
        //                            .Where(x => x.PaisNacimiento == PaisEnum.Chile)
        //                            .ToList();

        //    Console.WriteLine("Lista Chile");
        //    Console.WriteLine(string.Join(" - ", listaChile));

        //    var listaPaises = new List<PaisEnum> { PaisEnum.Argentina, PaisEnum.Peru };
        //    var listaAP = lista
        //                .Where(x => listaPaises.Contains(x.PaisNacimiento) && x.Sexo == SexoEnum.Femenino)
        //                .ToList();

        //    Console.WriteLine("Lista Argentina - Peru");
        //    Console.WriteLine(string.Join(" \n ", listaAP));

        //    var listaMultifono = lista
        //                .Where(x => x.ListaTelefonos.Count > 1)
        //                .ToList();

        //    Console.WriteLine("Lista Multifono");
        //    Console.WriteLine(string.Join(" \n ", listaMultifono));

        //}

        private static void SeleccionNumeros()
        {
            var listaNumeros = Utilidades.ObtenerListaNumeros();
            Console.WriteLine(string.Join(" - ", listaNumeros));

            var listaCuadrado = listaNumeros.Select(x => x * x).ToList();
            Console.WriteLine(string.Join(" - ", listaCuadrado));

            var listaPosicion = listaNumeros.Select((x,y) => x * y).ToList();
            Console.WriteLine(string.Join(" - ", listaPosicion));
            
            Console.WriteLine(string.Join(" - ", listaNumeros.Select((x,y)=>y.ToString().PadLeft(7,' '))));
            Console.WriteLine(string.Join(" - ", listaNumeros.Select(x => x.ToString().PadLeft(7,' '))));
            Console.WriteLine(string.Join(" - ", listaCuadrado.Select(x => x.ToString().PadLeft(7,' '))));
            Console.WriteLine(string.Join(" - ", listaPosicion.Select(x => x.ToString().PadLeft(7,' '))));

            var listaElevados = listaNumeros
                                            .Select(x => new { Numero = x, Cuadrado = x * x, Cubo = x * x })
                                            .ToList();
            foreach(var item in listaElevados)
            {
                Console.WriteLine($"{ item.Numero} --> {item.Cuadrado} --> {item.Cubo}");
            }
        }

    }
}
