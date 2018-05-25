using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class UsuariosController
    {
        List<Usuario> Usuarios = new List<Usuario>;

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



    }
}
