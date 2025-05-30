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
    public partial class ConsultarUsuario : Form
    {
        Sistema s;

        public ConsultarUsuario(Sistema sistemaRecebido)
        {
            InitializeComponent();
            s = sistemaRecebido;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            string nome = txt_usuario.Text;
            List<Emprestimo> emprestimosUsuario = s.obterListaEnvolvendoUsuario(nome);
            if (emprestimosUsuario != null)
            {
                lsb_usuario.DataSource = null;
                lsb_usuario.DataSource = emprestimosUsuario;

                lb_nomeUsuario.Visible = true;
                lb_nomeUsuario.Text = nome;
                lsb_usuario.Visible = true;
                txt_usuario.Clear();
            }
            else
            {
                MessageBox.Show("Usuário não cadastrado!");
            }
        }
    }
}
