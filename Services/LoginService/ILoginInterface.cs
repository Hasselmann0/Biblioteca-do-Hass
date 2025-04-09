using BibliotecaDoHass.Dto;
using BibliotecaDoHass.Models;

namespace BibliotecaDoHass.Services.LoginService
{
    public interface ILoginInterface
    {
        Task<ResponseModel<UsuarioModel>> RegistrarUsuario(UsuarioRegisterDto usuarioRegisterDto)
        {
            throw new NotImplementedException();
        }

    }
}
