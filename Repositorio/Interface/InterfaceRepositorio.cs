using Duarte_api.Models;

namespace Duarte_api.NovaPasta4.NovaPasta
{
    public interface InterfaceRepositorio
    {
        Task<List<UsuarioModel>> BuscarUsuario();
        Task<UsuarioModel>BuscarPorId(int id);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<bool> Apagar(int id);
    }
}
