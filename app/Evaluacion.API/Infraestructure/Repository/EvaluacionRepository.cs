using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Proyecto.Evaluacion.API.Infraestructure.Context;
using Proyecto.Evaluacion.API.ViewModels.Request;

namespace Proyecto.Evaluacion.API.Infraestructure.Repository
{
    public class EvaluacionRepository : IEvaluacionRepository
    {
        private readonly EvaluacionContext dbContext;

        public EvaluacionRepository(EvaluacionContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Models.Evaluacion GetEvaluacion(GetEvaluacionRequest request)
        {
            var result = dbContext.Evaluacion.Where(o => o.EvaluacionId == request.EvaluacionId).FirstOrDefault();

            return result;
        }

        public List<Models.Evaluacion> GetListEvaluacion(GetListEvaluacionRequest request)
        {
            var result = dbContext.Evaluacion.Where(o =>
            (request.FechaInicio == null || Convert.ToDateTime(request.FechaInicio).Date <= o.FechaCreacion) &&
            (request.FechaFin == null || Convert.ToDateTime(request.FechaFin).Date.AddDays(1) < request.FechaFin)
            ).ToList();

            return result;
        }

        public Models.Evaluacion InsEvaluacion(InsEvaluacionRequest request)
        {
            var evaluacion = new Models.Evaluacion();

            evaluacion.UsuarioId = request.UsuarioId;
            evaluacion.Comentario = request.Comentario;
            evaluacion.Calificacion = request.Calificacion;
            evaluacion.FechaCreacion = DateTime.UtcNow;

            dbContext.Evaluacion.Add(evaluacion);
            dbContext.SaveChanges();

            return evaluacion;
        }

        public Models.Evaluacion UpdEvaluacion(UpdEvaluacionRequest request)
        {
            var evaluacion = dbContext.Evaluacion.Where(o => o.EvaluacionId == request.EvaluacionId).FirstOrDefault();

            if (evaluacion == null)
                throw new Exception("No se encontro la Evaluación a modificar.");

            evaluacion.Comentario = request.Comentario;
            evaluacion.Calificacion = request.Calificacion;
            evaluacion.FechaModificacion = DateTime.UtcNow;

            dbContext.Evaluacion.Update(evaluacion);
            dbContext.SaveChanges();

            return evaluacion;
        }
    }
}
