using Connection.Base;
using Models.Ubicacion;
using System.Collections.Generic;

namespace Connection.Interfaces.Ubicacion
{
    /// <summary>
    /// Indica que una clase implementará el DAO para los Municipios.
    /// </summary>
    public interface IMunicipioDao : IDao<Municipio>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que contenga el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Municipio.</param>
        /// <returns>Objeto de tipo Municipio que resulte de la búsqueda.</returns>
        Municipio GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros que contengan el nombre a filtrar.
        /// </summary>
        /// <param name="nombre">Nombre del Municipio.</param>
        /// <returns>Colección de objetos de tipo Municipio que resulten de la búsqueda.</returns>
        IEnumerable<Municipio> Read(string nombre);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros que contengan el ID de Departamento a filtrar.
        /// </summary>
        /// <param name="idDepartamento">Identificador único del Departamento.</param>
        /// <returns>Colección de objetos de tipo Municipio que resulten de la búsqueda.</returns>
        IEnumerable<Municipio> GetByIdDepartamento(int idDepartamento);
    }
}
