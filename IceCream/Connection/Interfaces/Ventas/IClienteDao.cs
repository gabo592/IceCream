using Connection.Base;
using Models.Ventas;
using System.Collections.Generic;

namespace Connection.Interfaces.Ventas
{
    /// <summary>
    /// Indica que una clase implementará el DAO para los Clientes.
    /// </summary>
    public interface IClienteDao : IDao<Cliente>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que contenga el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Cliente.</param>
        /// <returns>Objeto de tipo Cliente que resulte de la búsqueda.</returns>
        Cliente GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros que contengan el valor a filtrar.
        /// El valor puede ser: Nombres, Apellidos, Dirección, etc.
        /// </summary>
        /// <param name="value">Valor a filtrar: Nombres, Apellidos, Dirección.</param>
        /// <returns>Colección de objetos de tipo Cliente que resulten de la búsqueda.</returns>
        IEnumerable<Cliente> Read(string value);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros que contengan el ID del Municipio a filtrar.
        /// </summary>
        /// <param name="idMunicipio">Identificador único del Municipio.</param>
        /// <returns>Colección de objetos de tipo Cliente que resulten de la búsqueda.</returns>
        IEnumerable<Cliente> GetByIdMunicipio(int idMunicipio);
    }
}
