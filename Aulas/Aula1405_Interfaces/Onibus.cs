using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces
{
    class Onibus: IMeioTransporte
    {
        public int velocidade { get; set; }

        public void Acelecar()
        {
            velocidade += 5;
        }

        public void Desacelerar()
        {
            velocidade -= 3;
        }
    }
}