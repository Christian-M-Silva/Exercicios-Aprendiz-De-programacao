using System;


namespace Mensage {
    public class ClassMensage {
        private String name;
        private int age;

        public String Name { get { return name; } set { name = value.ToUpper(); } }

        public int Age { get { return age; } set { age = value; } }
    }
}
