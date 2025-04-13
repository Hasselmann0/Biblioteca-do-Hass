using BibliotecaDoHass.Models;

namespace BibliotecaDoHass.Services.SessaoService
{
    public interface ISessaoInterface
    {
        void CriarSessao(UsuarioModel usuarioModel);
        void RemoveSessao ();
        UsuarioModel BuscarSessao();

    }
}
