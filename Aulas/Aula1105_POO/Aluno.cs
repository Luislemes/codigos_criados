﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1105_POO
{
    class Aluno
    {
        // Atributos
        private string nome;

        //Propriedades
        public string Nome
        {
            get => nome; // get { return nome;}
            set => nome = value; //set {nome = value;}
        }

        public string Cpf { get; set; }


    }
}
