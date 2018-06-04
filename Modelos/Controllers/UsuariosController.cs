using Controllers.Base;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class UsuariosController : IBaseController<Usuario>
    {
        List<Usuario> Usuarios = new List<Usuario>;

        public void Adicionar(Usuario entity)
        {
            throw new NotImplementedException();
        }

        // buscarPorID
        public Usuario BuscarPorID(int id)
        {
            foreach (Usuario a in Usuarios)
            {
                if (a.UsuarioID == id)
                {
                    return a;
                }
            }
            return null;
        }

        public void Editar(Usuario entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
