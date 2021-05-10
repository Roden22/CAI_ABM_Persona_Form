using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas_From.Biblioteca
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private string _email;

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int Edad { get => _edad; set => _edad = value; }
        public string Email { get => _email; set => _email = value; }


        public Persona(string email, string nombre, string apellido, int edad)
        {
            _email = email;
            _nombre = nombre;
            _apellido = apellido;
            _edad = edad;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}, {Edad} ({Email})";
        }
    }
}
