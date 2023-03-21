using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41a1_AlumnosConHerencia
{
    class Cliente
    {

        // Campos
        int numDni;
        char letraDni;
        string nombre, apellidos;
        Fecha fechaNac;

        //Constructor
        public Cliente(int numDni, char letraDni, string nombre, string apellidos, Fecha fechaNac)
        {
            this.NumDni = numDni;
            this.LetraDni = letraDni;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.FechaNac = fechaNac;
        }

        //Propiedades getter & setter
        public int NumDni { get => numDni; set => numDni = value; }
        public char LetraDni { get => letraDni; set => letraDni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        internal Fecha FechaNac { get => fechaNac; set => fechaNac = value; }

        //Propiedades especiales
        public int Edad
        {
            get
            {
                return 0;
            }
        }
    }
}
