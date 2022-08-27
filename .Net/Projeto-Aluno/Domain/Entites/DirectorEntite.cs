using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entites {
    public class DirectorEntite : BaseEntites {

        [Required(ErrorMessage = "Email é um campo obrigatório")]
        [EmailAddress(ErrorMessage = "O valor digitado não corresponde ao formato de um email. Ex.: teste@email.com")]
        [StringLength(100, ErrorMessage = "O valor maximos é de {1} caracteres.")]
        //TODO: Se der certo o meu jeito voltar depois tentando com todas as aulas desse modulo tentando com o DTO
        public String Email { get; set; }

        public String Name { get; set; }
    }
}
