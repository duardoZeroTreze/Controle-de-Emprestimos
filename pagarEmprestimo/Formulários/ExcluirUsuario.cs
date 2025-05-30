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
    public partial class ExcluirUsuario : Form
    {
        Sistema s;
        public ExcluirUsuario(Sistema sistemaRecebido)
        {
            InitializeComponent();
            s = sistemaRecebido;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            string senha = txt_senha.Text;
            Usuario user = s.usuarios.FirstOrDefault(u => u.nome.ToLower() == nome.ToLower());
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(senha))
            {
                if (user != null)
                {
                    if (senha == user.senha)
                    {
                        DialogResult result = MessageBox.Show(
                            "Tem certeza que deseja alterar a senha?",
                            "Confirmação",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (result == DialogResult.Yes)
                        {
                            s.ExcluirUsuario(user);
                            MessageBox.Show("Usuário excluído com sucesso");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Exclusão cancelada.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não existente no sistema!");
                    return;
                }
            } else
            {
                MessageBox.Show("Preencha os campos devidamente.");
                return;
            }
        }
    }
}
