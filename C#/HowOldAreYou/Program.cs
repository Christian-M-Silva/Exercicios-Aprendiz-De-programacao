using System;

namespace HowOldAreYou {
    public class Program {
        static void Main(string[] args) {

            ClassDataPersonal Pessoa1 = new ClassDataPersonal();

            Console.Write("Digite seu nome: ");
            Pessoa1.Name = Console.ReadLine();

            Console.Write("Digite o seu ano de nascimento: ");
            Pessoa1.BirthDate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------------------------------------");

            Console.WriteLine($"NOME: {Pessoa1.Name}");
            Console.WriteLine($"DATA DE NASCIMENTO: {Pessoa1.BirthDate}");
            Pessoa1.CurrentAge();
        }
    }
}
