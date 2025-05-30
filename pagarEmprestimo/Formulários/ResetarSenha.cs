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

namespace PagarEmprestimo.Formulários
{
    public partial class ResetarSenha : Form
    {
        Sistema s;
        public ResetarSenha(Sistema sistemaRecebido)
        {
            InitializeComponent();
            s = sistemaRecebido;
        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            Usuario user = s.usuarios.FirstOrDefault(u => u.nome.ToLower() == nome.ToLower());
            if (!string.IsNullOrEmpty(nome))
            {
                if (user != null)
                {
                    bool envio = s.EnviarEmail(user);
                    if (envio)
                    {
                        MessageBox.Show("Foi enviado um código no seu e-mail. Digite-o abaixo para confirmar o reset da senha.");

                        lb_codigo.Visible = true;
                        txt_código.Visible = true;
                        btn_verificar.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao enviar email.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Usuário não existente no sistema.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo devidamente");
                return;
            }
        }

        private void btn_verificar_Click_1(object sender, EventArgs e)
        {
            string codigoDigitado = txt_código.Text;
            string nome = txt_nome.Text.ToLower();
            Usuario user = s.usuarios.FirstOrDefault(u => u.nome.ToLower() == nome.ToLower());
            if (s.codigosVerificacao.ContainsKey(nome) && s.codigosVerificacao[nome] == codigoDigitado)
            {
                MessageBox.Show("Código verificado! Senha alterada para padrão.");
                user.senha = "543";
            }
            else
            {
                MessageBox.Show("Código inválido.");
            }
        }
    }
}
