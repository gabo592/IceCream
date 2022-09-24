using Connection.Base;
using Models.Compras;
using System;
using System.Collections.Generic;


namespace Connection.Interfaces.Compras
{
    /// <summary>
    /// Indica que una clase implementará el DAO para las Compras.
    /// </summary>
    public interface ICompraDao : IDao<Compra>
    {
        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar el registro que coincida con
        /// el ID a filtrar.
        /// </summary>
        /// <param name="id">Identificador único de la Compra a buscar.</param>
        /// <returns>Objeto de tipo Compra que resulte de la búsqueda.</returns>
        Compra GetById(int id);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una serie de registros que
        /// coincidan con la fecha a filtrar.
        /// </summary>
        /// <param name="fecha">Fecha en la que se realizó la compra.</param>
        /// <returns>Colección de objetos de tipo Compra que resulten de la búsqueda.</returns>
        IEnumerable<Compra> Read(DateTime fecha);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una serie de registros que
        /// coincidan con el ID del proveedor a filtrar.
        /// </summary>
        /// <param name="idProveedor">Identificador único del Proveedor al que se le realizó la compra.</param>
        /// <returns>Colección de objetos de tipo Compra que resulten de la búsqueda.</returns>
        IEnumerable<Compra> GetByIdProveedor(int idProveedor);

        /// <summary>
        /// Realiza la búsqueda dentro de la base de datos hasta encontrar una serie de registros que
        /// coincidan con el ID del empleado a filtrar.
        /// </summary>
        /// <param name="idEmpleado">Identificador único del Empleado que realizó la compra.</param>
        /// <returns>Colección de objetos de tipo Compra que resulten de la búsqueda.</returns>
        IEnumerable<Compra> GetByIdEmpleado(int idEmpleado);
    }
}
