using Agencia_de_viagens.Enum;
using System;

namespace Agencia_de_viagens.Models{
    public class Cliente{
        public int Id { get; set; }

        public string Nome { get; set; }

       public string Cpf { get; set; }

       public DateTime DataNascimento { get; set; }

       public Situacao Situacao { get; set; } 
    }
}
