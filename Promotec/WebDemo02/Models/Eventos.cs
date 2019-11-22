using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDemo02.Models
{
    public class Eventos
    {
        public string nombre  { get; set; }
        public DateTime fecha { get; set; }
        public string lugar { get; set; }
        public string hora { get; set; }

        public static implicit operator Evento(Eventos model)
        {
            if (model == null) return null;
            return new Evento
            {
                nombre = model.nombre,
                fecha = model.fecha,
                lugar = model.lugar,
                hora = model.hora
            };
        }
        public static implicit operator Eventos(Evento model)
        {
            if (model == null) return null;
            return new Eventos
            {
                nombre = model.nombre,
                fecha = model.fecha,
                lugar = model.lugar,
                hora = model.hora
            };
        }
    }

    
}