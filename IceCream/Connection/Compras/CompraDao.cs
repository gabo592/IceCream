using Common.Util;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Compras;
using Models.Compras;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Compras
{
    /// <summary>
    /// Acceso a datos para el objeto Compra.
    /// </summary>
    internal class CompraDao : BaseDao<Compra>, ICompraDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public CompraDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override Compra Create(Compra model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.CompraCreate, new Dictionary<string, object>
            {
                {"Fecha", model.Fecha },
                {"IdProveedor", model.IdProveedor },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }

        public override Compra Delete(Compra model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.DELETE)) return null;

            return Read(StoredProcedures.CompraDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        public Compra GetById(int id)
        {
            if (id.Equals(default) || id <= 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        public IEnumerable<Compra> GetByIdEmpleado(int idEmpleado)
        {
            if (idEmpleado.Equals(default) || idEmpleado <= 0)
            {
                Handler.Add("ID_EMPLEADO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"IdEmpleado", idEmpleado },
                {"Estado", 1 }
            });
        }

        public IEnumerable<Compra> GetByIdProveedor(int idProveedor)
        {
            if (idProveedor.Equals(default) || idProveedor <= 0)
            {
                Handler.Add("ID_PROVEEDOR_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"IdProveedor", idProveedor },
                {"Estado", 1 }
            });
        }

        public override IEnumerable<Compra> Read()
        {
            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        public IEnumerable<Compra> Read(DateTime fecha)
        {
            if (fecha == null)
            {
                Handler.Add("FECHA_DEFAULT");
                return null;
            }

            TimeSpan timeSpan = fecha.Date - DateTime.Now.Date;
            int days = timeSpan.Days;

            if (days > 0)
            {
                Handler.Add("FECHA_INCORRECTA");
                return null;
            }

            return Read(StoredProcedures.CompraRead, new Dictionary<string, object>
            {
                {"Fecha", fecha },
                {"Estado", 1 }
            });
        }

        public override Compra Update(Compra model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.CompraUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Fecha", model.Fecha },
                {"IdProveedor", model.IdProveedor },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }
    }
}
