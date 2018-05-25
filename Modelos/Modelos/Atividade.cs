using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class Atividade
    {
        public int AtividadeID { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int CategoriaID { get; set; }

        public virtual Categoria _Categoria { get; set; } // virtual é uma variável que vai receber

        public int UsuarioID { get; set; }

        public virtual Usuario _Usuario { get; set; }
    }
}
