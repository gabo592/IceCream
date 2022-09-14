namespace Models.Interfaces
{
    /// <summary>
    /// Indica que una clase posee atributos de una Persona.
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// Primer nombre de la Persona.
        /// </summary>
        string PrimerNombre { get; set; }

        /// <summary>
        /// Segundo Nombre de la Persona.
        /// </summary>
        string SegundoNombre { get; set; }

        /// <summary>
        /// Primer apellido de la Persona.
        /// </summary>
        string PrimerApellido { get; set; }

        /// <summary>
        /// Segundo Apellido de la Persona.
        /// </summary>
        string SegundoApellido { get; set; }

        /// <summary>
        /// Número de teléfono de la Persona.
        /// </summary>
        string Telefono { get; set; }

        /// <summary>
        /// Dirección de domicilio de la Persona.
        /// </summary>
        string Direccion { get; set; }

        /// <summary>
        /// Identificador único del Municipio donde queda ubicada su residencia.
        /// </summary>
        int IdMunicipio { get; set; }
    }
}
