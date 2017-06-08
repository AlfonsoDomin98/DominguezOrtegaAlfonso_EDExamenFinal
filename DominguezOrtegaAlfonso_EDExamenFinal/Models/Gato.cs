using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominguezOrtegaAlfonso_EDExamenFinal.Models
{
    class Gato : Animal
    {
        private string Raza;
        private string Microchp;

        public Gato(string Raza,  string micro,string nombre, string fecha, double peso, string comentario) : base(nombre, fecha, peso, comentario)
        {
            this.Raza = Raza;
            this.Microchp = micro;
        }


        public override string ToString()
        {
            return "Ficha de Perro:" +
                   " Nombre: " + getNombre() +
                   " Raza: " + Raza +
                   " Fecha Nacimiento: " + getFecha() +
                   " Peso: " + getPeso() +
                   " Microchip: " + Microchp +
                   " Comentario: " + getComentario();
        }
    }
}
