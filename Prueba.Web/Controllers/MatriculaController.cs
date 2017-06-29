using Prueba.BL.Services;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba.Web.Controllers
{
    public class MatriculaController : Controller
    {
        MatriculaService service = null;
        public MatriculaController()
        {
            service = new MatriculaService();
        }
        // GET: Matricula
        public ActionResult Index(int id)
        {
            List<Matricula> lista = service.Listar();
            return View(lista);
        }

        // GET: Matricula/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Matricula/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Matricula/Create
        [HttpPost]
        public ActionResult Create(Matricula matricula)
        {
            bool result = service.Crear(matricula);
            if (result)
                return RedirectToAction("Index");
            else
                return View(matricula);
        }

        // GET: Matricula/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Matricula/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Matricula/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Matricula/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
