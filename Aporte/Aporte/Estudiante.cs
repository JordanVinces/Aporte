using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aporte
{
    public class Estudiante : Concurso
    {
        public string Nombre
        {
            get => default;
            set
            {
                Console.WriteLine("Por favor inngrese su nombre: " + Nombre);
                Console.ReadLine();
            }
        }

        public string Apellido
        {
            get => default;
            set
            {
                Console.WriteLine("Por favor ingrese su apellido: " + Apellido);
                Console.ReadLine();
            }
        }

        public int Edad
        {
            get => default;
            set
            {
                Console.WriteLine("Por favor ngrese su Edad: " + Edad);
                Console.ReadLine();
            }
        }

        public string Facultad
        {
            get => default;
            set
            {
                Console.WriteLine("Diganos el nombre de la facultad que desea ingresar: " + Facultad);
                Console.ReadLine();
            }
        }

        public void SeleccionarLab()
        {
            throw new System.NotImplementedException();
        }

        public void SeleccionarPC()
        {
            throw new System.NotImplementedException();
        }
    }
}