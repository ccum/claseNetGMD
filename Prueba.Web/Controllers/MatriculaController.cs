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
        AlumnosService alumnoService = null;
        public MatriculaController()
        {
            service = new MatriculaService();
            alumnoService = new AlumnosService();
        }
        // GET: Matricula
        public ActionResult Index(int id)
        {
            List<Matricula> lista = service.ListadoPorAlumno(id);
            Alumno alumno = alumnoService.BuscarPorId(id);
            ViewBag.NombreAlumno = alumno.Apellido + " " + alumno.Nombre; 
            ViewBag.AlumnoId = id;
            return View(lista);
        }

        // GET: Matricula/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Matricula/Create
        public ActionResult Create(int IdAlumno)
        {
            Matricula mat = new Matricula();
            mat.AlumnoId = IdAlumno;
            return View(mat);
        }

        // POST: Matricula/Create
        [HttpPost]
        public ActionResult Create(Matricula matricula)
        {
            bool result = service.Crear(matricula);
            if (result)
                return RedirectToAction("Index", new { id = matricula.AlumnoId });
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
