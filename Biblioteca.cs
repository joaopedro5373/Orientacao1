using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_orientacao_objetos_de_JoaoPedro
{
    public class Biblioteca
    {
        List<Livro> livros;
        List<Usuario> usuarios;
        List<Emprestimo> emprestimos;

        public Biblioteca()
        {
            this.livros = new List<Livro>();
            this.usuarios = new List<Usuario>();
            this.emprestimos = new List<Emprestimo>();

        }
        public void carregarDados()
        {

        }
        public void salvarDados()
        {

        }
        private Usuario selecionarUsuario()
        {
            if (usuarios.Count == 0)
            {
                Console.WriteLine("Não existem usuários cadastrados no sistema!");
                return null;
            }
            Usuario usuario = usuarios[0];
            return usuario;
        }


        private Livro selecionarLivro()
        {
            if (livros.Count == 0)
            {
                Console.WriteLine("Não existem livros cadastrados no sistema!");
                return null;
            }
            Livro livro = livros[0];
            return livro;
        }


        private Emprestimo selecionarEmprestimo()
        {
            if (emprestimos.Count == 0)
            {
                Console.WriteLine("Não existem empréstimos cadastrados no sistema!");
                return null;

            }
            Emprestimo emprestimo = emprestimos[0];
            return emprestimo;

        }

        public void marcarlivroComoPerdido()
        {
            Livro livro = selecionarLivro();
            if (livro == null) return;
            livro.perdido = true;
            salvarDados();
        }
        public void marcarLivroComoDestruído()
        {
            Livro livro = selecionarLivro();
            if (livro == null) return;
            livro.destruido = true;
            salvarDados();
        }
        public void atualizarDadosDoLivro()
        {
            Livro livro = selecionarLivro();
            if (livro == null) return;
            salvarDados();
               

        }
        public void CadastrarNovoUsuario()
        {
            Usuario novoUsuario = new Usuario();
            usuarios.Add(novoUsuario);
            salvarDados();
        }
        public void atualozarCadastroUsuario()
        {
            Usuario usuario = selecionarUsuario();
            if (usuario == null) return;
            salvarDados();
        }
        public void banirUsuario()
        {
            Usuario usuario = selecionarUsuario();
            if (usuario == null) return;
            usuario.banido = true;
            salvarDados();
        }
        public void emprestarLivro()
        {
            Livro livro = selecionarLivro();
            if (livro == null) return;

            Usuario usuario = selecionarUsuario();
            if (usuario == null) return;
            
            Emprestimo emprestimo = new Emprestimo();
            emprestimo.id_livro = livro.id;
            emprestimo.id_usuario = usuario.id;
            livro.disponivel = false;


        }
    
    
    }
}
    
