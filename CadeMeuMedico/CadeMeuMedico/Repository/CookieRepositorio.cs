using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Repository
{
    public class CookieRepositorio
    {
        public static void RegistraCookieAutenticacao(long IDusuario)
        {
            HttpCookie UserCookie = new HttpCookie("UserCookieAuthentication");

            UserCookie.Values["IDusuario"] = CadeMeuMedico.Repository.RepositorioCriptografia.Criptografar(IDusuario.ToString());

            UserCookie.Expires = DateTime.Now.AddDays(1);

            HttpContext.Current.Response.Cookies.Add(UserCookie);
        }
    }
}