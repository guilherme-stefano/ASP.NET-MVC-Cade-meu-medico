using CadeMeuMedico.Models;
using CadeMeuMedico.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class UsuariosController : Controller
    {
        private CadeMeuMedicoBDEntities db = new CadeMeuMedicoBDEntities();
        // GET: usuarios

        [HttpGet]
        public JsonResult AutenticacaoDeUsuario(string login, string senha)
        {
            if (UsuarioRepositorio.AutenticarUsuario(login, senha))
            {
                return Json(new
                {
                    Ok = true,
                    Mensagem = "Usuário autenticado. Redirecionado ..."
                }, JsonRequestBehavior.AllowGet);
            } else
            {
                return Json(new
                {
                    Ok = false,
                    Mensagem = "Usuãrio não encontrado. Tente Novamento."
                }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Index()
        {
            var usuarios = db.Usuarios;
            return View(usuarios);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Usuarios usuario)
        {
            if(ModelState.IsValid)
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        public ActionResult Edit(long id)
        {
            var usuario = db.Usuarios.Find(id);

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Edit(Usuarios usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        [HttpPost]
        public string Delete(Usuarios usuario)
        {
            try {
                db.Usuarios.Remove(usuario);
                db.SaveChanges();
                return Boolean.TrueString;
            }
            catch
            {
                return Boolean.FalseString;
            }
        }
    }
}