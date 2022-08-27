using System;

namespace Mensage {
    internal class Program {
        static void Main(string[] args) {
            ClassMensage ms1;
            ms1 = new ClassMensage();

            ms1.Name = "Christian";
            ms1.Age = 20;

            Console.WriteLine(ms1.Name);
            Console.WriteLine(ms1.Age);

        }
    }
}
