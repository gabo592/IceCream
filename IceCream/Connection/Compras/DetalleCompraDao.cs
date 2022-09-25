using Common.Util;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Compras;
using Models.Compras;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Compras
{
    /// <summary>
    /// Acceso a datos para el objeto Detalle de Compra.
    /// </summary>
    internal class DetalleCompraDao : BaseDao<DetalleCompra>, IDetalleCompraDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public DetalleCompraDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override DetalleCompra Create(DetalleCompra model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.DetalleCompraCreate, new Dictionary<string, object>
            {
                {"IdCompra", model.IdCompra },
                {"IdMateriaPrima", model.IdMateriaPrima },
                {"Costo", model.Costo },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento }
            }).FirstOrDefault() ?? null;
        }

        public override DetalleCompra Delete(DetalleCompra model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.DELETE)) return null;

            return Read(StoredProcedures.DetalleCompraDelete, new Dictionary<string, object>
            {
                {"IdCompra", model.IdCompra },
                {"IdMateriaPrima", model.IdMateriaPrima }
            }).FirstOrDefault() ?? null;
        }

        public IEnumerable<DetalleCompra> GetByIdCompra(int idCompra)
        {
            if (idCompra.Equals(default) || idCompra <= 0)
            {
                Handler.Add("ID_COMPRA_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"IdCompra", idCompra },
                {"Estado", 1 }
            });
        }

        public IEnumerable<DetalleCompra> GetByIdMateriaPrima(int idMateriaPrima)
        {
            if (idMateriaPrima.Equals(default) || idMateriaPrima <= 0)
            {
                Handler.Add("ID_MATERIA_PRIMA_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"IdMateriaPrima", idMateriaPrima },
                {"Estado", 1 }
            });
        }

        public override IEnumerable<DetalleCompra> Read()
        {
            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        public DetalleCompra Read(int idCompra, int idMateriaPrima)
        {
            if (idCompra.Equals(default) || idCompra <= 0)
            {
                Handler.Add("ID_COMPRA_DEFAULT");
                return null;
            }

            if (idMateriaPrima.Equals(default) || idMateriaPrima <= 0)
            {
                Handler.Add("ID_MATERIA_PRIMA_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleCompraRead, new Dictionary<string, object>
            {
                {"IdCompra", idCompra },
                {"IdMateriaPrima", idMateriaPrima },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        public override DetalleCompra Update(DetalleCompra model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.DetalleCompraUpdate, new Dictionary<string, object>
            {
                {"IdCompra", model.IdCompra },
                {"IdMateriaPrima", model.IdMateriaPrima },
                {"Costo", model.Costo },
                {"Cantidad", model.Cantidad },
                {"Descuento", model.Descuento }
            }).FirstOrDefault() ?? null;
        }
    }
}
