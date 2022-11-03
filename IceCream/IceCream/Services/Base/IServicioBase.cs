using System;

namespace IceCream.Services.Base
{
    /// <summary>
    /// Indica que una clase tendrá los elementos base para proveer servicios a otras clases.
    /// </summary>
    internal interface IServicioBase : IDisposable
    {
        /// <summary>
        /// Busca dentro del administrador de errores si éste contiene errores almacenados. De ser así, obtiene todos los mensajes.
        /// </summary>
        /// <returns>Mensajes de los errores almacenados por el administrador.</returns>
        string GetErrorMessage();

        /// <summary>
        /// Verifica si el administrador de errores contiene errores almacenados.
        /// </summary>
        /// <returns>Verdadero si existen errores; de lo contrario, Falso.</returns>
        bool HasError();
    }
}
