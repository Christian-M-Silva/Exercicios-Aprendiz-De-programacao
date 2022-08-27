using System;
using System.Collections.Generic;
using System.Text;

namespace HowOldAreYou {
    public class ClassDataPersonal {
        private String name;
        private int birthDate;

        public string Name { get { return this.name; } set { this.name = value.ToUpper(); } }

        public int BirthDate { get { return this.birthDate; } set { this.birthDate = value; } }

        public void CurrentAge() {
            Console.WriteLine($"SUA IDADE ATUAL É: {DateTime.Now.Year - this.birthDate}");
        }
    }
}
