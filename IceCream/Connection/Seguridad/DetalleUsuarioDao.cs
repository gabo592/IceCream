using Common.Util;
using Connection.Base;
using Connection.Constantes;
using Connection.Interfaces.Seguridad;
using Models.Seguridad;
using System.Collections.Generic;
using System.Linq;

namespace Connection.Seguridad
{
    /// <summary>
    /// Acceso a datos para el objeto Detalle de Usuario.
    /// </summary>
    internal class DetalleUsuarioDao : BaseDao<DetalleUsuario>, IDetalleUsuarioDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public DetalleUsuarioDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override DetalleUsuario Create(DetalleUsuario model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.DetalleUsuarioCreate, new Dictionary<string, object>
            {
                {"IdUsuario", model.IdUsuario },
                {"IdRol", model.IdRol }
            }).FirstOrDefault() ?? null;
        }

        public override DetalleUsuario Delete(DetalleUsuario model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.DELETE)) return null;

            return Read(StoredProcedures.DetalleUsuarioDelete, new Dictionary<string, object>
            {
                {"IdUsuario", model.IdUsuario },
                {"IdRol", model.IdRol }
            }).FirstOrDefault() ?? null;
        }

        public IEnumerable<DetalleUsuario> GetByIdRol(int idRol)
        {
            if (idRol.Equals(default) || idRol <= 0)
            {
                Handler.Add("ID_ROL_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleUsuarioRead, new Dictionary<string, object>
            {
                {"IdRol", idRol },
                {"Estado", 1 }
            });
        }

        public IEnumerable<DetalleUsuario> GetByIdUsuario(int idUsuario)
        {
            if (idUsuario.Equals(default) || idUsuario <= 0)
            {
                Handler.Add("ID_USUARIO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleUsuarioRead, new Dictionary<string, object>
            {
                {"IdUsuario", idUsuario },
                {"Estado", 1 }
            });
        }

        public override IEnumerable<DetalleUsuario> Read()
        {
            return Read(StoredProcedures.DetalleUsuarioRead, new Dictionary<string, object>
            {
                {"Estado", 1 }
            });
        }

        public DetalleUsuario Read(int idUsuario, int idRol)
        {
            if (idRol.Equals(default) || idRol <= 0)
            {
                Handler.Add("ID_ROL_DEFAULT");
                return null;
            }

            if (idUsuario.Equals(default) || idUsuario <= 0)
            {
                Handler.Add("ID_USUARIO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.DetalleUsuarioRead, new Dictionary<string, object>
            {
                {"IdRol", idRol },
                {"IdUsuario", idUsuario },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        public override DetalleUsuario Update(DetalleUsuario model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.DetalleUsuarioUpdate, new Dictionary<string, object>
            {
                {"IdUsuario", model.IdUsuario },
                {"IdRol", model.IdRol }
            }).FirstOrDefault() ?? null;
        }
    }
}
