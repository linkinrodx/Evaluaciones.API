using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using AutoMapper;
using Proyecto.Evaluacion.API.Infraestructure.Repository;
using Proyecto.Evaluacion.API.ViewModels;
using Proyecto.Evaluacion.API.ViewModels.Request;
using Proyecto.Evaluacion.API.ViewModels.Response;

namespace Proyecto.Evaluacion.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository usuarioRepository;
        private readonly IMapper mapper;

        public UsuarioController(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            this.usuarioRepository = usuarioRepository;
            this.mapper = mapper;
        }

        [HttpPost]
        public ResponseEntity<UsuarioViewModel> GetUsuario(GetUsuarioRequest request)
        {
            var usuario = usuarioRepository.GetUsuario(request);
            UsuarioViewModel usuarioViewModel = mapper.Map<UsuarioViewModel>(usuario);

            return ResponseEntity<UsuarioViewModel>.Create(usuarioViewModel);
        }


        [HttpPost]
        public ResponseEntity<UsuarioViewModel> InsUsuario(InsUsuarioRequest request)
        {
            var usuario = usuarioRepository.InsUsuario(request);
            UsuarioViewModel usuarioViewModel = mapper.Map<UsuarioViewModel>(usuario);

            return ResponseEntity<UsuarioViewModel>.Create(usuarioViewModel);
        }

        [HttpPost]
        public ResponseEntity<UsuarioViewModel> UpdaUsuario(UpdUsuarioRequest request)
        {
            var usuario = usuarioRepository.UpdaUsuario(request);
            UsuarioViewModel usuarioViewModel = mapper.Map<UsuarioViewModel>(usuario);

            return ResponseEntity<UsuarioViewModel>.Create(usuarioViewModel);
        }

        [HttpPost]
        public ResponseEntity<UsuarioViewModel> Login(InsUsuarioRequest request)
        {
            var usuario = usuarioRepository.Login(request);
            UsuarioViewModel usuarioViewModel = mapper.Map<UsuarioViewModel>(usuario);

            return ResponseEntity<UsuarioViewModel>.Create(usuarioViewModel);
        }
    }
}