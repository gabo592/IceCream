using System;

namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee un atributo de Fecha para manejar una transacción.
    /// </summary>
    public interface IDateable
    {
        /// <summary>
        /// Fecha en la que se realizó la transacción.
        /// </summary>
        DateTime Fecha { get; set; }
    }
}
