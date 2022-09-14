using Models.Interfaces;
using System.Drawing;

namespace Models.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Producto.
    /// </summary>
    public class Producto : IIdentity, IActivable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <summary>
        /// Descripción del Producto.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Representación gráfica del Producto
        /// </summary>
        public Image Imagen { get; set; }

        /// <summary>
        /// Precio en catálogo del Producto.
        /// </summary>
        public double Precio { get; set; }

        /// <summary>
        /// Cantidad en stock del Producto.
        /// </summary>
        public float Cantidad { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }

        /// <summary>
        /// Identificador único de la Categoría asociada al Producto.
        /// </summary>
        public int IdCategoria { get; set; }
    }
}
