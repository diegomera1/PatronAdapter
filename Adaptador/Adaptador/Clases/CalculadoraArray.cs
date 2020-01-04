using System;
using System.Collections.Generic;
using System.Text;
using Adaptador.Clases;
using Adaptador.Interfaz;

namespace Adaptador.Clases
{
    //Esta es la clase la cual deseamos adaptar, el cliente no la puede usar directamente pues la interfaz que usa es diferente

    class CalculadoraArray
    {
        public double suma(int[]  pOperandos)
        {
            int n = 0;
            int r = 0;

            for (n = 0; n < pOperandos.Length; n++)
                r += pOperandos[n];
            return r;
        }
    }
}
