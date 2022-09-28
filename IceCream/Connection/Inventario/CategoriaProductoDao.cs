using Common.Util;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Inventario;
using Models.Inventario;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Inventario
{
    /// <summary>
    /// Acceso a datos para el objeto Categoría de Productos.
    /// </summary>
    internal class CategoriaProductoDao : BaseDao<CategoriaProducto>, ICategoriaProductoDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public CategoriaProductoDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override CategoriaProducto Create(CategoriaProducto model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.CategoriaProductoCreate, new Dictionary<string, object>
            {
                {"Nombre", model.Nombre },
                {"Descripcion", model.Descripcion },
                {"Imagen", model.Imagen }
            }).FirstOrDefault() ?? null;
        }

        public override CategoriaProducto Delete(CategoriaProducto model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.CategoriaProductoDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        public CategoriaProducto GetById(int id)
        {
            if (id.Equals(default) || id <= 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.CategoriaProductoRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        public override IEnumerable<CategoriaProducto> Read()
        {
            return Read(string.Empty);
        }

        public IEnumerable<CategoriaProducto> Read(string value)
        {
            return Read(StoredProcedures.CategoriaProductoRead, new Dictionary<string, object>
            {
                {"Nombre", value },
                {"Descripcion", value },
                {"Estado", 1 }
            });
        }

        public override CategoriaProducto Update(CategoriaProducto model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.CategoriaProductoUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Nombre", model.Nombre },
                {"Descripcion", model.Descripcion },
                {"Imagen", model.Imagen }
            }).FirstOrDefault() ?? null;
        }
    }
}
