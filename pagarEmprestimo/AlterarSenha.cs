using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Emprestimo
{
    public partial class AlterarSenha : Form
    {
        Sistema s;

        public AlterarSenha(Sistema sistemaRecebido)
        {
            InitializeComponent();
            s = sistemaRecebido;
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            string senhaAntiga = txt_senhaAntiga.Text;
            string senhaNova = txt_senhaNova.Text;

            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(senhaAntiga) && !string.IsNullOrEmpty(senhaNova))
            {
                DialogResult result = MessageBox.Show(
                    "Tem certeza que deseja alterar a senha?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                if (result == DialogResult.Yes)
                {
                    if (s.alterarSenha(nome, senhaNova, senhaAntiga))
                    {
                        MessageBox.Show($"Senha antiga: {senhaAntiga} ; Senha Nova: {senhaNova}");
                    }S
                    else
                    {
                        MessageBox.Show("Usuário não cadastrado ou senha inválida");
                    }

                }
                else
                {
                    MessageBox.Show("Alteração de senha cancelada.");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos");
            }

        }
    }
}
