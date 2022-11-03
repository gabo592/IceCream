using Connection.Interfaces.Seguridad;
using IceCream.Services.Base;
using IceCream.ViewModels.Seguridad;
using Models.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCream.Services.Seguridad
{
    /// <summary>
    /// Clase encargada de proveer los servicios a los usuarios.
    /// </summary>
    internal class UsuarioService : ServicioBase
    {
        /// <summary>
        /// DAO para los usuarios.
        /// </summary>
        private readonly IUsuarioDao usuarioDao;

        public UsuarioService()
        {
            usuarioDao = DaoFactory.Get<IUsuarioDao>(Handler);
        }

        public IEnumerable<UsuarioView> GetUsuarios(string nombre)
        {
            IEnumerable<Usuario> usuarios = usuarioDao.Read(nombre);

            return usuarios.Select(usuario =>
            {
                return new UsuarioView
                {
                    Id = usuario.Id,
                    Nombre = usuario.Nombre,
                    Empleado = string.Empty
                };
            });
        }

        /// <summary>
        /// Establece un nuevo inicio de sesión de un usuario al programa.
        /// </summary>
        /// <param name="nombre">Nombre de usuario.</param>
        /// <param name="clave">Clave o contraseña del usuario.</param>
        public void Login(string nombre, string clave)
        {
            Usuario usuario = usuarioDao.Login(nombre, clave);

            if (usuario is null)
            {
                Handler.Add("MODELO_NULO");
                return;
            }

            try
            {
                Session.SetSession(usuario);
            }
            catch(Exception ex)
            {
                Handler.Add(ex);
            }
        }

        public override void Dispose()
        {
            Handler.Clear();
        }

        public override string GetErrorMessage() => Handler.GetErrorMessage();

        public override bool HasError() => Handler.HasError();
    }
}
