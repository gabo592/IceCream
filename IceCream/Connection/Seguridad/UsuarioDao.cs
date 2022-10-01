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
    /// Acceso a datos para el objeto Usuario.
    /// </summary>
    internal class UsuarioDao : BaseDao<Usuario>, IUsuarioDao
    {
        /// <summary>
        /// Administrador de errores.
        /// </summary>
        private readonly ErrorHandler Handler;

        public UsuarioDao(string connectionString, ErrorHandler handler) : base(connectionString, handler)
        {
            Handler = handler;
        }

        public override Usuario Create(Usuario model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.CREATE)) return null;

            return Read(StoredProcedures.UsuarioCreate, new Dictionary<string, object>
            {
                {"Nombre", model.Nombre },
                {"Clave", model.Clave },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }

        public override Usuario Delete(Usuario model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.DELETE)) return null;

            return Read(StoredProcedures.UsuarioDelete, new Dictionary<string, object>
            {
                {"Id", model.Id }
            }).FirstOrDefault() ?? null;
        }

        public Usuario GetById(int id)
        {
            if (id.Equals(default) || id <= 0)
            {
                Handler.Add("ID_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.UsuarioRead, new Dictionary<string, object>
            {
                {"Id", id },
                {"Estado", 1 }
            }).FirstOrDefault() ?? null;
        }

        public IEnumerable<Usuario> GetByIdEmpleado(int idEmpleado)
        {
            if (idEmpleado.Equals(default) || idEmpleado <= 0)
            {
                Handler.Add("ID_EMPLEADO_DEFAULT");
                return null;
            }

            return Read(StoredProcedures.UsuarioRead, new Dictionary<string, object>
            {
                {"IdEmpleado", idEmpleado },
                {"Estado", 1 }
            });
        }

        public Usuario Login(string nombre, string clave)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                Handler.Add("NOMBRE_VACIO");
                return null;
            }

            if (nombre.Length < 3 || nombre.Length > 50)
            {
                Handler.Add("LONGITUD_NOMBRE_INCORRECTA");
                return null;
            }

            if (string.IsNullOrEmpty(clave))
            {
                Handler.Add("CLAVE_VACIA");
                return null;
            }

            if (clave.Length < 6)
            {
                Handler.Add("LONGITUD_CLAVE_CORTA");
                return null;
            }

            return Read(StoredProcedures.UsuarioLogin, new Dictionary<string, object>
            {
                {"Nombre", nombre },
                {"Clave", clave }
            }).FirstOrDefault() ?? null;
        }

        public override IEnumerable<Usuario> Read()
        {
            return Read(string.Empty);
        }

        public IEnumerable<Usuario> Read(string nombre)
        {
            return Read(StoredProcedures.UsuarioRead, new Dictionary<string, object>
            {
                {"Nombre", nombre },
                {"Estado", 1 }
            });
        }

        public override Usuario Update(Usuario model)
        {
            if (!Validations.Validate(model, Handler, Validations.Operations.UPDATE)) return null;

            return Read(StoredProcedures.UsuarioUpdate, new Dictionary<string, object>
            {
                {"Id", model.Id },
                {"Nombre", model.Nombre },
                {"Clave", model.Clave },
                {"IdEmpleado", model.IdEmpleado }
            }).FirstOrDefault() ?? null;
        }
    }
}
