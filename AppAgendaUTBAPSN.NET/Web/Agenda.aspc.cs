using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppAgendaUTBAPSN.NET.Datos;
using AppAgendaUTBAPSN.NET.Modelo;

namespace AppAgendaUTBAPSN.NET.Web
{
    public partial class Agenda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PersonasPrepositorias Lista = new PersonasPrepositorias();

            string result = "";
            foreach (Personas elemt in Lista.getPersonas)
                result += "\n" + element;

            Label3.Text = result.ToString().Replace("\n");
        }
    }
}