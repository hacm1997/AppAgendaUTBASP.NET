﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppAgendaUTBAPSN.NET.Modelo;

namespace AppAgendaUTBAPSN.NET.Datos
{
    public partial class PersonasPrepositorias
    {
        private List<Personas> data = new List<Personas>();

        public IEnumerable<Personas> getPersonas() 
        {
            Personas p1 = new Personas();
            Personas p2 = new Personas();

            data.Add(p1);
            data.Add(p2);

            return.data;
        }
    }
}