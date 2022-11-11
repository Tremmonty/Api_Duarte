using Duarte_api.Models;
using Duarte_api.NovaPasta3;
using Duarte_api.NovaPasta4.NovaPasta;

namespace Duarte_api.NovaPasta4
{
    public class UsuarioRepositorio : InterfaceRepositorio
    { 
        private readonly DuarteContext _dbcontext;

        public UsuarioRepositorio(DuarteContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public List<UsuarioModel> BuscarUsuario()
        {
            return await _dbcontext.Usuarios.Tolist();
        }

        public UsuarioModel BuscarPorId(int id)
        {
            return await _dbcontext.Usuarios.FirstOrDefault(x =>x.id == id);
       
        }

       public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            _dbcontext.Usuario.Add(usuario);
            _dbcontext SaveChanges();

            return usuario;
        }

       public UsuarioModel Atualizar(UsuarioModel usuario, int id)
        {
            throw new NotImplementedException();
        }

        bool Apagar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
