using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{


    class Cadastro
    {


        public Produto CadastroProduto()
        {
            List<Produto> produto = new List<Produto>();
            System.Console.WriteLine("\nInsira o nome do Produto a ser cadastrado");
            string nome = Validacao.ValidaStringEmBranco();
            System.Console.WriteLine("\nInsira a ID do Produto a ser cadastrado");
            int id = Validacao.ValidaInteiros();
            System.Console.WriteLine("\nInsira o valor do Produto a ser cadastrado");
            int valor = Validacao.ValidaInteiros();
            Produto model = new Produto(id, nome, valor);
            return model;
        }

        public Categoria CadastroCategoria()
        {

            System.Console.WriteLine("\nInsira o nome da categoria a ser cadastrada");
            string nome = Validacao.ValidaStringEmBranco();
            System.Console.WriteLine("\nInsira a ID da categoria a ser cadastrada");
            int id = Validacao.ValidaInteiros();
            System.Console.WriteLine("\nInsira a descrição da categoria a ser cadastrada");
            string descricao = Validacao.ValidaStringEmBranco();
            Categoria model = new Categoria(id, nome, descricao);
            return model;
        }

        public void ListagemP(List<Produto> itens)
        {
                System.Console.WriteLine("\nProdutos cadastrados");
            System.Console.WriteLine("\n*********************************************************");
            foreach (var item in itens)
                {
                    System.Console.WriteLine($"\n\tNome da categoria: {item.Nome} \n\tID da categoria: {item.Id} \n\tDescrição da categoria: {item.Valor}");
                }
            System.Console.WriteLine("\n*********************************************************");
        }

        public void ListagemC(List<Categoria> itens)
        {
            System.Console.WriteLine("\nCategorias cadastrados");
            System.Console.WriteLine("\n*********************************************************");
            foreach (var item in itens)
            {
                System.Console.WriteLine($"\n\tNome da categoria: {item.Nome} \n\tID da categoria: {item.Id} \n\tDescrição da categoria: {item.Descricao}");

            }
            System.Console.WriteLine("\n*********************************************************");
        }

    }
}
