using Connection.Base;
using Models.Inventario;
using System.Collections.Generic;

namespace Connection.Interfaces.Inventario
{
    /// <summary>
    /// Indica que una clase implementará el DAO para las Categorías de Productos.
    /// </summary>
    public interface ICategoriaProductoDao : IDao<CategoriaProducto>
    {
        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar un registro que coincida con el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único de la Categoría de Producto.</param>
        /// <returns>Objeto de tipo Categoría de Producto que resulte de la búsqueda.</returns>
        CategoriaProducto GetById(int id);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar un serie de registros que coincida con el valor a filtrar.
        /// El valor puede ser: Nombre o Dirección.
        /// </summary>
        /// <param name="value">Valor a filtrar: Nombre o Dirección.</param>
        /// <returns>Colección de objetos de tipo Categoría de Productos que resulten de la búsqueda.</returns>
        IEnumerable<CategoriaProducto> Read(string value);
    }
}
