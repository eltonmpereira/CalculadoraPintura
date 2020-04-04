using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPintura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a largura da área?");
            double largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a profundidade da área?");
            double profundidade = double.Parse(Console.ReadLine());

            Console.WriteLine("A área das paredes é: ");
            const double Altura = 2.9;

            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.CalcularAreaParedes(largura, profundidade, Altura));

            Console.WriteLine("A área do teto é: ");            
            Console.WriteLine(calculadora.CalcularAreaTeto(largura, profundidade));

            Console.WriteLine("A litragem de tinta necessária é: ");
            Console.WriteLine((calculadora.CalcularLitragemTinta()));
            Console.ReadKey();



        }
    }
}
