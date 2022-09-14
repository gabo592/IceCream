namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee un atributo de seguridad como una clave o contraseña.
    /// </summary>
    public interface ISecurity
    {
        /// <summary>
        /// Clave o contraseña que protege al objeto y/o su información.
        /// </summary>
        string Clave { get; set; }
    }
}
