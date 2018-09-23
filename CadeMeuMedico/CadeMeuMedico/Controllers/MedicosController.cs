using CadeMeuMedico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class MedicosController : BaseController
    {
        private CadeMeuMedicoBDEntities db = new CadeMeuMedicoBDEntities();
        // GET: Medicos
        public ActionResult Index()
        {
            var medicos = db.Medicos.Include(s => s.Cidades).Include(m => m.Especialidades).ToList();
            return View(medicos);
        }

        public ActionResult Create()
        {
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Nome");
            ViewBag.IDEspecialidade = new SelectList(db.Especialidades,
            "IDEspecialidade",
            "Nome");

            return View();
        }

        [HttpPost]
        public ActionResult Create(Medicos medico)
        {
            if (ModelState.IsValid)
            {
                db.Medicos.Add(medico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade","Nome", medico.IDCidade);
            ViewBag.IDEspecialidade = new SelectList(db.Especialidades,
            "IDEspecialidade",
            "Nome",
            medico.IDEspecialidade);
            return View(medico);
        }

        public ActionResult Edit(long id)
        {
            Medicos medico = db.Medicos.Find(id);

            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidade", "Nome", medico.IDCidade);
            ViewBag.IDEspecialidade = new SelectList(db.Especialidades, "IDEspecialidade", "Nome", medico.IDEspecialidade);

            return View(medico);
        }


        [HttpPost]
        public ActionResult Edit(Medicos medico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medico).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDCidade = new SelectList(db.Cidades, "IDCidades", "Nome", medico.IDCidade);
            ViewBag.IDCidade = new SelectList(db.Especialidades, "IDEspecialidade", "Nome", medico.IDEspecialidade);

            return View(medico);
        }

        [HttpPost]
        public string Delete(long id)
        {
            try
            {
                Medicos medico = db.Medicos.Find(id);
                db.Medicos.Remove(medico);
                db.SaveChanges();
                return Boolean.TrueString;
            }
            catch
            {
                return Boolean.FalseString;
            }
        }

        [HttpGet]
        public JsonResult CheckCRM(string CRM)
        {
            var result = db.Medicos.Where(m => m.CRM == CRM).ToList().Count() == 0;
            return Json(result, JsonRequestBehavior.AllowGet);
        }



    }
}