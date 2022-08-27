using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora {
    public class ClassCalc {
        private int _numberOne;
        public int NumberOne {
            get { return _numberOne; }
            set { _numberOne = value; }
        }

        private int _numberTwo;
        public int NumberTwo {
            get { return _numberTwo; }
            set { _numberTwo = value; }
        }

        public ClassCalc(int nOne, int nTwo, String signal) {
            this.NumberOne = nOne;
            this.NumberTwo = nTwo;
            calculo(signal);
        }

        public void calculo(string sinal) {
            switch (sinal) {
               case "+":
                    Console.WriteLine(this.NumberOne + this.NumberTwo);
                    break;

                case "-":
                    Console.WriteLine(this.NumberOne - this.NumberTwo);
                    break;

                case "*":
                    Console.WriteLine(this.NumberOne * this.NumberTwo);
                    break;

                case "/":
                    Console.WriteLine(this.NumberOne + this.NumberTwo);
                    break;

                default:
                    Console.WriteLine($"O sinal {sinal} não é aceito");
                    break;
            }
        }
    }
}

