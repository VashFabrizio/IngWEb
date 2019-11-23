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
            promotecEntities1 a = new promotecEntities1();

            IEnumerable<WebDemo02.Models.Eventos> ahora= a.Evento.Select(x => new WebDemo02.Models.Eventos
            {
                fecha = x.fecha,
                hora = x.hora,
                nombre = x.nombre,
                lugar = x.lugar,
            });
            
            return  Json(ahora,JsonRequestBehavior.AllowGet);
        }       

    }
}