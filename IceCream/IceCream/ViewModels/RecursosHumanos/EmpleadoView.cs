using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCream.ViewModels.RecursosHumanos
{
    /// <summary>
    /// Objeto simple de tipo Empleado desde una vista personalizada.
    /// </summary>
    internal class EmpleadoView
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
