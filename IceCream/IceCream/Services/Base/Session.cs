using Models.Seguridad;
using System;

namespace IceCream.Services.Base
{
    /// <summary>
    /// Clase encargada de manejar la sesión de un usuario dentro de la aplicación.
    /// </summary>
    internal static class Session
    {
        /// <summary>
        /// Objeto simple de tipo Usuario;
        /// </summary>
        public static Usuario Usuario { get; private set; }

        /// <summary>
        /// Propiedad que indica si existe o no una sesión activa.
        /// </summary>
        public static bool IsActiveSession => Usuario.Estado || Usuario != null || !Usuario.Id.Equals(default);

        /// <summary>
        /// Establece una sesión de un usuario dentro del programa siempre y cuando no exista otra activa.
        /// </summary>
        /// <param name="usuario">Usuario a establecer la sesión.</param>
        /// <exception cref="ArgumentNullException">Se dispara cuando no se proporciona una instancia de Usuario.</exception>
        /// <exception cref="InvalidOperationException">Se dispara cuando ya existe una sesión activa dentro del programa.</exception>
        public static void SetSession(Usuario usuario)
        {
            if (usuario is null) throw new ArgumentNullException(nameof(usuario), "El usuario a iniciar sesión no puede ser nulo.");

            if (IsActiveSession) throw new InvalidOperationException("Ya existe una sesión activa");

            Usuario = usuario;
        }

        /// <summary>
        /// Cierra la sesión de un usuario dentro del programa.
        /// </summary>
        public static void Close() => Usuario = null;
    }
}
