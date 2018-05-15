using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();

            Console.WriteLine("Carro criado, velocidade inicial:  " + c.velocidade);
            c.Acelecar();
            c.Acelecar();

            Console.WriteLine("Carro, velocidade atual: " + c.velocidade);

            Console.ReadKey();


        }
    }
}
