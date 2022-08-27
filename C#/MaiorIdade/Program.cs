using System;

namespace MaiorIdade {
    internal class Program {
        static void Main(string[] args) {
            ClassPessoa pessoa1 = new ClassPessoa("Deivid", 18);
            ClassPessoa pessoa2 = new ClassPessoa("Christian", 34);
            ClassPessoa pessoa3 = new ClassPessoa("Thayná", 33);

            if (pessoa1.Age == pessoa2.Age || pessoa2.Age == pessoa3.Age || pessoa1.Age == pessoa3.Age) {
                Console.WriteLine("AVISO: Existem idades repetidas, então se as idades repetidas forem as maiores idades o sistema escolherá uma pessoa para ser a maior de idade");
                Console.WriteLine("");
            }

            if (pessoa1.Age == pessoa2.Age && pessoa1.Age == pessoa3.Age) {
                Console.WriteLine("Todo mundo tem a mesma idade");
            }else {
                if (pessoa1.Age > pessoa2.Age && pessoa1.Age > pessoa3.Age) {
                    pessoa1.ShowData();
                }
                else if (pessoa2.Age > pessoa1.Age && pessoa2.Age > pessoa3.Age) {
                    pessoa2.ShowData();
                }
                else {
                    pessoa3.ShowData();
                }
            }

           

        }
    }
}
