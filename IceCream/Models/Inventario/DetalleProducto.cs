using Models.Interfaces;

namespace Models.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Detalle de Producto.
    /// </summary>
    public class DetalleProducto : IActivable
    {
        /// <summary>
        /// Identificador único del Producto asociado a esta clase.
        /// </summary>
        public int IdProducto { get; set; }

        /// <summary>
        /// Identificador único de la Materia Prima asociada a esta clase.
        /// </summary>
        public int IdMateriaPrima { get; set; }

        /// <summary>
        /// Cantidad de Materia Prima utilizada para fabricar el Producto.
        /// </summary>
        public float Cantidad { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
    }
}
