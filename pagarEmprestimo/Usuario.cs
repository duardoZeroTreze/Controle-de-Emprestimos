using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Emprestimo
{
    public class Usuario
    {
        public string nome { get; set; }
        public string senha { get; set; }

        public Usuario(string nome, string senha)
        {
            this.nome = nome;
            this.senha = senha;
        }
    }
}
