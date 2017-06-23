using Prueba.BL.Services;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba.Web.Controllers
{
    public class ClaseController : Controller
    {
        ClaseService service = new ClaseService();

        public ClaseController()
        {
            
        }
        
        // GET: Clase
        public ActionResult Index()
        {

            List<Clase> lista = service.ListarClases();

            return View(lista);
        }
    }
}