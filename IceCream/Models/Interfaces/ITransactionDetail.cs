namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee atributos correspondientes a un detalle de una
    /// transacción.
    /// </summary>
    public interface ITransactionDetail
    {
        /// <summary>
        /// Cantidad de elementos o artículos involucrados en la transacción.
        /// </summary>
        float Cantidad { get; set; }

        /// <summary>
        /// Descuento aplicado a la transacción.
        /// </summary>
        float Descuento { get; set; }
    }
}
