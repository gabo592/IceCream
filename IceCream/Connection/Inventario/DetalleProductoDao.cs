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
    /// Acceso a datos para el objeto Detalle de Producto.
    /// </summary>
    internal class DetalleProductoDao : BaseDao<DetalleProducto>, IDetalleProductoDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public DetalleProductoDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override DetalleProducto Create(DetalleProducto model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.DetalleProductoCreate, new Dictionary<string, object>
            {
                {"IdProducto", model.IdProducto },
                {"IdMateriaPrima", model.IdMateriaPrima },
                {"Cantidad", model.Cantidad }
            }).FirstOrDefault() ?? null;
        }

        public override DetalleProducto Delete(DetalleProducto model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.DELETE)) return null;

            return Read(StoredProcedures.DetalleProductoDelete, new Dictionary<string, object>
            {
                {"IdProducto", model.IdProducto },
                {"IdMateriaPrima", model.IdMateriaPrima }
            }).FirstOrDefault() ?? null;
        }

        public IEnumerable<DetalleProducto> GetByIdMateriaPrima(int idMateriaPrima)
        {
            if (idMateriaPrima.Equals(default) || idMateriaPrima <= 0)
            {
                Handler.Add("ID_MATERIA_PRIMA_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleProductoRead, new Dictionary<string, object>
            {
                {"IdMateriaPrima", idMateriaPrima },
                {"Estado", 1 }
            });
        }

        public IEnumerable<DetalleProducto> GetByIdProducto(int idProducto)
        {
            if (idProducto.Equals(default) || idProducto <= 0)
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleProductoRead, new Dictionary<string, object>
            {
                {"IdProducto", idProducto },
                {"Estado", 1 }
            });
        }

        public override IEnumerable<DetalleProducto> Read()
        {
            return Read(StoredProcedures.DetalleProductoRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        public DetalleProducto Read(int idProducto, int idMateriaPrima)
        {
            if (idMateriaPrima.Equals(default) || idMateriaPrima <= 0)
            {
                Handler.Add("ID_MATERIA_PRIMA_DEFAULT");
                return null;
            }

            if (idProducto.Equals(default) || idProducto <= 0)
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleProductoRead, new Dictionary<string, object>
            {
                {"IdMateriaPrima", idMateriaPrima },
                {"IdProducto", idProducto },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        public override DetalleProducto Update(DetalleProducto model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.DetalleProductoUpdate, new Dictionary<string, object>
            {
                {"IdProducto", model.IdProducto },
                {"IdMateriaPrima", model.IdMateriaPrima },
                {"Cantidad", model.Cantidad }
            }).FirstOrDefault() ?? null;
        }
    }
}
