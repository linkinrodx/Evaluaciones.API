using System;
using System.Collections.Generic;

namespace Proyecto.Evaluacion.API.Models
{
    public partial class Usuario
    {
        public int UsuarioId { get; set; }
        public string Correo { get; set; }
        public string Nombres { get; set; }
        public bool Eliminado { get; set; }
    }
}