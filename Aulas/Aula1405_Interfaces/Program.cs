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

            AcelerarBastante(c);
            Console.WriteLine("Carro, velocidade atual: " + c.velocidade);


            Onibus d = new Onibus();

            Console.WriteLine("Onibus criado, velocidade inicial: " + d.velocidade);
            d.Acelecar();
            d.Acelecar();

            AcelerarBastante(d);
            Console.WriteLine("Onibus, velocidade atual: " + d.velocidade);

            Console.ReadKey();

        }

        static void AcelerarBastante(IMeioTransporte meioTransporte)
        {
            for (int i = 0; i < 10; i++)
            {
                meioTransporte.Acelecar();
            }
        }

    }
}
