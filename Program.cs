
using Futbol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFutbol
{
    class Program
    {
        static void Main(string[] args)
        {


            //INSTANCIA
            var jugador = new Futbolista();
            Console.WriteLine("Nombre de jugador:");
            Console.WriteLine(jugador.nombre = "Leonel");

            var juez = new Persona();
            Console.WriteLine("Nombre de Arbitro:");
            Console.WriteLine(juez.nombre = "Omar");
            Console.ReadKey();

           
            
        }
    }
}