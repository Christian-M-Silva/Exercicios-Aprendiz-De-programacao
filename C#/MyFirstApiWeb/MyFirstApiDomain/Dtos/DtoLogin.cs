using System.ComponentModel.DataAnnotations;

namespace MyFirstApiDomain.Dtos {
    public class DtoLogin {
        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [StringLength(100, ErrorMessage = "O tamanho tem que ser no maximo de {1}")]
        [EmailAddress (ErrorMessage = "Formato de e-mail não valido")]

        public string Email { get; set; }
    }
}
