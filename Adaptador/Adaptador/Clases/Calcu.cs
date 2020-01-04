using System;
using System.Collections.Generic;
using System.Text;
using Adaptador.Interfaz;

namespace Adaptador.Clases
{
    class Calcu:ITarget
    {
        public int Sumar(int pA, int pB)
        {
            return pA + pB;
        }
    }
}
