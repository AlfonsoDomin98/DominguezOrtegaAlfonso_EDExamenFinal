using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominguezOrtegaAlfonso_EDExamenFinal.Models
{
    class Reptil : Animal
    {
        private string especie;
        private bool Venenoso;

        public Reptil(string especie, bool Vene, string nombre, string fecha, double peso, string comentario) : base(nombre, fecha, peso, comentario)
        {
            this.especie = especie;
            this.Venenoso = Vene;
        }

        public override string ToString()
        {
            return "Ficha de Perro:" +
                   " Nombre: " + getNombre() +
                   " Especie: " + especie +
                   " Fecha Nacimiento: " + getFecha() +
                   " Peso: " + getPeso() +
                   " Venenoso: " + Venenoso +
                   " Comentario: " + getComentario();
        }
    }
}
