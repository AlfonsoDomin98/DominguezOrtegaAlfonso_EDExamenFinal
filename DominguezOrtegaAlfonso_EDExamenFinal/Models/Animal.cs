using DominguezOrtegaAlfonso_EDExamenFinal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominguezOrtegaAlfonso_EDExamenFinal.Models
{
    abstract class Animal : IPesable
    {
        private string Nombre;
        private string FechNac;
        private double Peso;
        private string Comentario;

        public Animal(string nombre, string fecha, double peso, string comentario)
        {
            this.Nombre = nombre;
            this.FechNac = fecha;
            this.Peso = peso;
            this.Comentario = comentario;
        }

        // GETS AND SETTERS
        public string getNombre()
        {
            return Nombre;
        }

        public string getFecha()
        {
            return FechNac;
        }

        public string getComentario()
        {
            return Comentario;
        }

        public void setComentario(string Coment)
        {
            if(Coment == "")
            {
                throw new Exception("[ERROR]: Introduzca al menos un comentario");
            }
        }

        public double getPeso()
        {
            return Peso;
        }

        public void Pesar(double peso)
        {
            if(peso <= 0)
            {
                throw new Exception("[ERROR]: No ha introducido un peso correcto");
            }
            else
            {
                Peso = peso;
            }
        }
    }
}
