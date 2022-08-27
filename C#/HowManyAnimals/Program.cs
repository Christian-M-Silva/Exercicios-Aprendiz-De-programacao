using System;

namespace HowManyAnimals {
    public class Program {
        static void Main(string[] args) {
            ClassAnimals animals = new ClassAnimals();

            for (int i = 0; i < 5; i++) { 
            Console.Write("Nome do animal:");
            animals.Name = Console.ReadLine();

            Console.Write("Tip do animal, os tipos vaidos são (Cachorro, Gato ou Peixe):");
            animals.Type = Console.ReadLine();
                Console.WriteLine("");
            }


            animals.ShowResult();

        }
    }
}
