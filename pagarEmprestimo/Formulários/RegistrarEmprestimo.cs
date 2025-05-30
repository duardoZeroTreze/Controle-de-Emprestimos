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
    public partial class RegistrarEmprestimo : Form
    {
        Sistema s;
        List<Emprestimo> emprestimos;
        public RegistrarEmprestimo(Sistema sistemaRecebido)
        {
            InitializeComponent();
            s = sistemaRecebido;
            emprestimos = s.emprestimos;
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            string nomeCredor = txt_credor.Text;
            string nomeDevedor = txt_devedor.Text;
            double valor;
            if (!double.TryParse(txt_valor.Text, out valor))
            {
                MessageBox.Show("Valor indevido!");
                return;
            }
            string data = dtp_data.Value.Date.ToString("dd/MM/yyyy");
            string senha = txt_senha.Text;

            if (string.IsNullOrEmpty(nomeCredor) || string.IsNullOrEmpty(nomeDevedor) || string.IsNullOrEmpty(data) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            string resultado = s.registrarEmprestimo(senha, valor, nomeCredor, nomeDevedor, data);
            MessageBox.Show(resultado);

        }

        private void RegistrarEmprestimo_Load(object sender, EventArgs e)
        {

        }
    }
}
