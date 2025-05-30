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

        public string email {  get; set; }

        public Usuario(string nome, string senha, string email)
        {
            this.nome = nome;
            this.senha = senha;
            this.email = email;
        }
    }
}
