using System;
using Models.Interfaces;

namespace Models.Compras
{
    /// <summary>
    /// Objeto simple de tipo Compra.
    /// </summary>
    public class Compra : IIdentity, IDateable, IActivable, IEmpleable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="IDateable.Fecha"/>
        public DateTime Fecha { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }

        /// <summary>
        /// Identificador único del Proveedor asociado a esta clase.
        /// </summary>
        public int IdProveedor { get; set; }

        /// <inheritdoc cref="IEmpleable.IdEmpleado"/>
        public int IdEmpleado { get; set; }
    }
}
