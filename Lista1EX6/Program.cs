using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num;
            Console.WriteLine("Digite um Número: ");
            num = float.Parse(Console.ReadLine());
            float result = num % 4;
            if (result == 0) { Console.WriteLine("Número Inválido"); }
            else { Console.WriteLine("O Número " + num + " é Válido"); }
            Console.ReadKey();  

        }
    }
}
