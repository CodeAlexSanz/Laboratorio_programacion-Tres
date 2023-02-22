using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_AlexanderZelaya
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private Departamento departamento;
        private Municipio municipio;

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

        public Departamento Departamento
        {
            get => departamento;
            set => departamento = value;
        }
        public Municipio Municipio
        {
            get => municipio;
            set => municipio = value;
        }

        public void obtenerDatosUsuario()
        {

        }
    }
}
