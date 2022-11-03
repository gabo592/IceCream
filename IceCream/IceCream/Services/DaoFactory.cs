using Common.Util;
using Connection;
using IceCream.Properties;

namespace IceCream.Services
{
    /// <summary>
    /// Clase encargada de fabricar los DAO para los diferentes modelos.
    /// </summary>
    internal static class DaoFactory
    {
        /// <summary>
        /// Cadena de conexión a base de datos.
        /// </summary>
        private static readonly string ConnectionString;

        static DaoFactory()
        {
            ConnectionString = Settings.Default.ConnectionString;
        }

        /// <inheritdoc cref="Factory"/>
        public static TDao Get<TDao>(ErrorHandler handler) => Factory.Invoke<TDao>(ConnectionString, handler);
    }
}
