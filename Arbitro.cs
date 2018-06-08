using System;

namespace Futbol
{
    //Clase 3
    public class Arbitro : Persona
    {

     private  string posicion = "Central";
        //CONSTRUCTOR
     public Arbitro(string nombre)
        {
            this.nombre = nombre;
        }

        public string CumplirReglas()
        {
            return "El futbolista está jugando";
            //TODO = Por hacer
        }
    }
}
      



    

