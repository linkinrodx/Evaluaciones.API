using System;
using System.Collections.Generic;

namespace Proyecto.Evaluacion.API.Models
{
    public partial class Evaluacion
    {
        public int EvaluacionId { get; set; }
        public int UsuarioId { get; set; }
        public string Comentario { get; set; }
        public int Calificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}