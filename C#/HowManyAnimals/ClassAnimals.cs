using System;
using System.Collections.Generic;
using System.Text;

namespace HowManyAnimals {
    public class ClassAnimals {
        private int dog = 0;
        private int cat = 0;
        private int fish = 0;

        private String name;

        public String Name {
            set { name = value; }
        }

        private String type;

        public String Type {
            set { 
                type = value.ToLower();
                if (type == "cachorro") {
                    dog = ++dog;
                }
                else if (type == "gato") {
                    cat = ++cat;
                }else {
                    fish = ++fish;
                }
            }
        }

        public void ShowResult() {
            Console.WriteLine("----------------------");
            Console.WriteLine("Resultado:");
            Console.WriteLine($"Cachorro: {dog}");
            Console.WriteLine($"Gato: {cat}");
            Console.WriteLine($"Peixe: {fish}");

        }


    }
}
