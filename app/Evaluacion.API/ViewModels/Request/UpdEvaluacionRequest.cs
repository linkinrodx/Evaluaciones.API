﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Evaluacion.API.ViewModels.Request
{
    public class UpdEvaluacionRequest
    {
        public int EvaluacionId { get; set; }
        public int UsuarioId { get; set; }
        public string Comentario { get; set; }
        public int Calificacion { get; set; }
    }
}
