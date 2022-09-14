using Models.Interfaces;

namespace Models.Seguridad
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Usuario.
    /// </summary>
    public class DetalleUsuario : IActivable
    {
        /// <summary>
        /// Identificador único del Usuario asociado a esta clase.
        /// </summary>
        public int IdUsuario { get; set; }

        /// <summary>
        /// Identificador único del Rol asociado al Usuario.
        /// </summary>
        public int IdRol { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
    }
}
