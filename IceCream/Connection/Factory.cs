using Common.Util;
using Connection.Compras;
using Connection.Interfaces.Compras;
using Connection.Interfaces.Inventario;
using Connection.Interfaces.RecursosHumanos;
using Connection.Interfaces.Seguridad;
using Connection.Interfaces.Ubicacion;
using Connection.Interfaces.Ventas;
using Connection.Inventario;
using Connection.RecursosHumanos;
using Connection.Seguridad;
using Connection.Ubicacion;
using Connection.Ventas;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Connection
{
    /// <summary>
    /// Clase encargada de crear el DAO de tipo especificado.
    /// </summary>
    public static class Factory
    {
        /// <summary>
        /// Mapping de todos los DAO reconocidos y administrados por el sistema.
        /// </summary>
        private static readonly IDictionary<Type, Type> Daos = new Dictionary<Type, Type>
        {
            //Compras
            {typeof(ICompraDao), typeof(CompraDao) },
            {typeof(IDetalleCompraDao), typeof(DetalleCompraDao) },
            {typeof(IProveedorDao), typeof(ProveedorDao) },

            //Inventario
            {typeof(ICategoriaProductoDao), typeof(CategoriaProductoDao) },
            {typeof(IDetalleProductoDao), typeof(DetalleProductoDao) },
            {typeof(IMateriaPrimaDao), typeof(MateriaPrimaDao) },
            {typeof(IProductoDao), typeof(ProductoDao) },

            //RecursosHumanos
            {typeof(IEmpleadoDao), typeof(EmpleadoDao) },

            //Seguridad
            {typeof(IDetalleUsuarioDao), typeof(DetalleUsuarioDao) },
            {typeof(IRolDao), typeof(RolDao) },
            {typeof(IUsuarioDao), typeof(UsuarioDao) },

            //Ubicacion
            {typeof(IDepartamentoDao), typeof(DepartamentoDao) },
            {typeof(IMunicipioDao), typeof(MunicipioDao) },

            //Ventas
            {typeof(IClienteDao), typeof(ClienteDao) },
            {typeof(IDetalleVentaDao), typeof(DetalleVentaDao) },
            {typeof(IVentaDao), typeof(VentaDao) }
        };

        /// <summary>
        /// Realiza la invocación de un DAO en base al mapping ya configurado.
        /// </summary>
        /// <typeparam name="TDao">Tipo de DAO a invocar.</typeparam>
        /// <param name="connectionString">Cadena de conexión a la base de datos.</param>
        /// <param name="handler">Administrador de errores.</param>
        /// <returns>El tipo de DAO a invocar.</returns>
        /// <exception cref="ArgumentException">Se dispara cuando el DAO no se encuentra mapeado.</exception>
        /// <exception cref="ArgumentNullException">Se dispara cuando no se logra obtener un constructor que cumpla con los requisitos del DAO.</exception>
        public static TDao Invoke<TDao>(string connectionString, ErrorHandler handler)
        {
            if (!Daos.TryGetValue(typeof(TDao), out Type type)) throw new ArgumentException("El tipo de DAO no se encuentra mapeado");

            ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(string), typeof(ErrorHandler) });

            if (constructor is null) throw new ArgumentNullException("El DAO a invocar no tiene configurado un constructor que admita una cadena de conexión y una instancia del Administrador de Errores.");

            return (TDao)constructor.Invoke(new object[] { connectionString, handler });
        }
    }
}
