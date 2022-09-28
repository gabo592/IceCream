﻿using Common.Util;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Inventario;
using Models.Inventario;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Inventario
{
    /// <summary>
    /// Acceso a datos para el objeto Producto.
    /// </summary>
    internal class ProductoDao : BaseDao<Producto>, IProductoDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public ProductoDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override Producto Create(Producto model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.ProductoCreate, new Dictionary<string, object>
            {
                {"Descripcion", model.Descripcion },
                {"Imagen", model.Imagen },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad },
                {"IdCategoria", model.IdCategoria }
            }).FirstOrDefault() ?? null;
        }

        public override Producto Delete(Producto model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.DELETE)) return null;

            return Read(StoredProcedures.ProductoDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        public Producto GetById(int id)
        {
            if (id.Equals(default) || id <= 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.ProductoRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        public IEnumerable<Producto> GetByIdCategoriaProducto(int idCategoriaProducto)
        {
            if (idCategoriaProducto.Equals(default) || idCategoriaProducto <= 0)
            {
                Handler.Add("ID_CATEGORIA_PRODUCTO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.ProductoRead, new Dictionary<string, object>
            {
                {"IdCategoria", idCategoriaProducto },
                {"Estado", 1 }
            });
        }

        public override IEnumerable<Producto> Read()
        {
            return Read(string.Empty);
        }

        public IEnumerable<Producto> Read(string descripcion)
        {
            return Read(StoredProcedures.ProductoRead, new Dictionary<string, object>
            {
                {"Descripcion", descripcion },
                {"Estado", 1 }
            });
        }

        public override Producto Update(Producto model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.ProductoUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Descripcion", model.Descripcion },
                {"Imagen", model.Imagen },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad },
                {"IdCategoria", model.IdCategoria }
            }).FirstOrDefault() ?? null;
        }
    }
}
