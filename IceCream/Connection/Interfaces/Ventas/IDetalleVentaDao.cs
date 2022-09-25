using Connection.Base;
using Models.Ventas;
using System.Collections.Generic;

namespace Connection.Interfaces.Ventas
{
    /// <summary>
    /// Indica que una clase implementará el DAO para los Detalles de Ventas.
    /// </summary>
    public interface IDetalleVentaDao : IDao<DetalleVenta>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que contenga el ID de Venta y Producto a filtrar.
        /// </summary>
        /// <param name="idVenta">Identificador único de la Venta.</param>
        /// <param name="idProducto">Identificador único del Producto.</param>
        /// <returns>Objeto de tipo Detalle de Venta que resulte de la búsqueda.</returns>
        DetalleVenta Read(int idVenta, int idProducto);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros que contengan el ID de Venta a filtrar.
        /// </summary>
        /// <param name="idVenta">Identificador único de la Venta.</param>
        /// <returns>Colección de objetos de tipo Detalle de Venta que resulten de la búsqueda.</returns>
        IEnumerable<DetalleVenta> GetByIdVenta(int idVenta);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros que contengan el ID de Producto a filtrar.
        /// </summary>
        /// <param name="idProducto">Identificador único del Producto.</param>
        /// <returns>Colección de objetos de tipo Detalle de Venta que resulten de la búsqueda.</returns>
        IEnumerable<DetalleVenta> GetByIdProducto(int idProducto);
    }
}
