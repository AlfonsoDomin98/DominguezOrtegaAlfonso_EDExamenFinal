using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominguezOrtegaAlfonso_EDExamenFinal.Models
{
    class ClinicaVeterinaria
    {
        private Perro perro;
        private Pajaro pajaro;
        private Gato gato;
        private Reptil reptil;
        private List<Animal> ListaAnimales;

        public ClinicaVeterinaria()
        {
            this.ListaAnimales = new List<Animal>();
        }

        public void Pesar()
        {
            int opcion = MenuPeso();
            if (opcion <= 0 || opcion > 4)
            {
                throw new Exception("[ERROR] No ha introducido un valor correcto");
                
            }
            string aux;
            double peso;
            string nombre;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Introduzca el nombre del perro: ");
                    nombre = Console.ReadLine();
                    if (perro.getNombre() != nombre)
                    {
                        Console.WriteLine("No hay ningun perro introducido");
                    }
                    else
                    {
                        Console.WriteLine("Introduzca el peso del perro: ");
                        aux = Console.ReadLine();
                        Double.TryParse(aux, out peso);
                        perro.Pesar(peso);
                    }
                    break;
                case 2:
                    Console.WriteLine("Introduzca el nombre del gato: ");
                    nombre = Console.ReadLine();
                    if (gato.getNombre() != nombre)
                    {
                        Console.WriteLine("No hay ningun gato introducido");
                    }
                    else
                    {
                        Console.WriteLine("Introduzca el peso del gato: ");
                        aux = Console.ReadLine();
                        Double.TryParse(aux, out peso);
                        gato.Pesar(peso);
                    }
                    break;
                case 3:
                    Console.WriteLine("Introduzca el nombre del pajaro: ");
                    nombre = Console.ReadLine();
                    if (pajaro.getNombre() != nombre)
                    {
                        Console.WriteLine("No hay ningun pajaro introducido");
                    }
                    else
                    {
                        Console.WriteLine("Introduzca el peso del pajaro: ");
                        aux = Console.ReadLine();
                        Double.TryParse(aux, out peso);
                        pajaro.Pesar(peso);
                    }
                    break;
                case 4:
                    Console.WriteLine("Introduzca el nombre del reptil: ");
                    nombre = Console.ReadLine();
                    if (reptil.getNombre() != nombre)
                    {
                        Console.WriteLine("No hay ningun reptil introducido");
                    }
                    else
                    {
                        Console.WriteLine("Introduzca el peso del reptil: ");
                        aux = Console.ReadLine();
                        Double.TryParse(aux, out peso);
                        reptil.Pesar(peso);
                    }
                    break;

                default:
                    break;
            }

        }
        public void ModificarComent()
        {
            int opcion = ModificarComentario();
            if (opcion <= 0 || opcion > 4)
            {
                throw new Exception("[ERROR]: No ha introducido un valor correcto");
            }
            string aux;
            string nombre = "";

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Introduzca el nombre del perro: ");
                    nombre = Console.ReadLine();
                    if (perro.getNombre() != nombre)
                    { 

                        Console.WriteLine("No hay ningun perro introducido");
                    }
                    else
                    {
                        Console.WriteLine("Introduzca el comentario del perro: ");
                        aux = Console.ReadLine();
                        perro.setComentario(aux);
                    }
                    break;
                case 2:
                    Console.WriteLine("Introduzca el nombre del gato: ");
                    nombre = Console.ReadLine();
                    if (gato.getNombre() != nombre)
                    {
                        Console.WriteLine("No hay ningun gato introducido");
                    }
                    else
                    {
                        Console.WriteLine("Introduzca el comentario del gato: ");
                        aux = Console.ReadLine();
                        gato.setComentario(aux);
                    }
                    break;
                case 3:
                    Console.WriteLine("Introduzca el nombre del pajaro: ");
                    nombre = Console.ReadLine();
                    if (pajaro.getNombre() != nombre)
                    {
                        Console.WriteLine("No hay ningun pajaro introducido");
                    }
                    else
                    {
                        Console.WriteLine("Introduzca el comentario del pajaro: ");
                        aux = Console.ReadLine();
                        pajaro.setComentario(aux);
                    }
                        break;
                case 4:
                    Console.WriteLine("Introduzca el nombre del Reptil: ");
                    nombre = Console.ReadLine();
                    if (reptil.getNombre() != nombre)
                    {
                        Console.WriteLine("No hay ningun reptil introducido");
                    }
                    else
                    {
                        Console.WriteLine("Introduzca el comentario del reptil: ");
                        aux = Console.ReadLine();
                        reptil.setComentario(aux);
                    }
                    break;

                default:
                    break;
            }

        }

        public void InsertarAnimal()
        {
            int opcion = MostrarMenuInsertar();
            if(opcion <= 0 || opcion > 4)
            {
                throw new Exception("[ERROR]: No ha introducido un valor correcto");
            }
            string Raza, Microchip, nombre, fecha, comentario, aux;
            double peso;
            bool cantor = true, vene = true;
            int booleano;

            
            Console.WriteLine("Introduzca la Raza o Especie del animal:");
            Raza = Console.ReadLine();
            if(Raza == "")
            {
                throw new Exception("[ERROR]: No se puede dejar ningun campo vacio");
            }
            Console.WriteLine("Introduzca el Microchip:");
            Microchip = Console.ReadLine();
            if (Microchip == "")
            {
                throw new Exception("[ERROR]: No se puede dejar ningun campo vacio");
            }
            Console.WriteLine("Introduzca el Nombre:");
            nombre = Console.ReadLine();
            if (nombre == "")
            {
                throw new Exception("[ERROR]: No se puede dejar ningun campo vacio");
            }
            Console.WriteLine("Introduzca su fecha de nacimiento: dd/mm/yyyy");
            fecha = Console.ReadLine();
            if (fecha == "")
            {
                throw new Exception("[ERROR]: No se puede dejar ningun campo vacio");
            }
            Console.WriteLine("Introduzca un comentario:");
            comentario = Console.ReadLine();
            if (comentario == "")
            {
                throw new Exception("[ERROR]: No se puede dejar ningun campo vacio");
            }
            Console.WriteLine("Introduzca su Peso:");
            aux = Console.ReadLine();
            Double.TryParse(aux, out peso);
            if (peso <= 0)
            {
                throw new Exception("[ERROR]: No ha introducido un peso correcto");
            }

            if (opcion == 3)
            {
                Console.WriteLine("Introduzca si es cantor o no: 1- SI 2-NO");
                aux = Console.ReadLine();
                Int32.TryParse(fecha, out booleano);
                if (booleano == 1)
                {
                    cantor = true;
                }
                else
                {
                    cantor = false;
                }
            }

            if (opcion == 4)
            {
                Console.WriteLine("Introduzca si es Venenoso o no: 1- SI 2-NO");
                aux = Console.ReadLine();
                Int32.TryParse(fecha, out booleano);
                if (booleano == 1)
                {
                    vene = true;
                }
                else
                {
                    vene = false;
                }
            }
            switch (opcion)
            {
                case 1:
                    perro = new Perro(Raza, Microchip, nombre, fecha, peso, comentario);
                    ListaAnimales.Add(perro);
                    break;
                case 2:
                    gato = new Gato(Raza, Microchip, nombre, fecha, peso, comentario);
                    ListaAnimales.Add(gato);
                    break;
                case 3:
                    pajaro = new Pajaro(Raza, cantor, nombre, fecha, peso, comentario);
                    ListaAnimales.Add(pajaro);
                    break;
                case 4:
                    reptil = new Reptil(Raza, vene, nombre, fecha, peso, comentario);
                    ListaAnimales.Add(reptil);
                    break;

               
            }
        }
        public  void MostrarFicha()
        {
            int opcion = MenuMostrarFicha();
            if (opcion <= 0 || opcion > 4)
            {
                throw new Exception("[ERROR]: No ha introducido un valor correcto");
            }
            string nombre = "";
            switch (opcion) { 
             case 1:
                    Console.WriteLine("Introduzca el nombre del perro: ");
                    nombre = Console.ReadLine();
                    if (perro.getNombre() != nombre)
                    {
                        Console.WriteLine("No hay ningun perro introducido");
                    }

                    else
                    {
                        Console.WriteLine(perro.ToString());
                    }
            
            break;
                case 2:
                    Console.WriteLine("Introduzca el nombre del gato: ");
                    nombre = Console.ReadLine();
                    if (gato.getNombre() != nombre)
                    {
                        Console.WriteLine("No hay ningun gato introducido");
                    }
                    else
                    {
                        gato.ToString();
                        
                    }
            break;
                case 3:
                    Console.WriteLine("Introduzca el nombre del pajaro: ");
                    nombre = Console.ReadLine();
                    if (pajaro.getNombre() != nombre)
                    {
                        Console.WriteLine("No hay ningun pajaro introducido");
                    }
                    else
                    {
                        pajaro.ToString();
                    }
                   break;
                case 4:
                    Console.WriteLine("Introduzca el nombre del reptil: ");
                    nombre = Console.ReadLine();
                    if (reptil.getNombre() != nombre)
                    {
                        Console.WriteLine("No hay ningun reptil introducido");
                    }
                    else
                    {
                        reptil.ToString();
                    }
            break;

            default:
                    break;
        }
    }

        private static int MenuPeso()
        {
            int opcion;
            string aux;
            Console.WriteLine();
            Console.WriteLine("/** SUBMENU - PESAR **/");
            Console.WriteLine("Por favor, indique a que tipo de animal desea pesar");
            Console.WriteLine("1. Perro");
            Console.WriteLine("2. Gato");
            Console.WriteLine("3. Pajaro");
            Console.WriteLine("4. Reptil");

            aux = Console.ReadLine();
            Int32.TryParse(aux, out opcion);

            return opcion;
        }

        private static int MenuMostrarFicha()
        {
            int opcion;
            string aux;
            Console.WriteLine();
            Console.WriteLine("/** SUBMENU - MOSTRAR FICHA **/");
            Console.WriteLine("Por favor, indique a que tipo de animal desea ver su ficha");
            Console.WriteLine("1. Perro");
            Console.WriteLine("2. Gato");
            Console.WriteLine("3. Pajaro");
            Console.WriteLine("4. Reptil");

            aux = Console.ReadLine();
            Int32.TryParse(aux, out opcion);

            return opcion;
        }


        public static int MenuInicio()
        {
            int opcion;
            string aux;
            Console.WriteLine("/** MENU PRINCIPAL **/");
            Console.WriteLine("Por favor, selecciona algunas de las siguientes opciones");
            Console.WriteLine("1. Insertar Animal");
            Console.WriteLine("2. Modificar Comentario");
            Console.WriteLine("3. Pesar Animal");
            Console.WriteLine("4. Mostrar Ficha Animal");
            Console.WriteLine("5. Salir de la tienda");
            aux = Console.ReadLine();
            Int32.TryParse(aux, out opcion);

            return opcion;
        }


        private static int MostrarMenuInsertar()
        {
            int opcion;
            string aux;
            Console.WriteLine("/** SUBMENU - AÑADIR ANIMAL **/");
            Console.WriteLine("Por favor, indique que tipo de animal desea añadir");
            Console.WriteLine("1. Perro");
            Console.WriteLine("2. Gato");
            Console.WriteLine("3. Pajaro");
            Console.WriteLine("4. Reptil");

            aux = Console.ReadLine();
            Int32.TryParse(aux, out opcion);

            return opcion;

        }

        private static int ModificarComentario()
        {
            int opcion;
            string aux;
            Console.WriteLine("/** SUBMENU - MODIFICAR COMENTARIO **/");
            Console.WriteLine("Por favor, indique que tipo de animal desea modificar el comentario");
            Console.WriteLine("1. Perro");
            Console.WriteLine("2. Gato");
            Console.WriteLine("3. Pajaro");
            Console.WriteLine("4. Reptil");

            aux = Console.ReadLine();
            Int32.TryParse(aux, out opcion);

            return opcion;


        }
    }
}
