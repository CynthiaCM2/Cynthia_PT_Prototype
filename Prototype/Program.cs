using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crean los objetos de los atributos//
            Animal oAnimal = new Animal() { Nombre="Oveja Dolly", Patas=4};
            oAnimal.Rasgos = new Detalles();
            oAnimal.Rasgos.Color = "Blanca";
            oAnimal.Rasgos.Raza = "Oveja";

            Animal oAnimalClonado = oAnimal.Clone() as Animal;
            oAnimalClonado.Rasgos.Color = "Negro";
            oAnimalClonado.Nombre = "Oveja negra";

            Console.WriteLine("animal original: "+oAnimal.Rasgos.Color);
            Console.WriteLine("animal clonado: "+oAnimalClonado.Rasgos.Color);
            Console.WriteLine("animal original: "+oAnimal.Nombre);
            Console.WriteLine("animal clonado: "+oAnimalClonado.Nombre);

        }
    }
}
