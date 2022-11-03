namespace IceCream.ViewModels.Seguridad
{
    /// <summary>
    /// Objeto simple de tipo Usuario desde una vista personalizada.
    /// </summary>
    internal class UsuarioView
    {
        /// <summary>
        /// Identificador único del usuario.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre de usuario.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Nombre del empleado asociado al usuario.
        /// </summary>
        public string Empleado { get; set; }
    }
}
