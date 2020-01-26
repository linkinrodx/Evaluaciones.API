using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Evaluacion.API.ViewModels
{
    public class EvaluacionViewModel
    {
        public int EvaluacionId { get; set; }
        public int? UsuarioId { get; set; }
        public string Comentario { get; set; }
        public int? Calificacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
