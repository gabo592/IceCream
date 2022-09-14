﻿using Models.Interfaces;

namespace Models.Ubicacion
{
    /// <summary>
    /// Objeto simple de tipo Municipio.
    /// </summary>
    public class Municipio : IIdentity, INameable
    {
        /// <inheritdoc cref="IIdentity.Id"/>
        public int Id { get; set; }

        /// <inheritdoc cref="INameable.Nombre"/>
        public string Nombre { get; set; }

        /// <summary>
        /// Identificador único del Departamento al que pertenece el Municipio.
        /// </summary>
        public int IdDepartamento { get; set; }
    }
}
