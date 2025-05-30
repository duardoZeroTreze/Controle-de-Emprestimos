using PagarEmprestimo;
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

namespace Sistema_de_Emprestimo
{
    public partial class MenuPrincipal : Form
    {
        private Sistema sistema;
        public MenuPrincipal()
        {
            InitializeComponent();
            sistema = new Sistema();
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            PagarEmprestimo pagarEmprestimo = new PagarEmprestimo(sistema);
            pagarEmprestimo.Show();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            RegistrarEmprestimo registrar = new RegistrarEmprestimo(sistema);
            registrar.Show();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            ConsultarUsuario consultar = new ConsultarUsuario(sistema);
            consultar.Show();
        }

        private void btn_alterarSenha_Click(object sender, EventArgs e)
        {
            AlterarSenha alterar = new AlterarSenha(sistema);
            alterar.Show();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            CadastrarUsuario cadastrarUser = new CadastrarUsuario(sistema);
            cadastrarUser.Show();
        }
    }
}
