using Connection.Base;
using Models.Ventas;
using System;
using System.Collections.Generic;

namespace Connection.Interfaces.Ventas
{
    /// <summary>
    /// Indica que una clase implementará el DAO para las Ventas.
    /// </summary>
    public interface IVentaDao : IDao<Venta>
    {
        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar un registro que contenga el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único de la Venta.</param>
        /// <returns>Objeto de tipo Venta que resulte de la búsqueda.</returns>
        Venta GetById(int id);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros que contengan la fecha a filtrar.
        /// </summary>
        /// <param name="fecha">Fecha de la Venta.</param>
        /// <returns>Colección de objetos de tipo Venta que resulten de la búsqueda.</returns>
        IEnumerable<Venta> Read(DateTime fecha);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros que contengan el ID del Cliente a filtrar.
        /// </summary>
        /// <param name="idCliente">Identificador único del Cliente.</param>
        /// <returns>Colección de objetos de tipo Venta que resulten de la búsqueda.</returns>
        IEnumerable<Venta> GetByIdCliente(int idCliente);

        /// <summary>
        /// Realiza una búsqueda dentro de la base de datos hasta encontrar una serie de registros que contengan el ID del Empleado a filtrar.
        /// </summary>
        /// <param name="idEmpleado">Identificador único del Empleado.</param>
        /// <returns>Colección de objetos de tipo Venta que resulten de la búsqueda.</returns>
        IEnumerable<Venta> GetByIdEmpleado(int idEmpleado);
    }
}
