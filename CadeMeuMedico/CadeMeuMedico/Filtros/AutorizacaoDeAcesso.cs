using CadeMeuMedico.Models;
using CadeMeuMedico.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Filtros
{
    [HandleError]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
    public class AutorizacaoDeAcesso : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filtroDeContexto)
        {
            var Controller = filtroDeContexto.ActionDescriptor.ControllerDescriptor.ControllerName;
            var Action = filtroDeContexto.ActionDescriptor.ActionName;

            if(Controller != "Home" || Action != "Login")
            {
                if (UsuarioRepositorio.VerificaSeOUsuarioEstaLogado() == null)
                {
                    filtroDeContexto.
                        RequestContext.
                        HttpContext.
                        Response.
                        Redirect("/Home/Login?Url=" +
                            filtroDeContexto.
                            HttpContext.
                            Request.
                            Url.
                            LocalPath);
                }
            }
        }
    }
}