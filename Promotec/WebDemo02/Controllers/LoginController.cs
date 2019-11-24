using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebDemo02.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public static string DNI;
        public static string NOMBRE;
        private static string returnDNI()
        {
           return DNI;
        }
        [HttpPost]
        public JsonResult Verify(WebDemo02.Models.USer user)
        {
            promotecEntities3 a = new promotecEntities3();

             
            IEnumerable<WebDemo02.Models.USer> ahora = a.usuario.Select(x => new WebDemo02.Models.USer
            {
                apellidos = x.apellidos,
                nombre = x.nombre,
                direccion = x.direccion,
                dni = x.dni,
                telefono = x.telefono
            }).Where(y => y.dni == user.dni && y.contraseña == user.contraseña);

            var adsa = a.usuario.Where(x => x.dni == user.dni && x.contraseña == user.contraseña).FirstOrDefault();

            if (adsa != null)
            {
                DNI = user.dni;
                NOMBRE = adsa.nombre;
                return Json("success");
            }
             return Json("Nada");
        }
    }
}