using Connection.Base;
using Models.Seguridad;
using System.Collections.Generic;

namespace Connection.Interfaces.Seguridad
{
    /// <summary>
    /// Indica que una clase implementará el DAO para los Detalles de Usuarios.
    /// </summary>
    public interface IDetalleUsuarioDao : IDao<DetalleUsuario>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro de tipo Detalle de Usuario que contenga el ID de Usuario y de Rol a filtrar.
        /// </summary>
        /// <param name="idUsuario">Identificador único del Usuario.</param>
        /// <param name="idRol">Identificador único del Rol.</param>
        /// <returns>Objeto de tipo Detalle de Usuario que resulte de la búsqueda.</returns>
        DetalleUsuario Read(int idUsuario, int idRol);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros de tipo Detalle de Usuario que contengan el ID de Usuario a filtrar.
        /// </summary>
        /// <param name="idUsuario">Identificador único del Usuario.</param>
        /// <returns>Colección de objetos de tipo Detalle de Usuario que resulten de la búsqueda.</returns>
        IEnumerable<DetalleUsuario> GetByIdUsuario(int idUsuario);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros de tipo Detalle de Usuario que contengan el ID de Rol a filtrar.
        /// </summary>
        /// <param name="idRol">Identificador único del Rol.</param>
        /// <returns>Colección de objetos de tipo Detalle de Usuario que resulten de la búsqueda.</returns>
        IEnumerable<DetalleUsuario> GetByIdRol(int idRol);
    }
}
