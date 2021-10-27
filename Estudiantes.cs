using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia5_POO_RV202840
{
    class Estudiantes
    {
        string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string carnet;
        public string Carnet
        {
            get { return carnet; }
            set { carnet = value; }
        }

        string nacimiento;
        public string Nacimiento
        {
            get { return nacimiento; }
            set { nacimiento = value; }
        }

        string correo;
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        string responsable;
        public string Responsable
        {
            get { return responsable; }
            set { responsable = value; }
        }

        string materia;
        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }

        string notas;
        public string Notas
        {
            get { return notas; }
            set { notas = value; }
        }
    }
}
