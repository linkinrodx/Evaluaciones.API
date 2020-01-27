using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Evaluacion.API.ViewModels
{
    public class UsuarioViewModel
    {
        public int UsuarioId { get; set; }
        public string Correo { get; set; }
        public string Nombres { get; set; }
        public bool Eliminado { get; set; }
    }
}
