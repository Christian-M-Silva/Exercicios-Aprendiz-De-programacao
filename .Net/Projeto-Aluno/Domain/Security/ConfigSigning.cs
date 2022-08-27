using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;


namespace Domain.Security {
    public class ConfigSigning {
        public SecurityKey Key { get; set; }

        public SigningCredentials SigningCredentials { get; set; }

        public ConfigSigning() {
            //Usar o using assim é uma forma de intanciarmos uma variavel
            //usarmos em um contexto ou proposito e assim que acabar descartar ela 
            using (var provider = new RSACryptoServiceProvider(2048)) {
                Key = new RsaSecurityKey(provider.ExportParameters(true)); //Gera uma key 
            }

            SigningCredentials = new SigningCredentials(Key, SecurityAlgorithms.RsaSha256Signature); 
            //Combase na key, ele gera uma assinatura ou criptografia

            //Creio que essa parte vou t=entender melhor mais para frente
        }
    }   
}
