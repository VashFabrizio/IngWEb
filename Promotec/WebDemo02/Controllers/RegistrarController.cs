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
            promotecEntities1 a = new promotecEntities1();
            WebDemo02.Models.Eventos person = new WebDemo02.Models.Eventos
            {
                nombre = evento.nombre,
                fecha = evento.fecha,
                lugar = evento.lugar,
                hora = evento.hora,
                dni = "73144681"

            };
            try
            {
                a.Evento.Add(person);

                a.SaveChanges();
                return Json("Registrado");
            }
            catch (Exception e)
            {
                return Json("va");
                throw;
            }


        }

    }
}