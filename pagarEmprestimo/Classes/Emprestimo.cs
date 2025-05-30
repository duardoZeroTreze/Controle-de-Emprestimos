using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Emprestimo
{
    public class Emprestimo
    {
        public double valor { get; set; }
        public Usuario devedor { get; set; }
        public Usuario credor { get; set; }
        public string data { get; set; }

        public Emprestimo(double valor, Usuario devedor, Usuario credor, string data)
        {
            this.valor = valor;
            this.devedor = devedor;
            this.credor = credor;
            this.data = data;
        }

        public override string ToString()
        {
            return $"Nome do Credor: {credor.nome} | Nome do devedor: {devedor.nome} | Valor : {valor} | Data: {data}";
        }
    }
}
