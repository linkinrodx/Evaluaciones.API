using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Proyecto.Evaluacion.API.Infraestructure.Context;
using Proyecto.Evaluacion.API.Models;
using Proyecto.Evaluacion.API.ViewModels.Request;

namespace Proyecto.Evaluacion.API.Infraestructure.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly EvaluacionContext dbcontext;

        public UsuarioRepository(EvaluacionContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public Usuario GetUsuario(GetUsuarioRequest request)
        {
            return dbcontext.Usuario.Where(o => o.UsuarioId == request.UsuarioId).FirstOrDefault();
        }

        public Usuario InsUsuario(InsUsuarioRequest request)
        {
            var usuario = new Usuario()
            {
                Correo = request.Correo
            };

            dbcontext.Usuario.Add(usuario);
            dbcontext.SaveChanges();

            return GetUsuario(new GetUsuarioRequest() { UsuarioId = usuario.UsuarioId });
        }

        public Usuario UpdaUsuario(UpdUsuarioRequest request)
        {
            var usuario = dbcontext.Usuario.Where(o => o.UsuarioId == request.UsuarioId).FirstOrDefault();

            if (usuario == null)
            {
                throw new Exception("No se encontro el usuario a modificar.");
            }

            dbcontext.Usuario.Update(usuario);
            dbcontext.SaveChanges();

            return GetUsuario(new GetUsuarioRequest() { UsuarioId = usuario.UsuarioId });
        }

        public Usuario Login(InsUsuarioRequest request)
        {
            var usuario = dbcontext.Usuario.Where(o => o.Correo == request.Correo).FirstOrDefault();

            if (usuario == null)
            {
                return InsUsuario(request);
            }
            else
            {
                return GetUsuario(new GetUsuarioRequest() { UsuarioId = usuario.UsuarioId });
            }
        }
    }
}
