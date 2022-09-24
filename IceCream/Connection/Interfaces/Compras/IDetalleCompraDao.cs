using Connection.Base;
using Models.Compras;
using System.Collections.Generic;

namespace Connection.Interfaces.Compras
{
    /// <summary>
    /// Indica que una clase implementará el DAO para los Detalles de Compras
    /// </summary>
    public interface IDetalleCompraDao : IDao<DetalleCompra>
    {
        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar un registro que coincida con los ID
        /// de compra y materia prima.
        /// </summary>
        /// <param name="idCompra">Identificador único de la compra asociada al detalle.</param>
        /// <param name="idMateriaPrima">Identificador único de la materia prima asociada al detalle.</param>
        /// <returns>Objeto de tipo Detalle de Compra que resulte de la búsqueda.</returns>
        DetalleCompra Read(int idCompra, int idMateriaPrima);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una serie de registros que coincidan con el ID
        /// de compra.
        /// </summary>
        /// <param name="idCompra">Identificador único de la compra asociada al detalle.</param>
        /// <returns>Colección de objetos de tipo Detalle de Compra que resulten de la búsqueda.</returns>
        IEnumerable<DetalleCompra> GetByIdCompra(int idCompra);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una serie de registros que coincidan con el ID
        /// de materia prima.
        /// </summary>
        /// <param name="idMateriaPrima">Identificador único de la materia prima asociada al detalle.</param>
        /// <returns>Colección de objetos de tipo Detalle de Compra que resulten de la búsqueda.</returns>
        IEnumerable<DetalleCompra> GetByIdMateriaPrima(int idMateriaPrima);

    }
}
