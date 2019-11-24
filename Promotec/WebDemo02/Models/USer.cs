using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDemo02.Models
{
    public class USer
    {
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string contraseña { get; set; }
        public string user_type { get; set; }

        public static implicit operator usuario(USer model)
        {
            if (model == null) return null;
            return new usuario
            {
                dni = model.dni,
                nombre = model.nombre,
                apellidos = model.apellidos,
                direccion = model.direccion,
                telefono = model.telefono,
                contraseña = model.contraseña,
                user_type = model.user_type
            };
        }
        public static implicit operator USer(usuario model)
        {
            if (model == null) return null;
            return new USer
            {
                dni = model.dni,
                nombre = model.nombre,
                apellidos = model.apellidos,
                direccion = model.direccion,
                telefono = model.telefono,
                contraseña = model.contraseña,
                user_type = model.user_type
            };
        }
    }
}