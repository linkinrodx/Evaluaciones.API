using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Proyecto.Evaluacion.API.ViewModels.Request;

namespace Proyecto.Evaluacion.API.Infraestructure.Repository
{
    public interface IEvaluacionRepository
    {
        Models.Evaluacion GetEvaluacion(GetEvaluacionRequest request);
        List<Models.Evaluacion> GetListEvaluacion(GetListEvaluacionRequest request);
        Models.Evaluacion InsEvaluacion(InsEvaluacionRequest request);
        Models.Evaluacion UpdEvaluacion(UpdEvaluacionRequest request);
    }
}
