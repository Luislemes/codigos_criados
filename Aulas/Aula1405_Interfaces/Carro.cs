using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces
{
    class Carro : IMeioTransporte
    {
        public int velocidade { get; set; }

        //chave para a classe Marca
        public int MarcaID { get; set; }

        // instancia para o objeto relacionado
        public virtual Marca _Marca {get; set;}

        public void Acelecar()
        {
            velocidade += 10;
        }

        public void Desacelerar()
        {
            velocidade -= 6;
        }
    }
}
