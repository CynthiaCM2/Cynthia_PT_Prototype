using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    //Se crea la clase con la función "ICloneable" que hará que se cree un método llamado Clone  
    public class Animal : ICloneable
    {
        //Se crean los atributos de la función de la clase//
        public int Patas { get; set; } 
        public string Nombre { get; set; }

        public Detalles Rasgos { get; set; }

        //Método que hará que se clonen los objetos//
        public object Clone()
        {
            Animal clonado = this.MemberwiseClone() as Animal;
            Detalles detalles = new Detalles();
            detalles.Color= this.Rasgos.Color;
            detalles.Raza = this.Rasgos.Raza;
            clonado.Rasgos = detalles;
            return clonado;
        }
               
    }

    public class Detalles
    {
        public string Color { get; set; }
        public string Raza { get; set; }
    }
}
