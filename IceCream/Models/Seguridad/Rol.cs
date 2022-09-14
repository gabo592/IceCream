using Models.Interfaces;

namespace Models.Seguridad
{
    /// <summary>
    /// Objeto simple de tipo Rol.
    /// </summary>
    public class Rol : IIdentity, INameable, IActivable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="INameable.Nombre"/>
        public string Nombre { get; set; }

        /// <summary>
        /// Descripción del Rol.
        /// </summary>
        public string Descripcion { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
    }
}
