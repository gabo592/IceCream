using Common.Util;

namespace IceCream.Services.Base
{
    /// <summary>
    /// Clase abstracta de proveer los servicios base para las demás clases Servicio.
    /// </summary>
    internal abstract class ServicioBase : IServicioBase
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        protected ErrorHandler Handler;

        public ServicioBase()
        {
            Handler = new ErrorHandler();
        }

        public abstract void Dispose();

        public abstract string GetErrorMessage();

        public abstract bool HasError();
    }
}
