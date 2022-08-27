using System;


namespace Domain.Entites {
    public class StudentEntite : BaseEntites {
        public String Name { get; set; }

        public int Age { get; set; }

        public int Serie { get; set; }

        public String Responsible { get; set; }

        public String ResponsibleAlternative { get; set; }

        public long PhoneNumber { get; set; }

        public long? PhoneNumberAlternative { get; set; }
    }
}
