using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Evaluacion.API.ViewModels.Request
{
    public class UpdUsuarioRequest
    {
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
    }
}
