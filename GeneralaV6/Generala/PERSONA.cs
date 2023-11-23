using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generala
{
    public class PERSONA
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}