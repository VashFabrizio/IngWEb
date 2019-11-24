using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDemo02.Controllers
{
    public class RegistrarController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public JsonResult PostMethod(WebDemo02.Models.Eventos evento)
        {
            string dni = LoginController.DNI;
            promotecEntities3 a = new promotecEntities3();
            WebDemo02.Models.Eventos person = new WebDemo02.Models.Eventos
            {
                nombre = evento.nombre,
                fecha = evento.fecha,
                lugar = evento.lugar,
                hora = evento.hora,
                dni = dni,
                Usuario = a.usuario.Where(x => x.dni == dni).FirstOrDefault()
            };
            try
            {
                a.Evento.Add(person);

                a.SaveChanges();
                return Json("Registrado");
            }
            catch (Exception e)
            {
                return Json(e);
                throw;
            }


        }

    }
}