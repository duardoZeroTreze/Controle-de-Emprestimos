using Sistema_de_Emprestimo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagarEmprestimo
{
    public partial class CadastrarUsuario : Form
    {
        Sistema s;
        public CadastrarUsuario(Sistema sistemaRecebido)
        {
            InitializeComponent();
            s = sistemaRecebido;
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            string senha = txt_senha.Text;
            bool existe = s.usuarios.Any(u => u.nome.ToLower() == nome.ToLower());

            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(senha))
            {
                if (existe)
                {
                    MessageBox.Show("Já existe usuário com este nome");
                    return;
                }
                else
                {
                    s.CadastrarUsuario(nome, senha);
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
            } else
            {
                MessageBox.Show("Preencha devidamente os campos.");
            }

        }
    }
}
