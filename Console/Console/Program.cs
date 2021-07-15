using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console.Models;

namespace Console


{
    class Program
    {

        static void Main(string[] args)
        {
            Program p = new Program();

            //cabecalho
            p.Cabecalho();
            //escolha
            p.Escolha();
        }

        public void Cabecalho()
        {
            System.Console.WriteLine("*********************  Havan Labs ***********************");
            System.Console.WriteLine("*********************  Bem-vindo ************************");
        }

        public void Rodape()
        {

            System.Console.WriteLine("\nEscolha um opção do menu:");
        }

        public void Opcoes()
        {
            System.Console.WriteLine("\n\t1-Cadastrar Produto");
            System.Console.WriteLine("\t2-Cadastrar Categoria");
            System.Console.WriteLine("\t3-Listar Produtos");
            System.Console.WriteLine("\t4-Listar Categorias");
            System.Console.WriteLine("\t0-Sair");
        }


        public void Escolha() {
            int opcao = 0;
            Cadastro cadastro = new Cadastro();
            do
            {
                Rodape();
                Opcoes();
                opcao = Convert.ToInt32(System.Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        cadastro.CadastroProduto();
                        break;
                    case 2:
                        cadastro.CadastroCategoria();
                        break;
                    case 3:
                        cadastro.ListagemP();
                        break;
                    case 4:
                        cadastro.ListagemC();
                        break;
                    case 0:
                        System.Console.WriteLine("Saindo... Tecle ENTER para sair");
                        break;
                }
            } while (opcao != 0);

        }
    }
}

