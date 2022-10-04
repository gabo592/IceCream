﻿using Common.Util;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Ventas;
using Models.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Ventas
{
    /// <summary>
    /// Acceso a datos para el objeto Venta.
    /// </summary>
    internal class VentaDao : BaseDao<Venta>, IVentaDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public VentaDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override Venta Create(Venta model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.VentaCreate, new Dictionary<string, object>
            {
                {"IdCliente", model.IdCliente },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }

        public override Venta Delete(Venta model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.DELETE)) return null;

            return Read(StoredProcedures.VentaDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        public Venta GetById(int id)
        {
            if (id.Equals(default) || id <= 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"Id", id }
            }).FirstOrDefault() ?? null;
        }

        public IEnumerable<Venta> GetByIdCliente(int idCliente)
        {
            if (idCliente.Equals(default) || idCliente <= 0)
            {
                Handler.Add("ID_CLIENTE_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"IdCliente", idCliente }
            });
        }

        public IEnumerable<Venta> GetByIdEmpleado(int idEmpleado)
        {
            if (idEmpleado.Equals(default) || idEmpleado <= 0)
            {
                Handler.Add("ID_EMPLEADO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"IdEmpleado", idEmpleado }
            });
        }

        public override IEnumerable<Venta> Read()
        {
            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        public IEnumerable<Venta> Read(DateTime fecha)
        {
            return Read(StoredProcedures.VentaRead, new Dictionary<string, object>
            {
                {"Fecha", fecha },
                {"Estado", 1 }
            });
        }

        public override Venta Update(Venta model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.VentaUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Fecha", model.Fecha },
                {"IdCliente", model.IdCliente },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }
    }
}
