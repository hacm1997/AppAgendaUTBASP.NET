using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppAgendaUTBAPSN.NET.Modelo
{
    public abstract class Personas
    {
        private string identifiacion;
        private string nombres;
        private string apellidos;
        private string emailP;
        private string emailW;
        private string telefonoP;
        private string telefonoW;

        public string Identifiacion
        {
            get { return identifiacion; }
            set { identifiacion = value; }
        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string EmailP
        {
            get { return emailP; }
            set { emailP = value; }
        }

        public string EmailW
        {
            get { return emailW; }
            set { emailW = value; }
        }

        public string TelefonoP
        {
            get { return telefonoP; }
            set { telefonoP = value; }
        }

        public string TelefonoW
        {
            get { return telefonoW; }
            set { telefonoW = value; }
        }

        public Personas() 
        {
            this.identifiacion = "XXXXXXX";
            this.nombres = "name";
            this.apellidos = "apellidos";
            this.emailP = "emailP@dominio.com";
            this.emailW = "emailW@dominio.com";
            this.telefonoP = "XXXXXXXX";
            this.telefonoW = "XXXXXXXX";
        }

        public Personas(string identificacion, string nombres, string apellidos, string emailP, string emailW, string telefonoP, string telefonoW)
        {
            this.identifiacion = identifiacion;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.emailP = emailP;
            this.emailW = emailW;
            this.telefonoP = telefonoP;
            this.telefonoW = telefonoW;
        }

        public override string ToString()
        {
            return "\n=================================\n" +
            "Identificación: " + this.identifiacion + "\n" +
            "Nombres: " + this.nombres + "\n" +
            "Apellidos: " + this.apellidos + "\n" +
            "Email P.: " + this.emailP + "\n" +
            "Email W.: " + this.emailW + "\n" +
            "Telefono P.: " + this.telefonoP + "\n" +
            "Telefono W.: " + this.telefonoW;
        }

        public override bool Equals(object obj)
        {
            Personas o = (Personas)obj;
            bool result = false;

            if ((this.identifiacion == o.identifiacion) &&
                (this.nombres == o.nombres) && (this.apellidos == o.apellidos) &&
                (this.emailP == o.emailP) && (this.emailW == o.emailW) &&
                (this.telefonoP == o.telefonoP) && (this.telefonoW == o.telefonoW))
                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

    }
}