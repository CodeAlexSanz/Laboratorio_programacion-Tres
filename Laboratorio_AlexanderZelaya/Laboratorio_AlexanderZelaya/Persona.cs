using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_AlexanderZelaya
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private string departamento;
        private string municipio;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int Edad
        {
            get => edad;
            set => edad = value;
        }

        public string Departamento
        {
            get => departamento;
            set => departamento = value;
        }

        public string Municipio
        {
            get => municipio;
            set => municipio = value;
        }

        public Persona (string nombre, int edad, string departamento, string municipio)
        {
            Nombre = nombre;
            Edad = edad;
            Departamento = departamento;
            Municipio = municipio;
        }
    }
}
