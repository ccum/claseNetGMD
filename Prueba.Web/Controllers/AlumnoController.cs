using Prueba.BL.Services;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba.Web.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {
            AlumnosService service = new AlumnosService();
            List<Alumno> result = service.Listar();
            return View(result);
        }
        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Crear(Alumno alumno)
        {
            AlumnosService service = new AlumnosService();
            if (service.Crear(alumno))
                return RedirectToAction("Index");
            return View(alumno);
        }
        [HttpGet]
        public ActionResult Editar(int id)
        {
            AlumnosService service = new AlumnosService();
            Alumno alumno = service.BuscarPorId(id);
            return View(alumno);
        }
        [HttpPost]
        public ActionResult Editar(Alumno alumno)
        {
            AlumnosService service = new AlumnosService();
            service.Editar(alumno);
            return RedirectToAction("Index");
        }
    }
}