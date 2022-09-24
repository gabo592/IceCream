using Connection.Base;
using Models.Inventario;
using System.Collections.Generic;

namespace Connection.Interfaces.Inventario
{
    /// <summary>
    /// Indica que una clase implementará el DAO para los Productos.
    /// </summary>
    public interface IProductoDao : IDao<Producto>
    {
        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único del Producto.</param>
        /// <returns>Objeto de tipo Producto que resulte de la búsqueda.</returns>
        Producto GetById(int id);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una serie de registros que coincidan con la descripción a filtrar.
        /// </summary>
        /// <param name="descripcion">Descripción del Producto.</param>
        /// <returns>Colección de objetos de tipo Producto que resulten de la búsqueda.</returns>
        IEnumerable<Producto> Read(string descripcion);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una serie de registros que coincidan con el ID de la Categoría a filtrar.
        /// </summary>
        /// <param name="idCategoriaProducto">Identificador único de la Categoría de Producto.</param>
        /// <returns>Colección de objetos de tipo Producto que resulten de la búsqueda.</returns>
        IEnumerable<Producto> GetByIdCategoriaProducto(int idCategoriaProducto);
    }
}
