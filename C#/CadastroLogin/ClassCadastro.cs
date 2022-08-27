using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroLogin {
    public abstract class ClassCadastro {
        protected String NameUser = "";
        protected int UserPassword = 0;

        public void SetRegister(string Name, int Password) {
            this.NameUser = Name.ToLower().Trim();
            this.UserPassword = Password;
            Console.WriteLine("Cadastro com sucesso");
        }

        public void deleteRegister() {
            this.NameUser = "";
            this.UserPassword = 0;
            Console.WriteLine("Cadastro esxluido com sucesso");
        }
    }
}
