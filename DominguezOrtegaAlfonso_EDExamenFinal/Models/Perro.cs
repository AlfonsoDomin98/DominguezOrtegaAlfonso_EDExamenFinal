using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominguezOrtegaAlfonso_EDExamenFinal.Models
{
    class Perro : Animal
    {
        private string Raza;
        private string Microchip;

        public Perro(string raza, string Microchip, string nombre, string fecha, double peso, string comentario) : base(nombre, fecha, peso, comentario)
        {
            this.Raza = raza;
            this.Microchip = Microchip;
            
        }

        public override string ToString()
        {
            return "Ficha de Perro: "+ 
                   " Nombre: "+getNombre()+
                   " Raza: "+ Raza+
                   " Fecha Nacimiento: "+getFecha()+
                   " Peso: "+ getPeso()+
                   " Microchip: "+Microchip+
                   " Comentario: "+ getComentario();
        }
    }
}
