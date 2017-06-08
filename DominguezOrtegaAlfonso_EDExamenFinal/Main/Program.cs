using DominguezOrtegaAlfonso_EDExamenFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominguezOrtegaAlfonso_EDExamenFinal
{
    class Program
    {
        private static ClinicaVeterinaria ClinicaVeterinaria;
        static void Main(string[] args)
        {
            ClinicaVeterinaria = new ClinicaVeterinaria();
            int opcion;
            do
            {
                opcion = ClinicaVeterinaria.MenuInicio();
                realizarOpcion(opcion);
            }
            while (opcion < 5);
            if (opcion == 5)
            {
               Console.WriteLine("/** Has salido del programa **/");
               Console.WriteLine("/*** Hasta la proxima vez :) ***/");
            }
        }
    
        public static void realizarOpcion(int Opcion)
        {
            switch (Opcion)
            {
                case 1:
                    ClinicaVeterinaria.InsertarAnimal();
                    break;
                case 2:
                    ClinicaVeterinaria.ModificarComent();
                    break;
                case 3:
                    ClinicaVeterinaria.Pesar();
                    break;
                case 4:
                    ClinicaVeterinaria.MostrarFicha();
                    break;
                default:
                    break;
            }
        }

    }
}
