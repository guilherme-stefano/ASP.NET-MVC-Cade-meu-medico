using CadeMeuMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class EspecialidadesController : Controller
    {
        private CadeMeuMedicoBDEntities db = new CadeMeuMedicoBDEntities();
        // GET: Especialidades
        public ActionResult Index()
        {
            var especialidades = db.Especialidades;
            return View(especialidades);
        }

        public ActionResult Create()
        {

        }
    }
}