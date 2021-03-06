using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion01LinQ
{
    public enum SexoEnum
    {
        Femenino = 1,
        Masculino = 2,
    }

    public enum PaisEnum
    {
        Chile = 1,
        Argentina = 2,
        Peru = 3,
        Bolivia = 4,
        Uruguay = 5,
        Brasil = 6,
        Ecuador = 7,
        Colombia = 8,
        Venezuela = 9,
        Paraguay = 10,
    }

    public enum ClasificacionTipoTelefonoEnum
    {
        Fijo = 1,
        Celular = 2
    }

    public class Persona
    {
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public SexoEnum Sexo { get; set; }
        public PaisEnum PaisNacimiento { get; set; }
        public List<Telefono> ListaTelefonos { get; set; }

        public override string ToString()
        {
            return $"{(FechaNacimiento.HasValue ? FechaNacimiento.Value.ToString("dd-MM-yyyy"): "S/F")} --> { Nombre} {ApellidoPaterno}";
        }
    }

    public class PersonaReducida
    {
        public string Rut { get; set; }
        public string NombreCompleto { get; set; }
        public int? Edad { get; set; }
        public SexoEnum Sexo { get; set; }
    }
    public class Telefono
    {
        public int CodigoPais { get; set; }
        public string Numero { get; set; }
        public ClasificacionTipoTelefonoEnum Tipo { get; set; }
    }

}
