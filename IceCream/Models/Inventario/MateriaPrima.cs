using Models.Interfaces;
using System.Drawing;

namespace Models.Inventario
{
    /// <summary>
    /// Objeto simple de tipo Materia Prima.
    /// </summary>
    public class MateriaPrima : IIdentity, IActivable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <summary>
        /// Descripción de la Materia Prima.
        /// </summary>
        public string Descripcion { get; set; }

        /// <summary>
        /// Representación gráfica de la Materia Prima.
        /// </summary>
        public Image Imagen { get; set; }

        /// <summary>
        /// Precio en catálogo de la Materia Prima.
        /// </summary>
        public double Precio { get; set; }

        /// <summary>
        /// Cantidad en stock de la Materia Prima.
        /// </summary>
        public float Cantidad { get; set; }

        /// <inheritdoc cref="IActivable.Estado"/>
        public bool Estado { get; set; }
    }
}
