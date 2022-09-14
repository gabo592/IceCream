namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase tiene asociada otra de tipo Empleado.
    /// </summary>
    public interface IEmpleable
    {
        /// <summary>
        /// Identificador único del Empleado asociado a esta clase.
        /// </summary>
        int IdEmpleado { get; set; }
    }
}
