﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rp3.AgendaComercial.Web.Services.Ruta.Models
{
    public class AgendaTareaActividad
    {
        public int IdRuta { get; set; }
        public long IdAgenda { get; set; }
        public long IdTarea { get; set; }
        public int IdTareaActividad { get; set; }
        public string Descripcion { get; set; }
        public int IdTipoActividad { get; set; }
        public string Tipo { get; set; }
        public int Orden { get; set; }
        public int? IdTareaActividadPadre { get; set; }
        public int? IdTareaOpcion { get; set; }
        public string Resultado { get; set; }
        public string ResultadoCodigo { get; set; }
        public List<AgendaTareaOpcion> AgendaTareaOpciones { get; set; }
    }

    public class AgendaTareaActividadUpdate
    {
        public long IdTarea { get; set; }
        public int IdTareaActividad { get; set; }
        public int? IdTareaOpcion { get; set; }
        public string Resultado { get; set; }
        public string ResultadoCodigo { get; set; }
    }
}