using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace Common.Util
{
    /// <summary>
    /// Clase encargada de administrar los errores que la aplicación origine.
    /// </summary>
    public class ErrorHandler : List<string>
    {
        /// <summary>
        /// Agrega una excepción y su mensaje de error a la lista de errores alamacenados.
        /// </summary>
        /// <param name="exception">Excepción a agregar.</param>
        public void Add(Exception exception)
        {
            if (exception is null) return;

            if (exception.InnerException != null)
            {
                Add(exception.InnerException);
                return;
            }

            Add(exception.Message);
        }

        /// <summary>
        /// Verifica si el administrador contiene errores almacenados.
        /// </summary>
        /// <returns>Verdadero si contiene errores; de lo contrario, Falso.</returns>
        public bool HasError() => Count > 0;

        /// <summary>
        /// Busca dentro de la lista de errores almacenados todos los mensajes que éstos contengan.
        /// </summary>
        /// <returns>Mensajes de errores almacenados.</returns>
        public string GetErrorMessage()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string message;
            ResourceManager resourceManager = new ResourceManager(typeof(Resources.Messages));

            foreach (string name in this)
            {
                message = resourceManager.GetString(name);

                if (message is null) message = $"{name}";

                stringBuilder.AppendLine(message);
            }

            return stringBuilder.ToString();
        }

    }
}
