using Connection.Base;
using Models.Inventario;
using System.Collections.Generic;

namespace Connection.Interfaces.Inventario
{
    /// <summary>
    /// Indica que una clase implementará el DAO para las Materias Primas.
    /// </summary>
    public interface IMateriaPrimaDao : IDao<MateriaPrima>
    {
        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único de la Materia Prima.</param>
        /// <returns>Objeto de tipo Materia Prima que resulte de la búsqueda.</returns>
        MateriaPrima GetById(int id);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una serie de registros que coincidan con la descripción a filtrar.
        /// </summary>
        /// <param name="descripcion">Descripción de la Materia Prima.</param>
        /// <returns>Colección de objetos de tipo Materia Prima que resulten de la búsqueda.</returns>
        IEnumerable<MateriaPrima> Read(string descripcion);
    }
}
