﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Sistema_de_Emprestimo
{
    public class Sistema
    {
        public List<Emprestimo> emprestimos = new List<Emprestimo>();
        public List<Usuario> usuarios = new List<Usuario>();

        public Sistema()
        {
            usuarios = new List<Usuario>();
            Usuario Maria = new Usuario("Maria", "543", "maria@gmail.com");
            Usuario Joao = new Usuario("João", "543", "joão@outlook.com");
            Usuario Jose = new Usuario("José", "543", "josé@yahoo.com");
            Usuario Antonio = new Usuario("Antonio", "543", "antonio@hotmail.com");

            usuarios.Add(Maria);
            usuarios.Add(Joao);
            usuarios.Add(Jose);
            usuarios.Add(Antonio);

            emprestimos = new List<Emprestimo>();

            emprestimos.Add(new Emprestimo(10, Maria, Joao, "03/09/2011"));
            emprestimos.Add(new Emprestimo(5, Jose, Antonio, "04/09/2011"));
            emprestimos.Add(new Emprestimo(12, Maria, Antonio, "04/09/2011"));
            emprestimos.Add(new Emprestimo(3, Antonio, Maria, "05/09/2011"));
            emprestimos.Add(new Emprestimo(18, Maria, Joao, "05/09/2011"));
        }

        internal void CadastrarUsuario(string nome, string senha, string email)
        {
            usuarios.Add(new Usuario(nome, senha, email));
        }

        public List<Emprestimo> obterLista(string nomeCredor, string nomeDevedor)
        {
            return emprestimos
                .Where(e => e.devedor.nome.ToLower().Contains(nomeDevedor.ToLower()) &&
                            e.credor.nome.ToLower().Contains(nomeCredor.ToLower()))
                .ToList();
        }

        public bool pagarEmprestimo(string senha,Emprestimo emprestimoSelecionado)
        {
            if (emprestimoSelecionado.credor.senha == senha)
            {
                emprestimos.Remove(emprestimoSelecionado);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string registrarEmprestimo(string senha, double valor, string credor, string devedor, string data)
        {
            if (validarUsuario(credor) && validarUsuario(devedor))
            {
                Usuario credorDigitado = usuarios.FirstOrDefault(u => string.Equals(u.nome.Trim(), credor.Trim(), StringComparison.OrdinalIgnoreCase));
                Usuario devedorDigitado = usuarios.FirstOrDefault(u => string.Equals(u.nome.Trim(), devedor.Trim(), StringComparison.OrdinalIgnoreCase));
                if (senha == devedorDigitado.senha)
                {
                    Emprestimo novo = new Emprestimo(valor, devedorDigitado, credorDigitado, data);
                    emprestimos.Add(novo);
                    return "Empréstimo registrado com sucesso!";
                } else
                {
                    return "Senha errada";
                }

            }
            return "Digite o nome de um credor/devedor válido";
        }

        public List<Emprestimo> obterListaEnvolvendoUsuario(string nome)
        {
            if (validarUsuario(nome))
            {
                return emprestimos
                .Where(e => e.devedor.nome.ToLower().Contains(nome.ToLower()) ||
                            e.credor.nome.ToLower().Contains(nome.ToLower()))
                .ToList();
            }
            return null;

        }

        public bool validarSenha(Usuario u, string senha)
        {
            if (u.senha == senha)
            {
                return true;
            }
            return false;
        }
        public bool alterarSenha(string nome, string senhaNova, string senhaAntiga)
        {
            if (validarUsuario(nome))
            {
                Usuario usuario = usuarios.FirstOrDefault(u => u.nome.ToLower() == nome.ToLower());
                if (validarSenha(usuario, senhaAntiga))
                {
                    usuario.senha = senhaNova;
                    return true;
                } else
                {
                    return false;
                }
            }
            return false;
        }

        internal bool validarUsuario(string nome)
        {
            Usuario usuario = usuarios.FirstOrDefault(u => string.Equals(u.nome.Trim(), nome.Trim(), StringComparison.OrdinalIgnoreCase));

            if (usuario == null)
            {
                return false;
            }
            return true;
        }

        internal void ExcluirUsuario(Usuario user)
        {
            usuarios.Remove(user);
        }

        public Dictionary<string, string> codigosVerificacao = new Dictionary<string, string>();
        internal bool EnviarEmail(Usuario user)
        {
            string assunto = "Código de verificação";
            string codigo = GerarCodigo();
            string corpo = $"Seu código de verificação é: {codigo}";
            string senhaApp = ConfigurationManager.AppSettings["SenhaApp"];
            string emailApp = ConfigurationManager.AppSettings["EmailApp"];

            SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
            cliente.EnableSsl = true;
            cliente.Credentials = new NetworkCredential(emailApp, senhaApp);

            MailMessage mensagem = new MailMessage(emailApp, user.email, assunto, corpo);

            try
            {
                cliente.Send(mensagem);
                codigosVerificacao[user.nome.ToLower()] = codigo;
                return true;
            }
            catch
            {
                return false;
            }
        }

        internal string GerarCodigo()
        {
            Random random = new Random();
            return random.Next(10000, 99999).ToString();
        }
    }
}
