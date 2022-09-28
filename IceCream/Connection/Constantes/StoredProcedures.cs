﻿namespace Connection.Constantes
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

        #region Inventario

        public const string CategoriaProductoCreate = "CATEGORIA_PRODUCTO_CREATE";
        public const string CategoriaProductoRead = "CATEGORIA_PRODUCTO_READ";
        public const string CategoriaProductoUpdate = "CATEGORIA_PRODUCTO_UPDATE";
        public const string CategoriaProductoDelete = "CATEGORIA_PRODUCTO_DELETE";

        public const string DetalleProductoCreate = "DETALLE_PRODUCTO_CREATE";
        public const string DetalleProductoRead = "DETALLE_PRODUCTO_READ";
        public const string DetalleProductoUpdate = "DETALLE_PRODUCTO_UPDATE";
        public const string DetalleProductoDelete = "DETALLE_PRODUCTO_DELETE";

        public const string MateriaPrimaCreate = "MATERIA_PRIMA_CREATE";
        public const string MateriaPrimaRead = "MATERIA_PRIMA_READ";
        public const string MateriaPrimaUpdate = "MATERIA_PRIMA_UPDATE";
        public const string MateriaPrimaDelete = "MATERIA_PRIMA_DELETE";

        public const string ProductoCreate = "PRODUCTO_CREATE";
        public const string ProductoRead = "PRODUCTO_READ";
        public const string ProductoUpdate = "PRODUCTO_UPDATE";
        public const string ProductoDelete = "PRODUCTO_DELETE";

        #endregion
    }
}