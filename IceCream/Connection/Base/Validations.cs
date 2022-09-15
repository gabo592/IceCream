using Common.Util;
using Models.Interfaces;

namespace Connection.Base
{
    /// <summary>
    /// Clase encarga de realizar las validaciones a los modelos.
    /// </summary>
    internal static class Validations
    {
        /// <summary>
        /// Verifica que un modelo cumpla con los requerimientos para poder realizar la operación indicada dentro de la base de datos.
        /// </summary>
        /// <typeparam name="TModel">Tipo de Modelo a validar.</typeparam>
        /// <param name="model">Modelo a validar.</param>
        /// <param name="handler">Administrador de Errores.</param>
        /// <param name="operation">Tipo de Operación a realizar dentro de la base de datos.</param>
        /// <returns>Verdadero cuando el administrador de errores no detectó algún problema; de lo contrario, Falso.</returns>
        public static bool Validate<TModel>(TModel model, ErrorHandler handler, Operations operation = Operations.DEFAULT) where TModel : new()
        {
            if (model == null)
            {
                handler.Add("MODELO_NULO");
                return false;
            }

            if (model is IActivable activable && (operation.Equals(Operations.UPDATE) || operation.Equals(Operations.DELETE)))
            {
                if (!activable.Estado) handler.Add("ESTADO_INACTIVO");
            }

            if (model is IDateable dateable && (operation.Equals(Operations.CREATE) || operation.Equals(Operations.UPDATE)))
            {
                if (dateable.Fecha == null) handler.Add("FECHA_DEFAULT");
            }

            if (model is IEmpleable empleable && (operation.Equals(Operations.CREATE) || operation.Equals(Operations.UPDATE)))
            {
                if (empleable.IdEmpleado.Equals(default) || empleable.IdEmpleado <= 0) handler.Add("ID_EMPLEADO_DEFAULT");
            }

            if (model is IIdentity identity && (operation.Equals(Operations.UPDATE) || operation.Equals(Operations.DELETE)))
            {
                if (identity.Id.Equals(default) || identity.Id <= 0) handler.Add("ID_DEFAULT");
            }

            if (model is INameable nameable && (operation.Equals(Operations.CREATE) || operation.Equals(Operations.UPDATE)))
            {
                if (string.IsNullOrEmpty(nameable.Nombre)) handler.Add("NOMBRE_VACIO");
            }

            if (model is IPerson person && (operation.Equals(Operations.CREATE) || operation.Equals(Operations.UPDATE)))
            {
                if (string.IsNullOrEmpty(person.PrimerNombre)) handler.Add("PRIMER_NOMBRE_VACIO");

                if (person.PrimerNombre.Length > 50) handler.Add("LONGITUD_PRIMER_NOMBRE_EXCEDIDA");

                if (person.SegundoNombre.Length > 50) handler.Add("LONGITUD_SEGUNDO_NOMBRE_EXCEDIDA");

                if (string.IsNullOrEmpty(person.PrimerApellido)) handler.Add("PRIMER_APELLIDO_VACIO");

                if (person.PrimerApellido.Length > 50) handler.Add("LONGITUD_PRIMER_APELLIDO_EXCEDIDA");

                if (person.SegundoApellido.Length > 50) handler.Add("LONGITUD_SEGUNDO_APELLIDO_EXCEDIDA");

                if (person.Telefono.Length != 8) handler.Add("TELEFONO_INCORRECTO");

                if (person.Direccion.Length > 500) handler.Add("LONGITUD_DIRECCION_EXCEDIDA");
            }

            if (model is ISecurity security && (operation.Equals(Operations.CREATE) || operation.Equals(Operations.UPDATE)))
            {
                if (string.IsNullOrEmpty(security.Clave)) handler.Add("CLAVE_VACIA");

                if (security.Clave.Length < 6) handler.Add("LONGITUD_CLAVE_CORTA");
            }

            if (model is ITransactionDetail transactionDetail && (operation.Equals(Operations.CREATE) || operation.Equals(Operations.UPDATE)))
            {
                if (transactionDetail.Cantidad < 0) handler.Add("CANTIDAD_INCORRECTA");

                if (transactionDetail.Descuento < 0) handler.Add("DESCUENTO_INCORRECTO");
            }

            return !handler.HasError();
        }

        /// <summary>
        /// Operaciones a realizar dentro de la base de datos.
        /// </summary>
        internal enum Operations
        {
            DEFAULT = 0,
            CREATE = 1,
            UPDATE = 2,
            DELETE = 3
        }
    }
}
