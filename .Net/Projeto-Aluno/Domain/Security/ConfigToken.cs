

namespace Domain.Security {
    public class ConfigToken {
        //Aqui configuro o Token
        public string Audience { get; set; } //O publico para quem é direcionado esse token

        public string Issuer { get; set; } // O emissor do token

        public int Seconds { get; set; } //Segundos de validade do Token
    }
}
