using Models.Interfaces;

namespace Models.Compras
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Compra.
    /// </summary>
    public class DetalleCompra : ITransactionDetail, IActivable
    {
        /// <summary>
        /// Identificador único de la Compra asociada al Detalle.
        /// </summary>
        public int IdCompra { get; set; }

        /// <summary>
        /// Identificador único de la Materia Prima asociada a esta clase.
        /// </summary>
        public int IdMateriaPrima { get; set; }

        /// <summary>
        /// Costo de la Materia Prima.
        /// </summary>
        public double Costo { get; set; }

        /// <inheritdoc cref="ITransactionDetail.Cantidad"/>
        public float Cantidad { get; set; }

        /// <inheritdoc cref="ITransactionDetail.Descuento"/>
        public float Descuento { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
    }
}
