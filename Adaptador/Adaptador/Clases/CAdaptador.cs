using System;
using System.Collections.Generic;
using System.Text;
using Adaptador.Clases;
using Adaptador.Interfaz;

namespace Adaptador.Clases
{
    //Esta clase usa la interfaz ITarget la cual es conocida por el cliente. El adaptador comunica al cliente con la clase adaptada

    class CAdaptador:ITarget
    {
        CalculadoraArray adaptado = new CalculadoraArray();
        //Haremos la adaptacion de una operación
        public int Sumar (int pA, int pB)
        {
            double r = 0;
            //Creamos el array que necesita el adaptado
            //Adaptamos los datos que se envían
            int[] operadores = { pA, pB };

            //realizamos la operación en el adaptado
            r = adaptado.suma(operadores);

            //Adaptamos el resultado
            return (int)r;
        }
    }
}
