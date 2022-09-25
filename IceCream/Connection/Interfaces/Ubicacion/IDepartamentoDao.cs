using Connection.Base;
using Models.Ubicacion;
using System.Collections.Generic;

namespace Connection.Interfaces.Ubicacion
{
    /// <summary>
    /// Indica que una clase implementará el DAO para los Departamentos.
    /// </summary>
    public interface IDepartamentoDao : IDao<Departamento>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que contenga el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Departamento.</param>
        /// <returns>Objeto de tipo Departamento que resulte de la búsqueda.</returns>
        Departamento GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros que contengan el nombre a filtrar.
        /// </summary>
        /// <param name="nombre">Nombre del Departamento.</param>
        /// <returns>Colección de objetos de tipo Departamento que resulten de la búsqueda.</returns>
        IEnumerable<Departamento> Read(string nombre);
    }
}
