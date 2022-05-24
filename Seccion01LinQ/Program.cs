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
        static void Main(string[] args)
        {
            //OrdenNumeros();
            //OrdenNombres();
            // FiltroNumeros();
            //FiltroNombres();
            //FiltroPersonas();
            //SeleccionNumeros();
            //SeleccionPersonas();
            //SeleccionElementosNumeros();
            //SeleccionElementosNombres();
            //SeleccionElementosPersonas();
            //MetodosAgregadosNumeros_1();
            //MetodosAgregadosNumeros_2();
            MetodosAgregadosNombres();
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

        //private static void SeleccionNumeros()
        //{
        //    var listaNumeros = Utilidades.ObtenerListaNumeros();
        //    Console.WriteLine(string.Join(" - ", listaNumeros));

        //    var listaCuadrado = listaNumeros.Select(x => x * x).ToList();
        //    Console.WriteLine(string.Join(" - ", listaCuadrado));

        //    var listaPosicion = listaNumeros.Select((x,y) => x * y).ToList();
        //    Console.WriteLine(string.Join(" - ", listaPosicion));

        //    Console.WriteLine(string.Join(" - ", listaNumeros.Select((x,y)=>y.ToString().PadLeft(7,' '))));
        //    Console.WriteLine(string.Join(" - ", listaNumeros.Select(x => x.ToString().PadLeft(7,' '))));
        //    Console.WriteLine(string.Join(" - ", listaCuadrado.Select(x => x.ToString().PadLeft(7,' '))));
        //    Console.WriteLine(string.Join(" - ", listaPosicion.Select(x => x.ToString().PadLeft(7,' '))));

        //    var listaElevados = listaNumeros
        //                                    .Select(x => new { Numero = x, Cuadrado = x * x, Cubo = x * x })
        //                                    .ToList();
        //    foreach(var item in listaElevados)
        //    {
        //        Console.WriteLine($"{ item.Numero} --> {item.Cuadrado} --> {item.Cubo}");
        //    }
        //}

        //private static void SeleccionNumeros()
        //{
        //    var listaNombre = Utilidades.ObtenerListaNombres();
        //    Console.WriteLine(string.Join(" - ", listaNombre));

        //    var listaFormateada = listaNombre.Select((x, y) => $"{(y + 1).ToString().PadLeft(3, '0')} {x}").ToList();
        //    Console.WriteLine(string.Join("\n", listaFormateada));
        //    Console.WriteLine();

        //    var listaNumeros = Utilidades.ObtenerListaNumeros();

        //    var listaResultado = listaNombre
        //                                    .SelectMany(x => listaNumeros,
        //                                            (nombre, num) =>
        //                                            new
        //                                            {
        //                                                Nombre = nombre,
        //                                                Numero = num
        //                                            })
        //                                    .ToList();
        //    foreach(var item in listaResultado)
        //    {
        //        Console.WriteLine($"{item.Nombre} --> {item.Numero}");
        //    }
        //}

        //private static void SeleccionPersonas()
        //{
        //    var lista = Utilidades.ObtenerListaPersonas();
        //    var listaNombre = lista
        //                            .Where(x => x.Sexo == SexoEnum.Femenino)
        //                            .Select(x => $"{x.Nombre} {x.ApellidoPaterno}")
        //                            .OrderBy(x => x)
        //                            .ToList();
        //    Console.WriteLine(string.Join(" - ", listaNombre));

        //    Console.WriteLine();
        //    var listapersonaTelefono = lista
        //                                    .Select(x => new { NombreCompleto = $"{x.Nombre} {x.ApellidoPaterno}", x.ListaTelefonos })
        //                                    .Select(x => $"{x.NombreCompleto} {string.Join(" - ", x.ListaTelefonos.Select(y => $"{y.CodigoPais} - {y.Numero}"))}")
        //                                    .ToList();
        //    Console.WriteLine(string.Join(" \n ", listapersonaTelefono));
        //    Console.WriteLine();

        //    var listaEdad = lista
        //                        .Select(x => new
        //                        {
        //                            NombreCompleto = $"{x.Nombre} {x.ApellidoPaterno}",
        //                            x.FechaNacimiento,
        //                            Edad = x.FechaNacimiento.HasValue ? (int?)DateTime.Now.AddTicks(-x.FechaNacimiento.Value.Ticks).Year - 1 : null
        //                        })
        //                        .ToList();
        //    foreach(var item in listaEdad)
        //    {
        //        Console.WriteLine($"{item.NombreCompleto} {(item.FechaNacimiento.HasValue ? $"nacido(a) el {item.FechaNacimiento.Value.ToString("dd-MM-yyyy")}" : "Sin informacion de nacimiento")} {(item.Edad.HasValue ? $"con una edad de {item.Edad}": string.Empty)}");
        //    }
        //    Console.WriteLine();

        //    var listaTelefonos = lista
        //                            .SelectMany(x => x.ListaTelefonos)
        //                            .ToList();
        //    Console.WriteLine(string.Join(" \n ", listaTelefonos.Select(x => $"{x.CodigoPais} {x.Numero}")));
        //    Console.WriteLine();
        //}

        private static void SeleccionElementosNumeros()
        {
            var listaNumeros = Utilidades.ObtenerListaNumeros()
                                                                .Select(x => (int?)x).ToList();
            Console.WriteLine(string.Join(" - ", listaNumeros));

            var primeroDefault = listaNumeros.FirstOrDefault();
            var primeroCondicionDefault = listaNumeros.FirstOrDefault(x => x ==500);
            var ultimoCondicionDefault1 = listaNumeros.LastOrDefault(x => x < 25 && x > 5);
            var ultimoCondicionDefault2 = listaNumeros.LastOrDefault(x => x > 5000);
            var elementoEspecificoDefault1 = listaNumeros.ElementAtOrDefault(5);
            var elementoEspecificoDefault2 = listaNumeros.ElementAtOrDefault(15);

            var primero = listaNumeros.First();
            //var primeroCondicion = listaNumeros.First(x => x == 500);
            var ultimo = listaNumeros.Last();
            var ultimoCondicion1 = listaNumeros.Last(x => x < 25 && x > 5);
            //var ultimoCondicion2 = listaNumeros.Last(x => x > 5000);
            var elementoEspecifico1 = listaNumeros.ElementAtOrDefault(5);
            //var elementoEspecifico2 = listaNumeros.ElementAtOrDefault(15);
        }


        private static void SeleccionElementosNombres()
        {
            var listaNombres = Utilidades.ObtenerListaNombres();
                                                                
            Console.WriteLine(string.Join(" - ", listaNombres));

            var primeroDefaultEmpiezaConJ = listaNombres.FirstOrDefault(x => x.StartsWith("J"));
            var primeroDefaultEmpiezaConG = listaNombres.FirstOrDefault(x => x.StartsWith("G"));
            var ultimoDefaultEmpiezaConG = listaNombres.LastOrDefault(x => x.StartsWith("J"));

            var primeroEmpiezaConJ = listaNombres.First(x => x.StartsWith("J"));
            //var primeroEmpiezaConG = listaNombres.First(x => x.StartsWith("G"));
            var ultimoEmpiezaConJ = listaNombres.Last(x => x.StartsWith("J"));
        }

        private static void SeleccionElementosPersonas()
        {
            var listaPersonas = Utilidades.ObtenerListaPersonas();

           Console.WriteLine();
            //Console.WriteLine(string.Join(" - ", listaNombres));

            var persona = listaPersonas.FirstOrDefault(x => x.Nombre == "Sin Nombre");

            // obtener primera persona de Sexo femenino en la lista
            var personaSexoFemenino = listaPersonas.FirstOrDefault(x => x.Sexo == SexoEnum.Femenino);
            // obtener la persona de mas edad de la lista
            var personaMasEdad = listaPersonas
                                                .Where(x => x.FechaNacimiento.HasValue)
                                                .OrderBy(x => x.FechaNacimiento)
                                                .FirstOrDefault();
            // obtener la persona de menos edad de la lista
            var personaMenosEdad1 = listaPersonas
                                                .Where(x => x.FechaNacimiento.HasValue)
                                                .OrderByDescending(x => x.FechaNacimiento)
                                                .FirstOrDefault();

            var personaMenosEdad2 = listaPersonas
                                    .Where(x => x.FechaNacimiento.HasValue)
                                    .OrderBy(x => x.FechaNacimiento)
                                    .LastOrDefault();
        }

        private static void MetodosAgregadosNumeros_1()
        {
            var lista = Utilidades.ObtenerListaNumeros();
            Console.WriteLine(string.Join(" - ", lista));

            var minimo = lista.Min();
            var maximo = lista.Max();
            var promedio = lista.Average();
            var contador = lista.Count();
            var suma = lista.Sum();

            Console.WriteLine($"Minimo: {minimo}, Maximo: {maximo}, Promedio: {promedio}");
            Console.WriteLine($"Total Elememntos: {contador}, Suma: {suma}");
            Console.WriteLine();

            #region Contador
            var contadorMenorIgual10 = lista.Count(x => x <= 10);
            var contadorMayor10 = lista.Count(x => x > 10);
            Console.WriteLine($"Menores iguales a 10: { contadorMenorIgual10 }, mayores a 10: {contadorMayor10}");
            Console.WriteLine();

            var contadorMenorIgual10_2 = lista.Count(x =>
            {
                return x <= 10;
            });
            var contadorMayor10_2 = lista.Count(x => { 
                if(x > 10)
                {
                    return true;
                }
                {
                    return false;
                }
            });
            Console.WriteLine($"Menores iguales a 10: { contadorMenorIgual10_2 }, mayores a 10: { contadorMayor10_2 }");
            Console.WriteLine();
            #endregion

            #region Suma
            var sumaMenorIgual10 = lista.Sum(x => x <= 10 ? x : 0);
            var sumaMayor10 = lista.Sum(x => x > 10 ? x : 0);
            Console.WriteLine($"Menores iguales a 10: { sumaMenorIgual10 }, mayores a 10: {sumaMayor10}");
            Console.WriteLine();

            var sumaMenorIgual10_2 = lista.Count(x =>
            {
                return x <= 10;
            });
            var sumaMayor10_2 = lista.Sum(x => {
                if (x > 10)
                {
                    return x;
                }
                {
                    return 0;
                }
            });
            Console.WriteLine($"Menores iguales a 10: { sumaMenorIgual10_2 }, mayores a 10: { sumaMayor10_2 }");
            Console.WriteLine();
            #endregion

        }

        //private static void MetodosAgregadosNumeros_2()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine();
        //    Console.WriteLine("---------------------Aggregate----------------");

        //    var lista = Utilidades.ObtenerListaNumeros();

        //    #region Suma

        //    //var suma1 = lista.Aggregate((x, y) => {
        //    //    Console.WriteLine($"X:{x},Y:{y}");
        //    //    return x + y ;
        //    //});

        //    var suma1 = lista.Aggregate((x, y) => x + y);
        //    var suma2 = lista.Aggregate(0, (acumulado, x) => acumulado + x);
        //    Console.WriteLine($"Suma 1: {suma1}, Suma 2: {suma2}");

        //    var sumaMenorIgual10 = lista.Aggregate(0, (acumulado, x) => x <= 10 ? acumulado + x: acumulado);
        //    var sumaMayor10 = lista.Aggregate(0, (acumulado, x) => x > 10 ? acumulado + x : acumulado);
        //    Console.WriteLine($"Menores iguales a 10: { sumaMenorIgual10 }, mayores a 10: {sumaMayor10}");
        //    Console.WriteLine();

        //    var sumaMenorIgual10_2 = lista.Aggregate(0,(acumulado, x) =>
        //    {
        //        return x <= 10 ? acumulado + x : acumulado;
        //    });
        //    var sumaMayor10_2 = lista.Aggregate(0, (acumulado, x) => {
        //        if (x > 10)
        //        {
        //            return acumulado + x;
        //        }
        //        {
        //            return acumulado;
        //        }
        //    });
        //    Console.WriteLine($"Menores iguales a 10: { sumaMenorIgual10_2 }, mayores a 10: { sumaMayor10_2 }");
        //    Console.WriteLine();
        //    #endregion

        //    #region Contador
        //    var contadorMenorIgual10 = lista.Aggregate(0, (acumulado,x) => x <= 10 ? ++acumulado : acumulado);
        //    var contadorMayor10 = lista.Aggregate(0, (acumulado, x) => x > 10 ? ++acumulado : acumulado);
        //    Console.WriteLine($"Menores iguales a 10: { contadorMenorIgual10 }, mayores a 10: {contadorMayor10}");
        //    Console.WriteLine();

        //    var contadorMenorIgual10_2 = lista.Aggregate(0, (acumulado, x) =>
        //    {
        //        return x <= 10 ? ++acumulado : acumulado;
        //    });
        //    var contadorMayor10_2 = lista.Aggregate(0, (acumulado, x) =>
        //    {
        //        if (x > 10)
        //        {
        //            return ++acumulado;
        //        }
        //        {
        //            return acumulado;
        //        }
        //    });
        //    Console.WriteLine($"Menores iguales a 10: { contadorMenorIgual10_2 }, mayores a 10: { contadorMayor10_2 }");
        //    Console.WriteLine();
        //    #endregion

        //    #region Minimo, Maximo, Promedio

        //    var minimo = lista.Aggregate((x, y) => x < y ? x : y);
        //    var maximo = lista.Aggregate((x, y) => x > y ? x : y);
        //    var promedio = lista.Aggregate(0,
        //                                    (acumulado, x) => acumulado + x,
        //                                    valorFinal => (double)valorFinal / lista.Count
        //                                    );
        //    Console.WriteLine($"Minimo:{minimo}, Maximo:{maximo}, Promedio:{promedio}");

        //    #endregion

        //    #region Extras

        //    // Multiplicacion
        //    var multiplicacion = lista.Aggregate(1, (acumulado, x) => acumulado * x);
        //    Console.WriteLine($"Multiplicacion: {multiplicacion.ToString("N0")}");
        //    #endregion

        //    //StrigJoin
        //    var stringjoin = lista.Aggregate(string.Empty, (acumulado, x) => $"{acumulado}{x},", valorFinal => valorFinal.TrimEnd(',')
        //    );                           
        //    Console.WriteLine($"stringJoin: {stringjoin}");

        //    // ListaFiltrada > 10
        //    var listaFiltrada = lista.Aggregate(new List<int>(),
        //                                    (acumulado, x) =>
        //                                    {
        //                                        if (x > 10)
        //                                        {
        //                                            acumulado.Add(x);
        //                                        }
        //                                        return acumulado;
        //                                    }
        //                                    );
        //    Console.WriteLine($"Lista filtrada: {string.Join(" - ", listaFiltrada)}");
        //}

        private static void MetodosAgregadosNombres()
        {
            var listaNombres = Utilidades.ObtenerListaNombres();
            Console.WriteLine(string.Join(" - ", listaNombres));

            var minimo = listaNombres.Min();
            var maximo = listaNombres.Max();
            var contador = listaNombres.Count();

            Console.WriteLine($"Minimo: { minimo }, Maximo: {maximo}, Contador:{contador}");
            Console.WriteLine();

            // Transformar los nombres a nobres sin vocales
            var listaSinVocales = listaNombres
                                            .Select(i => i.ToUpper()
                                                                .Aggregate(new StringBuilder(),
                                                                (acumulado, x) =>
                                                                {
                                                                    var vocales = new List<char> { 'A', 'E', 'I', 'O', 'U' };
                                                                    if (!vocales.Contains(x))
                                                                    {
                                                                        acumulado.Append(x);
                                                                    }
                                                                    return acumulado;
                                                                }
                                                                )
                                            );
            Console.WriteLine(string.Join(" - ", listaSinVocales));
            Console.WriteLine();

            // Crear lista con 2 propiedades Nombre y Vocales que contiene
            var listaNombreVocales = listaNombres
                                .Select(i => new
                                {
                                    Nombre = i,
                                    Vocales = i.ToUpper()
                                                    .Aggregate(new StringBuilder(),
                                                    (acumulado, x) =>
                                                    {
                                                        var vocales = new List<char> { 'A', 'E', 'I', 'O', 'U' };
                                                        if (vocales.Contains(x))
                                                        {
                                                            acumulado.Append(x);
                                                        }
                                                        return acumulado;
                                                    })
                                }
                                ).ToList();
            foreach(var item in listaNombreVocales)
            {
                Console.WriteLine($"Nombre: {item.Nombre}, Vocales: {item.Vocales}");
            }
            
            Console.WriteLine();

            // Crear lista con 2 propiedades Nombre y Cantidades de vocales que contiene
            var listaNombreCantidadVocales = listaNombres
                                .Select(i => new
                                {
                                    Nombre = i,
                                    CantidadVocales = i.ToUpper()
                                                    .Aggregate(new StringBuilder(),
                                                    (acumulado, x) =>
                                                    {
                                                        var vocales = new List<char> { 'A', 'E', 'I', 'O', 'U' };
                                                        if (vocales.Contains(x))
                                                        {
                                                            acumulado.Append(x);
                                                        }
                                                        return acumulado;
                                                    }, 
                                                    valorFinal => valorFinal.Length)
                                }
                                ).ToList();
            foreach (var item in listaNombreCantidadVocales)
            {
                Console.WriteLine($"Nombre: {item.Nombre}, Vocales: {item.CantidadVocales}");
            }

            Console.WriteLine();

            // Verificar si tiene todas las vocales
            // Var diccionario = new Dictionary<char, int>() {['A']=0, ['E']=0, ['I']=0, ['O']=0, ['U']=0};
            var listaAnimales = new List<string> { "ELEFANTES", "MURCIELAGO" };
            var listaNombreTodasVocales = listaAnimales
                                .Select(i => new
                                {
                                    Nombre = i,
                                    TodasVocales = i.ToUpper()
                                                    .Aggregate(new Dictionary<char, int>() { ['A'] = 0, ['E'] = 0, ['I'] = 0, ['O'] = 0, ['U'] = 0 },
                                                    (acumulado, x) =>
                                                    {
                                                        if (acumulado.ContainsKey(x))
                                                        {
                                                            acumulado[x] += 1;
                                                        }
                                                        return acumulado;
                                                    }, valorFinal => valorFinal.All(y => y.Value > 0)
                                                    )
                                }).ToList();
            foreach (var item in listaNombreTodasVocales)
            {
                Console.WriteLine($"Nombre: {item.Nombre}, Vocales: {item.TodasVocales}");
            }

            Console.WriteLine();

        }
    }
}