using Connection.Base;
using Models.Compras;
using System.Collections.Generic;

namespace Connection.Interfaces.Compras
{
    /// <summary>
    /// Indica que una clase implementará el DAO para los Proveedores.
    /// </summary>
    public interface IProveedorDao : IDao<Proveedor>
    {
        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el
        /// ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Proveedor a buscar.</param>
        /// <returns>Objeto de tipo Proveedor que resulte de la búsqueda.</returns>
        Proveedor GetById(int id);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una serie de registros que coincidan con el
        /// valor a filtrar. Este puede ser por nombre o dirección.
        /// </summary>
        /// <param name="value">Valor a filtrar. Puede ser: Nombre o Dirección.</param>
        /// <returns>Colección de objetos de tipo Proveedor que resulten de la búsqueda.</returns>
        IEnumerable<Proveedor> Read(string value);
    }
}
