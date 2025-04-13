using System.ComponentModel.DataAnnotations;

namespace BibliotecaDoHass.Dto
{
    public class UsuarioLoginDto
    {
        [Required(ErrorMessage = "Digite o Email!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite a senha!")]
        public string Senha { get; set; }

    }
}
