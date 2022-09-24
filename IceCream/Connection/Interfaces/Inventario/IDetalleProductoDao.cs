using Connection.Base;
using Models.Inventario;
using System.Collections.Generic;

namespace Connection.Interfaces.Inventario
{
    /// <summary>
    /// Indica que una clase implementará el DAO para los Detalles de Productos.
    /// </summary>
    public interface IDetalleProductoDao : IDao<DetalleProducto>
    {
        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar un registro que coincida con los ID del Producto y Materia Prima.
        /// </summary>
        /// <param name="idProducto">Identificador único del Producto.</param>
        /// <param name="idMateriaPrima">Identificador único de la Materia Prima.</param>
        /// <returns>Objeto de tipo Detalle de Producto que resulte de la búsqueda.</returns>
        DetalleProducto Read(int idProducto, int idMateriaPrima);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una serie de registros que coincidan con el ID del Producto.
        /// </summary>
        /// <param name="idProducto">Identificador único del Producto.</param>
        /// <returns>Colección de objetos de tipo Detalle de Producto que resulte de la búsqueda.</returns>
        IEnumerable<DetalleProducto> GetByIdProducto(int idProducto);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una serie de registros que coincidan con el ID de Materia Prima.
        /// </summary>
        /// <param name="idMateriaPrima">Identificador único de la Materia Prima.</param>
        /// <returns>Colección de objetos de tipo Detalle de Producto que resulte de la búsqueda.</returns>
        IEnumerable<DetalleProducto> GetByIdMateriaPrima(int idMateriaPrima);
    }
}
