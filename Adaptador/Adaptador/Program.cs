using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adaptador.Interfaz;
using Adaptador.Clases;

namespace Adaptador
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente
            int resultado = 0;

            //Usaremos la interfaz que el cliente conoce con una clase que conoce
            ITarget calcu = new Calcu();

            resultado = calcu.Sumar(4, 3);
            Console.WriteLine("El resultado es {0}", resultado);

            Console.WriteLine("//////////////");

            //Hacemos uso del adaptador
            calcu = new CAdaptador();

            //Usamos el adaptador para hacer la operación
            resultado = calcu.Sumar(5, 6);

            Console.WriteLine("El resultado es {0}", resultado);
        }
    }
}
