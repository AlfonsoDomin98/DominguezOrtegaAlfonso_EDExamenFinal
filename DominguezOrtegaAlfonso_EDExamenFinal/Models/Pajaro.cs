using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominguezOrtegaAlfonso_EDExamenFinal.Models
{
    class Pajaro : Animal
    {
        private string especie;
        private bool cantor;

        public Pajaro(string especie, bool cantor, string nombre, string fecha, double peso, string comentario) : base(nombre, fecha, peso, comentario)
        {
            this.especie = especie;
            this.cantor = cantor;
        }

        public override string ToString()
        {
            return "Ficha de Perro:" +
                   " Nombre: " + getNombre() +
                   " Especie: " + especie +
                   " Fecha Nacimiento: " + getFecha() +
                   " Peso: " + getPeso() +
                   " Cantor: " + cantor +
                   " Comentario: " + getComentario();
        }
    }
}
