using Models.Interfaces;

namespace Models.Ventas
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Venta
    /// </summary>
    public class DetalleVenta : ITransactionDetail, IActivable
    {
        /// <summary>
        /// Identificador único de la Venta asociada al Detalle.
        /// </summary>
        public int IdVenta { get; set; }

        /// <summary>
        /// Identificador único del Producto asociado al Detalle.
        /// </summary>
        public int IdProducto { get; set; }

        /// <summary>
        /// Precio de venta del Producto.
        /// </summary>
        public double Precio { get; set; }

        /// <inheritdoc cref="ITransactionDetail.Cantidad"/>
        public float Cantidad { get; set; }

        /// <inheritdoc cref="ITransactionDetail.Descuento"/>
        public float Descuento { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
    }
}
