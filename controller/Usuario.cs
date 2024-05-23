using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadoEstudo.controller {
    class Usuario {
        public string nome { get; set; }
        public int nivel { get; set; } = 0;
        public string senha { get; private set; }

        public Usuario() { }
        public Usuario(string nome, int nivel, string senha) {
            this.nome = nome;
            this.nivel = nivel;
            this.senha = senha;
        }
        public Usuario(string nome, string senha) {
            this.nome = nome;
            this.senha = senha;
        }

    }
}
