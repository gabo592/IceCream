using Common.Util;
using System.Collections.Generic;

namespace Connection.Base
{
    /// <summary>
    /// Clase encargada de la implementación base del acceso a un objeto.
    /// </summary>
    /// <typeparam name="TModel">Tipo de modelo a implementar.</typeparam>
    internal abstract class BaseDao<TModel> : IDao<TModel> where TModel : new()
    {
        /// <summary>
        /// Instancia de la base de datos.
        /// </summary>
        private readonly Database Database;

        public BaseDao(string connectionString, ErrorHandler handler)
        {
            Database = new Database(connectionString, handler);
        }

        /// <inheritdoc cref="IDao{TModel}.Create(TModel)"/>
        public abstract TModel Create(TModel model);

        /// <inheritdoc cref="IDao{TModel}.Delete(int)"/>
        public abstract TModel Delete(int id);

        /// <inheritdoc cref="IDao{TModel}.Read"/>
        public abstract IEnumerable<TModel> Read();

        /// <inheritdoc cref="IDao{TModel}.Update(TModel)"/>
        public abstract TModel Update(TModel model);

        /// <inheritdoc cref="Database.Read{TModel}(string, IDictionary{string, object})"/>
        public IEnumerable<TModel> Read(string procedure, IDictionary<string, object> parameters = null) => Database.Read<TModel>(procedure, parameters);
    }
}
