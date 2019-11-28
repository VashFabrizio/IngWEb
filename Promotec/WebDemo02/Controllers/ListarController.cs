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
            promotecEntities3 a = new promotecEntities3();

            string dni = LoginController.DNI;

            IEnumerable<WebDemo02.Models.Eventos> search = a.Evento.Select(x => new WebDemo02.Models.Eventos
            {   fecha = x.fecha,
                hora = x.hora,
                nombre = x.nombre,
                lugar = x.lugar,
                dni = x.dni
            }).Where(y => y.dni == dni);
            
            return  Json(search, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult listarlistarporfecha(DateTime val1)
        {
            
            promotecEntities3 a = new promotecEntities3();
         
            IEnumerable<WebDemo02.Models.Eventos> newRequest = a.Evento.Select(x => new WebDemo02.Models.Eventos
            {
                fecha = x.fecha,
                hora = x.hora,
                nombre = x.nombre,
                lugar = x.lugar,
                dni = x.dni
            }).Where(y => y.fecha == val1);

            return Json(newRequest, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult listarlistarporname(string val1)
        {

            promotecEntities3 a = new promotecEntities3();

            IEnumerable<WebDemo02.Models.Eventos> newRequest = a.Evento.Select(x => new WebDemo02.Models.Eventos
            {
                fecha = x.fecha,
                hora = x.hora,
                nombre = x.nombre,
                lugar = x.lugar,
                dni = x.dni
            }).Where(y => y.nombre == val1);

            return Json(newRequest, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult listarlistarportime(string val1)
        {

            promotecEntities3 a = new promotecEntities3();

            IEnumerable<WebDemo02.Models.Eventos> newRequest = a.Evento.Select(x => new WebDemo02.Models.Eventos
            {
                fecha = x.fecha,
                hora = x.hora,
                nombre = x.nombre,
                lugar = x.lugar,
                dni = x.dni
            }).Where(y => y.hora == val1);

            return Json(newRequest, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult listarlistarpor(DateTime val1, string val2, string val3)
        {

            promotecEntities3 a = new promotecEntities3();

            IEnumerable<WebDemo02.Models.Eventos> newRequest = a.Evento.Select(x => new WebDemo02.Models.Eventos
            {
                fecha = x.fecha,
                hora = x.hora,
                nombre = x.nombre,
                lugar = x.lugar,
                dni = x.dni
            }).Where(y => y.fecha == val1 && y.nombre == val2 && y.hora == val3);

            return Json(newRequest, JsonRequestBehavior.AllowGet);
        }

    }
}