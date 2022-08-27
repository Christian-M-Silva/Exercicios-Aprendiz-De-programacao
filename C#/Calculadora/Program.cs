using System;

namespace Calculadora {
    public class Program {
        static void Main(string[] args) {
            Console.WriteLine("Escreva o primeiro Número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva o segundo Número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva um sinal de cálculo válido (+ - * /): ");
            String s = Console.ReadLine();

            ClassCalc calc = new ClassCalc(n1, n2, s);
        }
    }
}
