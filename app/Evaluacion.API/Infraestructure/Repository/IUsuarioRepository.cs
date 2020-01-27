using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Proyecto.Evaluacion.API.Models;
using Proyecto.Evaluacion.API.ViewModels.Request;

namespace Proyecto.Evaluacion.API.Infraestructure.Repository
{
    public interface IUsuarioRepository
    {
        Usuario GetUsuario(GetUsuarioRequest request);
        Usuario InsUsuario(InsUsuarioRequest request);
        Usuario UpdaUsuario(UpdUsuarioRequest request);
        Usuario Login(InsUsuarioRequest request);
    }
}
