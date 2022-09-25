namespace Connection.Constantes
{
    /// <summary>
    /// Clase encargada de contener los procedimientos almacenados que el programa ejecutará en la base de datos.
    /// Esta clase no puede heredarse.
    /// </summary>
    internal sealed class StoredProcedures
    {
        #region Compras

        public const string CompraCreate = "COMPRA_CREATE";
        public const string CompraRead = "COMPRA_READ";
        public const string CompraUpdate = "COMPRA_UPDATE";
        public const string CompraDelete = "COMPRA_DELETE";

        public const string DetalleCompraCreate = "DETALLE_COMPRA_CREATE";
        public const string DetalleCompraRead = "DETALLE_COMPRA_READ";
        public const string DetalleCompraUpdate = "DETALLE_COMPRA_UPDATE";
        public const string DetalleCompraDelete = "DETALLE_COMPRA_DELETE";

        public const string ProveedorCreate = "PROVEEDOR_CREATE";
        public const string ProveedorRead = "PROVEEDOR_READ";
        public const string ProveedorUpdate = "PROVEEDOR_UPDATE";
        public const string ProveedorDelete = "PROVEEDOR_DELETE";

        #endregion
    }
}
