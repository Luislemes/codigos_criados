using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1105_POO
{
    class Aluno: Pessoa
    {
        //public Matricula()
        
        // Construtores

        public Aluno()
        {

        }

        public Aluno(string nome) : base (nome)
        {
            
        }

        public Aluno(string nome, string cpf) : base (nome, cpf)
        {
        }
            public override string ShowInfoPessoa()
        {
            return "Aluno: " + Nome + ", Cpf:  " + Cpf; //+ I, Matricula: " + Matricula;
        }
    
    }
}
