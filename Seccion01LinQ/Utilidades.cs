using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion01LinQ
{
    public static class Utilidades
    {
        public static List<Persona> ObtenerListaPersonas()
        {
            var lista = new List<Persona>
            {
                new Persona
                {
                    Rut = "101766810",
                    Nombre = "Isaac",
                    ApellidoPaterno = "Asimov",
                    ApellidoMaterno = "",
                    FechaNacimiento = new DateTime(1920, 1, 2),
                    Sexo = SexoEnum.Masculino,
                    PaisNacimiento = PaisEnum.Chile,
                    ListaTelefonos = new List<Telefono>() { new Telefono { CodigoPais = 56 , Numero = "1122334455", Tipo = ClasificacionTipoTelefonoEnum.Celular } }
                },
                new Persona
                {
                    Rut = "142913828",
                    Nombre = "Poul",
                    ApellidoPaterno = "Anderson",
                    ApellidoMaterno = "",
                    FechaNacimiento = new DateTime(1926, 11, 25),
                    Sexo = SexoEnum.Masculino,
                    PaisNacimiento = PaisEnum.Argentina,
                    ListaTelefonos = new List<Telefono>() { new Telefono { CodigoPais = 56, Numero = "1234567890", Tipo = ClasificacionTipoTelefonoEnum.Celular } }
                },
                new Persona
                {
                    Rut = "22968540-6",
                    Nombre = "Vladimir",
                    ApellidoPaterno = "Bartol",
                    ApellidoMaterno = "",
                    FechaNacimiento = new DateTime(1903, 2, 24),
                    Sexo = SexoEnum.Masculino,
                    PaisNacimiento = PaisEnum.Peru,
                    ListaTelefonos = new List<Telefono>() { new Telefono { CodigoPais = 56, Numero =  "0987654321", Tipo = ClasificacionTipoTelefonoEnum.Celular } }
                },
                new Persona
                {
                    Rut = "10261356-2",
                    Nombre = "Jack",
                    ApellidoPaterno = "Williamson",
                    ApellidoMaterno = "",
                    FechaNacimiento = new DateTime(1908, 4, 29),
                    Sexo = SexoEnum.Masculino,
                    PaisNacimiento = PaisEnum.Bolivia,
                    ListaTelefonos = new List<Telefono>() { new Telefono { CodigoPais = 56, Numero = "9988776655", Tipo = ClasificacionTipoTelefonoEnum.Fijo }, new Telefono { CodigoPais = 56, Numero = "5566778899", Tipo = ClasificacionTipoTelefonoEnum.Celular } }
                },
                new Persona
                {
                    Rut = "5180205-5",
                    Nombre = "Frederik",
                    ApellidoPaterno = "Pohl",
                    ApellidoMaterno = "",
                    FechaNacimiento = new DateTime(1919, 11, 26),
                    Sexo = SexoEnum.Masculino,
                    PaisNacimiento = PaisEnum.Uruguay,
                    ListaTelefonos = new List<Telefono>() { new Telefono { CodigoPais = 56, Numero = "4433221100", Tipo = ClasificacionTipoTelefonoEnum.Celular } }
                },
                new Persona
                {
                    Rut = "20933277-9",
                    Nombre = "Ursula",
                    ApellidoPaterno = "Poznanski",
                    ApellidoMaterno = "",
                    FechaNacimiento = new DateTime(1968, 10, 30),
                    Sexo = SexoEnum.Femenino,
                    PaisNacimiento = PaisEnum.Paraguay,
                    ListaTelefonos = new List<Telefono>() { new Telefono { CodigoPais = 56, Numero = "1112223334", Tipo = ClasificacionTipoTelefonoEnum.Celular } }
                },
                new Persona
                {
                    Rut = "19246439-0",
                    Nombre = "Ursula",
                    ApellidoPaterno = "Le Guin",
                    ApellidoMaterno = "",
                    FechaNacimiento = new DateTime(1929, 10, 21),
                    Sexo = SexoEnum.Femenino,
                    PaisNacimiento = PaisEnum.Ecuador,
                    ListaTelefonos = new List<Telefono>() { new Telefono { CodigoPais = 56, Numero = "4445556667", Tipo = ClasificacionTipoTelefonoEnum.Celular } }
                },
                new Persona
                {
                    Rut = "19241025-8",
                    Nombre = "Dan",
                    ApellidoPaterno = "Simmons",
                    ApellidoMaterno = "",
                    FechaNacimiento = new DateTime(1948, 4, 4),
                    Sexo = SexoEnum.Masculino,
                    PaisNacimiento = PaisEnum.Venezuela,
                    ListaTelefonos = new List<Telefono>() { new Telefono { CodigoPais = 56, Numero = "7778889990", Tipo = ClasificacionTipoTelefonoEnum.Fijo } }
                },
                new Persona
                {
                    Rut = "16521715-2",
                    Nombre = "Stieg",
                    ApellidoPaterno = "Larsson",
                    ApellidoMaterno = "",
                    FechaNacimiento = new DateTime(1954, 8, 15),
                    Sexo = SexoEnum.Masculino,
                    PaisNacimiento = PaisEnum.Colombia,
                    ListaTelefonos = new List<Telefono>() { new Telefono { CodigoPais = 56, Numero = "1111122222", Tipo = ClasificacionTipoTelefonoEnum.Fijo } }
                },
                new Persona
                {
                    Rut = "24715367-5",
                    Nombre = "Lisbeth",
                    ApellidoPaterno = "Salander",
                    ApellidoMaterno = "",
                    FechaNacimiento = null,
                    Sexo = SexoEnum.Femenino,
                    PaisNacimiento = PaisEnum.Chile,
                    ListaTelefonos = new List<Telefono>() { new Telefono { CodigoPais = 56, Numero = "3333344444", Tipo = ClasificacionTipoTelefonoEnum.Fijo } }
                },
                new Persona
                {
                    Rut = "20002796-5",
                    Nombre = "Aria",
                    ApellidoPaterno = "Stark",
                    ApellidoMaterno = "",
                    FechaNacimiento = null,
                    Sexo = SexoEnum.Femenino,
                    PaisNacimiento = PaisEnum.Argentina,
                    ListaTelefonos = new List<Telefono>() { new Telefono { CodigoPais = 56, Numero = "5555566666", Tipo = ClasificacionTipoTelefonoEnum.Fijo } }
                },
                new Persona
                {
                    Rut = "12907504K",
                    Nombre = "Aenea",
                    ApellidoPaterno = "Lamia",
                    ApellidoMaterno = "",
                    FechaNacimiento = new DateTime(2003, 01, 13),
                    Sexo = SexoEnum.Femenino,
                    PaisNacimiento = PaisEnum.Peru,
                    ListaTelefonos = new List<Telefono>() { new Telefono { CodigoPais = 56, Numero = "7777788888", Tipo = ClasificacionTipoTelefonoEnum.Fijo } }
                },
                new Persona
                {
                    Rut = "60666350",
                    Nombre = "Arcadia",
                    ApellidoPaterno = "Darell",
                    ApellidoMaterno = "",
                    FechaNacimiento = new DateTime(2010, 1, 31),
                    Sexo = SexoEnum.Femenino,
                    PaisNacimiento = PaisEnum.Peru,
                    ListaTelefonos = new List<Telefono>() { new Telefono { CodigoPais = 56, Numero = "3333333333", Tipo = ClasificacionTipoTelefonoEnum.Fijo } }
                },
                new Persona
                {
                    Rut = "227245158",
                    Nombre = "Hari",
                    ApellidoPaterno = "Seldon",
                    ApellidoMaterno = "",
                    FechaNacimiento = new DateTime(2003, 2, 13),
                    Sexo = SexoEnum.Masculino,
                    PaisNacimiento = PaisEnum.Brasil,
                    ListaTelefonos = new List<Telefono>() { new Telefono { CodigoPais = 56, Numero = "6666666666", Tipo = ClasificacionTipoTelefonoEnum.Celular } }
                },
                new Persona
                {
                    Rut = "9085368-6",
                    Nombre = "Daneel",
                    ApellidoPaterno = "Olivaw",
                    ApellidoMaterno = "",
                    FechaNacimiento = null,
                    Sexo = SexoEnum.Femenino,
                    PaisNacimiento = PaisEnum.Brasil,
                    ListaTelefonos = new List<Telefono>() { new Telefono { CodigoPais = 56, Numero =  "9999999999", Tipo = ClasificacionTipoTelefonoEnum.Celular } }
                },
            };

            return lista;
        }


        public static List<string> ObtenerListaNombres()
        {
            return new List<string> { "MAURICIO", "ALEX", "PABLO", "JORGE", "CLAUDIO", "SERGIO", "JAVIER", "JOSE" };
        }

        public static List<int> ObtenerListaNumeros()
        {
            return new List<int> { 5, 15, 7, 3, 4, 10, 1, 25, 1000 };
        }

    }
}
