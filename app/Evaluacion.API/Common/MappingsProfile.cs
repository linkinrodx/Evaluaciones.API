using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using Proyecto.Evaluacion.API.ViewModels;

namespace Proyecto.Evaluacion.API.Common
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Models.Evaluacion, EvaluacionViewModel>();
            CreateMap<Models.Usuario, UsuarioViewModel>();
        }
    }
}
