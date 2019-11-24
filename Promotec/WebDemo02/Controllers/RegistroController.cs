using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDemo02.Controllers
{
    public class RegistroController : Controller
    {
        // GET: Registro
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult UserRegister(WebDemo02.Models.USer evento)
        {
            promotecEntities3 a = new promotecEntities3();
            WebDemo02.Models.USer newuser = new WebDemo02.Models.USer
            {
               dni = evento.dni,
               nombre = evento.nombre,
               apellidos = ".",
               direccion = evento.direccion,
               telefono = evento.telefono,
               contraseña = evento.contraseña,
               user_type = evento.user_type
            };
            try
            {
                a.usuario.Add(newuser);

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