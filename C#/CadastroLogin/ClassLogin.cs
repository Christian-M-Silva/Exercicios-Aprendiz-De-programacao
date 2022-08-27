using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroLogin {
    public class ClassLogin : ClassCadastro {

        public void Login(string NameLogin, int PasswordLogin) {
            if (this.NameUser == "" || this.UserPassword == 0) {
                Console.WriteLine("Não tem nenhum usuário ou senha cadastrada, queira cadastrar com o SetRegister(Nome, Senha)");
            }else if (this.NameUser != NameLogin.ToLower().Trim() || this.UserPassword != PasswordLogin) {
                Console.WriteLine("Usuário ou senha incorretos, queira tentar novamente ou cadastrar com o SetRegister(Nome, Senha)");
            }else {
                Console.WriteLine("Você fez Login com sucesso!!!");
            }
        }
    }
}
