using CadeMeuMedico.Models;
using CadeMeuMedico.ViewModels;
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
            var medicosViewModel = AutoMapper.Mapper.Map<IEnumerable<Medicos>, IEnumerable<MedicosViewModel>>(medicos);
            return View(medicosViewModel);
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
                int indexNome = 0;

                while (Request["certificado[" + indexNome + "].Nome"] != null)
                {
                    string inputNome = "certificado[" + indexNome + "].Nome";
                    string nome = Request[inputNome];
                    Certificados certificado = new Certificados();
                    certificado.Nome = nome;
                    certificado.IDMedico = medico.IDMedico;
                    db.Certificados.Add(certificado);
                    indexNome++;
                }
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
            var medicoViewModel = AutoMapper.Mapper.Map<Medicos, MedicosViewModel>(medico);
            ViewBag.cidades = PopulateCidades();
            ViewBag.especialidades = db.Especialidades;

            return View(medicoViewModel);
        }


        [HttpPost]
        public ActionResult Edit(MedicosViewModel medicoViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.cidades = PopulateCidades();
                ViewBag.especialidades = db.Especialidades;

                return View(medicoViewModel);
            }

            var medico = AutoMapper.Mapper.Map<MedicosViewModel, Medicos>(medicoViewModel);
            db.Entry(medico).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");

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
        public JsonResult CheckUnique(int? IdSetorTrabalho, string Descricao)
        {

            var result = true;

            return Json(result, JsonRequestBehavior.AllowGet);
        }


        public List<SelectListItem> PopulateCidades()
        {
            var cidades = db.Cidades;
            var selectCidade = new List<SelectListItem>();

            foreach (var item in cidades)
            {
                var listItem = new SelectListItem();
                listItem.Text = item.Nome;
                listItem.Value = item.IDCidade.ToString();

                selectCidade.Add(listItem);
            }

            return selectCidade;
        }
    }
}