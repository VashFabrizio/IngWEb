using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebDemo02.Controllers
{
    public class ListarController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

             


        public JsonResult listarTodo()
        {
            Evento c = new Evento();
            promotecEntities3 a = new promotecEntities3();

            string dni = LoginController.DNI;

            IEnumerable<WebDemo02.Models.Eventos> ahora = a.Evento.Select(x => new WebDemo02.Models.Eventos
            {   fecha = x.fecha,
                hora = x.hora,
                nombre = x.nombre,
                lugar = x.lugar,
                dni = x.dni
            }).Where(y => y.dni == dni);
            
            return  Json(ahora,JsonRequestBehavior.AllowGet);
        }       

    }
}