namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee un atributo de Nombre por el cual puede reconocerse.
    /// </summary>
    public interface INameable
    {
        /// <summary>
        /// Nombre del objeto.
        /// </summary>
        string Nombre { get; set; }
    }
}
