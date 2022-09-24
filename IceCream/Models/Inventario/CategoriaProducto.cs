using System.Drawing;
using Models.Interfaces;

namespace Models.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Categoría de Producto.
    /// </summary>
    public class CategoriaProducto : IIdentity, INameable, IActivable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="INameable.Nombre"/>
        public string Nombre { get; set; }

        /// <summary>
        /// Descripción de la Categoría de Producto.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Representación gráfica de la Categoría de Producto.
        /// </summary>
        public Image Imagen { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
    }
}
