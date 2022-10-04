using Common.Util;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Ventas;
using Models.Ventas;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Ventas
{
    /// <summary>
    /// Acceso a datos para el objeto Detalle de Venta.
    /// </summary>
    internal class DetalleVentaDao : BaseDao<DetalleVenta>, IDetalleVentaDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public DetalleVentaDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override DetalleVenta Create(DetalleVenta model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.DetalleVentaCreate, new Dictionary<string, object>
            {
                {"IdVenta", model.IdVenta },
                {"IdProducto", model.IdProducto },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento }
            }).FirstOrDefault() ?? null;
        }

        public override DetalleVenta Delete(DetalleVenta model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.DELETE)) return null;

            return Read(StoredProcedures.DetalleVentaDelete, new Dictionary<string, object>
            {
                {"IdVenta", model.IdVenta },
                {"IdProducto", model.IdProducto }
            }).FirstOrDefault() ?? null;
        }

        public IEnumerable<DetalleVenta> GetByIdProducto(int idProducto)
        {
            if (idProducto.Equals(default) || idProducto <= 0)
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"IdProducto", idProducto },
                {"Estado", 1 }
            });
        }

        public IEnumerable<DetalleVenta> GetByIdVenta(int idVenta)
        {
            if (idVenta.Equals(default) || idVenta <= 0)
            {
                Handler.Add("ID_VENTA_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"IdVenta", idVenta },
                {"Estado", 1 }
            });
        }

        public override IEnumerable<DetalleVenta> Read()
        {
            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        public DetalleVenta Read(int idVenta, int idProducto)
        {
            if (idVenta.Equals(default) || idVenta <= 0)
            {
                Handler.Add("ID_VENTA_DEFAULT");
                return null;
            }

            if (idProducto.Equals(default) || idProducto <= 0)
            {
                Handler.Add("ID_PRODUCTO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleVentaRead, new Dictionary<string, object>
            {
                {"IdVenta", idVenta },
                {"IdProducto", idProducto },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        public override DetalleVenta Update(DetalleVenta model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.DetalleVentaUpdate, new Dictionary<string, object>
            {
                {"IdVenta", model.IdVenta },
                {"IdProducto", model.IdProducto },
                {"Precio", model.Precio },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento }
            }).FirstOrDefault() ?? null;
        }
    }
}
