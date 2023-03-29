using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoValorDiferenca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, dif;
            Console.WriteLine("O programa consiste em multiplicar os valores A * B e C * D e subtrair o primeiro resultado pelo segundo");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Digite valor de A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D: ");
            D = int.Parse(Console.ReadLine());

            dif = A * B - C * D;

            Console.WriteLine(" A diferença entre os valores  é: {0} ", dif);
        }
    }
}
