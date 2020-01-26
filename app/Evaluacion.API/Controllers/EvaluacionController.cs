using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Proyecto.Evaluacion.API.Infraestructure.Repository;
using Proyecto.Evaluacion.API.ViewModels;
using AutoMapper;
using Proyecto.Evaluacion.API.ViewModels.Request;
using Proyecto.Evaluacion.API.ViewModels.Response;

namespace Proyecto.Evaluacion.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EvaluacionController : ControllerBase
    {
        private readonly IEvaluacionRepository evaluacionRepository;
        private readonly IMapper mapper;

        public EvaluacionController(IEvaluacionRepository evaluacionRepository, IMapper mapper)
        {
            this.evaluacionRepository = evaluacionRepository;
            this.mapper = mapper;
        }

        [HttpPost]
        public ResponseEntity<EvaluacionViewModel> GetEvaluacion(GetEvaluacionRequest request)
        {
            var evaluacion = evaluacionRepository.GetEvaluacion(request);
            EvaluacionViewModel evaluacionViewModel = mapper.Map<EvaluacionViewModel>(evaluacion);

            return ResponseEntity<EvaluacionViewModel>.Create(evaluacionViewModel);
        }

        [HttpPost]
        public ResponseEntity<List<EvaluacionViewModel>> GetListEvaluacion(GetListEvaluacionRequest request)
        {
            var evaluacion = evaluacionRepository.GetListEvaluacion(request);
            List<EvaluacionViewModel> evaluacionViewModel = mapper.Map<List<EvaluacionViewModel>>(evaluacion);

            return ResponseEntity<List<EvaluacionViewModel>>.Create(evaluacionViewModel);
        }

        [HttpPost]
        public ResponseEntity<EvaluacionViewModel> InsEvaluacion(InsEvaluacionRequest request)
        {
            var evaluacion = evaluacionRepository.InsEvaluacion(request);
            EvaluacionViewModel evaluacionViewModel = mapper.Map<EvaluacionViewModel>(evaluacion);

            return ResponseEntity<EvaluacionViewModel>.Create(evaluacionViewModel);
        }

        [HttpPost]
        public ResponseEntity<EvaluacionViewModel> UpdEvaluacion(UpdEvaluacionRequest request)
        {
            var evaluacion = evaluacionRepository.UpdEvaluacion(request);
            EvaluacionViewModel evaluacionViewModel = mapper.Map<EvaluacionViewModel>(evaluacion);

            return ResponseEntity<EvaluacionViewModel>.Create(evaluacionViewModel);
        }
    }
}