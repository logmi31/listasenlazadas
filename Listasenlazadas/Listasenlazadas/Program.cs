using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Listasenlazadas
{
    class Program
    {
        static void Main(string[] args)
        {

            Lista listaNueva = new Lista();

            listaNueva.InsertarF(40);
            listaNueva.InsertarF(20);
            listaNueva.InsertarF(10);
            listaNueva.InsertarF(5);

            listaNueva.mostrar();

            Console.ReadKey();


        }
    }
}
