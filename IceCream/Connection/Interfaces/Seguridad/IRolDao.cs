using Connection.Base;
using Models.Seguridad;
using System.Collections.Generic;

namespace Connection.Interfaces.Seguridad
{
    /// <summary>
    /// Indica que una clase implementará el DAO para los Roles.
    /// </summary>
    public interface IRolDao : IDao<Rol>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que contenga el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Rol.</param>
        /// <returns>Objeto de tipo Rol que resulte de la búsqueda.</returns>
        Rol GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros que contengan el valor a filtrar.
        /// Este valor puede ser: Nombre o Descripción.
        /// </summary>
        /// <param name="value">Valor a filtrar: Nombre o Descripción.</param>
        /// <returns>Colección de objetos de tipo Rol que resulten de la búsqueda.</returns>
        IEnumerable<Rol> Read(string value);
    }
}
