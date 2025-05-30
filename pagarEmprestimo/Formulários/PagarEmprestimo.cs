using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_de_Emprestimo
{
    public partial class PagarEmprestimo : Form
    {
        Sistema s;

        public PagarEmprestimo(Sistema sistemaRecebido)
        {
            InitializeComponent();
            s = sistemaRecebido;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string nomeDevedor = txt_devedor.Text;
            string nomeCredor = txt_credor.Text;

            var resultado = s.obterLista(nomeCredor, nomeDevedor);

            lsb_emprestimos.DataSource = null;
            lsb_emprestimos.DataSource = resultado;

            lsb_emprestimos.Visible = true;
            txt_senha.Visible = true;
            lb_senhaCredor.Visible = true;
            btn_quitar.Visible = true;
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            if (lsb_emprestimos.Items.Count > 0 && txt_senha.Text.Length != 0)
            {
                int selectedIndex = lsb_emprestimos.SelectedIndex;

                if (selectedIndex >= 0)
                {
                    var emprestimoSelecionado = (Emprestimo)lsb_emprestimos.SelectedItem;
                    bool pagou = s.pagarEmprestimo(txt_senha.Text, emprestimoSelecionado);

                    if (pagou)
                    {
                        lsb_emprestimos.DataSource = null;
                        lsb_emprestimos.DataSource = s.obterLista(txt_credor.Text, txt_devedor.Text);

                        txt_senha.Clear();
                        txt_credor.Clear();
                        txt_devedor.Clear();

                        MessageBox.Show("Empréstimo quitado");
                    }
                    else
                    {
                        MessageBox.Show("Senha errada");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um empréstimo.");
                }
            }
            else
            {
                MessageBox.Show("Verifique se a senha foi devidamente digitada ou se selecionou o empréstimo");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txt_devedor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}