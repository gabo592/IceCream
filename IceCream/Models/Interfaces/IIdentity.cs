namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee un campo único como identificador.
    /// </summary>
    public interface IIdentity
    {
        /// <summary>
        /// Identificador único de la clase.
        /// </summary>
        int Id { get; set; }
    }
}
