using BibliotecaDoHass.Dto;
using BibliotecaDoHass.Models;

namespace BibliotecaDoHass.Services.LoginService
{
    public interface ILoginInterface
    {
        Task<ResponseModel<UsuarioModel>> RegistrarUsuario(UsuarioRegisterDto usuarioRegisterDto);

        Task<ResponseModel<UsuarioModel>> Login (UsuarioLoginDto loginDto);

    }
}
