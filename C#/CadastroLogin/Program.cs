using System;

namespace CadastroLogin {
    internal class Program {
        static void Main(string[] args) {
            ClassLogin user1;
            user1 = new ClassLogin();

            user1.SetRegister("Christian", 13);
            user1.deleteRegister();
            user1.Login("Christian", 13);
        }
    }
}
