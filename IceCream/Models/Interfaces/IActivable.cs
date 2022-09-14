namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee una propiedad que indica su estado:
    /// Activo o Inactivo.
    /// </summary>
    public interface IActivable
    {
        /// <summary>
        /// Estado de la clase. Este puede ser Activo o Inactivo.
        /// </summary>
        bool Estado { get; set; }
    }
}
