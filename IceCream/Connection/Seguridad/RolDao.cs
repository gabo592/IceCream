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
    /// Acceso a datos para el objeto Rol.
    /// </summary>
    internal class RolDao : BaseDao<Rol>, IRolDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public RolDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override Rol Create(Rol model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.RolCreate, new Dictionary<string, object>
            {
                {"Nombre", model.Nombre },
                {"Descripcion", model.Descripcion }
            }).FirstOrDefault() ?? null;
        }

        public override Rol Delete(Rol model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.DELETE)) return null;

            return Read(StoredProcedures.RolDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        public Rol GetById(int id)
        {
            if (id.Equals(default) || id <= 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.RolRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        public override IEnumerable<Rol> Read()
        {
            return Read(string.Empty);
        }

        public IEnumerable<Rol> Read(string value)
        {
            return Read(StoredProcedures.RolRead, new Dictionary<string, object>
            {
                {"Nombre", value },
                {"Descripcion", value },
                {"Estado", 1 }
            });
        }

        public override Rol Update(Rol model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.RolUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Nombre", model.Nombre },
                {"Descripcion", model.Descripcion }
            }).FirstOrDefault() ?? null;
        }
    }
}
