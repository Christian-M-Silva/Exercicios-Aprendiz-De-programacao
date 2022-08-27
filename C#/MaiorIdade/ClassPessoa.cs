using System;
using System.Collections.Generic;
using System.Text;

namespace MaiorIdade {
    public class ClassPessoa {
        public ClassPessoa() {
            Name = "João";
            Age = 14;

        }

        public ClassPessoa(string name, int age) {
            Name = name;
            Age = age;
        }

        public int Age { get; set; }
        public String Name { get; set; }

        public void ShowData() {
            Console.WriteLine($"A pessoa que tem a maior idade é:");
            Console.WriteLine($"Nome: {this.Name}");
            Console.WriteLine($"Idade: {this.Age}");
        }

        
    }
}
