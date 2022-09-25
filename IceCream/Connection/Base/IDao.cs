using System.Collections.Generic;

namespace Connection.Base
{
    /// <summary>
    /// Indica que una clase será la encargada de ejecutar el CRUD de los objetos del tipo especificado.
    /// </summary>
    /// <typeparam name="TModel">Tipo de objeto a crear un CRUD.</typeparam>
    public interface IDao<TModel> where TModel : new()
    {
        /// <summary>
        /// Crea un nuevo registro en la base de datos del modelo de tipo especificado.
        /// </summary>
        /// <param name="model">Modelo a crear en la base de datos.</param>
        /// <returns>Modelo ya creado desde la base de datos.</returns>
        TModel Create(TModel model);

        /// <summary>
        /// Realiza lectura de todos los modelos de la base de datos que coincidan con el Tipo.
        /// </summary>
        /// <returns>Colección de modelos del tipo especificado.</returns>
        IEnumerable<TModel> Read();

        /// <summary>
        /// Actualiza un registro en la base de datos del modelo de tipo especificado.
        /// </summary>
        /// <param name="model">Modelo a actualizar en la base de datos.</param>
        /// <returns>Modelo ya actualizado desde la base de datos.</returns>
        TModel Update(TModel model);

        /// <summary>
        /// Elimina un registro de la base de datos del tipo especificado.
        /// </summary>
        /// <param name="model">Modelo a eliminar</param>
        /// <returns>Modelo ya eliminado desde de la base de datos.</returns>
        TModel Delete(TModel model);
    }
}
