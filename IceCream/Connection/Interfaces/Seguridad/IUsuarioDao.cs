using Connection.Base;
using Models.Seguridad;
using System.Collections.Generic;

namespace Connection.Interfaces.Seguridad
{
    /// <summary>
    /// Indica que una clase implementará el DAO para los Usuarios.
    /// </summary>
    public interface IUsuarioDao : IDao<Usuario>
    {
        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar un registro que contenga el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Usuario.</param>
        /// <returns>Objeto de tipo Usuario que resulte de la búsqueda.</returns>
        Usuario GetById(int id);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una serie de objetos que contengan el nombre a filtrar.
        /// </summary>
        /// <param name="nombre">Nombre del Usuario.</param>
        /// <returns>Colección de objetos de tipo Usuario que resulten de la búsqueda.</returns>
        IEnumerable<Usuario> Read(string nombre);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una serie de objetos que contengan el ID de Empleado a filtrar.
        /// </summary>
        /// <param name="idEmpleado">Identificador único del Empleado.</param>
        /// <returns>Colección de objetos de tipo Usuario que resulten de la búsqueda.</returns>
        IEnumerable<Usuario> GetByIdEmpleado(int idEmpleado);
    }
}
