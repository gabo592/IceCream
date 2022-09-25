using Connection.Base;
using Models.RecursosHumanos;
using System.Collections.Generic;

namespace Connection.Interfaces.RecursosHumanos
{
    /// <summary>
    /// Indica que una clase implementará el DAO para los Empleados.
    /// </summary>
    public interface IEmpleadoDao : IDao<Empleado>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Empleado.</param>
        /// <returns>Objeto de tipo Empleado que resulte de la búsqueda.</returns>
        Empleado GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros que coincidan con el valor a filtrar.
        /// El valor puede ser: Nombres, Apellidos, Dirección, etc.
        /// </summary>
        /// <param name="value">Valor a filtrar: Nombres, Apellidos, Dirección.</param>
        /// <returns>Colección de objetos de tipo Empleado que resulten de la búsqueda.</returns>
        IEnumerable<Empleado> Read(string value);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros que coincidan con el ID de Municipio a filtrar.
        /// </summary>
        /// <param name="idMunicipio">Identificador único del Municipio.</param>
        /// <returns>Colección de objetos de tipo Empleado que resulten de la búsqueda.</returns>
        IEnumerable<Empleado> GetByIdMunicipio(int idMunicipio);
    }
}
