using Models.Interfaces;
using System.Drawing;

namespace Models.RecursosHumanos
{
    /// <summary>
    /// Objeto simple de tipo Empleado.
    /// </summary>
    public class Empleado : IIdentity, IPerson, IActivable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="IPerson.PrimerNombre"/>
        public string PrimerNombre { get; set; }

        /// <inheritdoc cref="IPerson.SegundoNombre"/>
        public string SegundoNombre { get; set; }

        /// <inheritdoc cref="IPerson.PrimerApellido"/>
        public string PrimerApellido { get; set; }

        /// <inheritdoc cref="IPerson.PrimerApellido"/>
        public string SegundoApellido { get; set; }

        /// <summary>
        /// Número de cédula del Empleado.
        /// </summary>
        public string Cedula { get; set; }

        /// <inheritdoc cref="IPerson.Telefono"/>
        public string Telefono { get; set; }

        /// <inheritdoc cref="IPerson.Direccion"/>
        public string Direccion { get; set; }

        /// <summary>
        /// Fotografía del Empleado para facilitar su reconocimiento.
        /// </summary>
        public Image Foto { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }

        /// <inheritdoc cref="IPerson.IdMunicipio"/>
        public int IdMunicipio { get; set; }
    }
}
