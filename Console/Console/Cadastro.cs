using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console.Models;

namespace Console
{


    class Cadastro
    {
        List<Categoria> categoria = new List<Categoria>();
        List<Produto> produto = new List<Produto>();


        public void CadastroProduto()
        {
            System.Console.WriteLine("\n********** CADASTRANDO NOVO PRODUTO **********\n");
            int id = produto.Count() + 1;
            System.Console.Write("\nNome: ");
            string nome = Validacao.ValidaStringEmBranco();
            System.Console.Write("\nValor: ");
            decimal valor = Convert.ToDecimal(System.Console.ReadLine());
            System.Console.WriteLine("\n\t*** CATEGORIA DO PRODUTO ***");
            System.Console.Write("ID: ");
            int categId = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Nome: ");
            string categNome = System.Console.ReadLine();
            System.Console.Write("Descrição: ");
            string categDescricao = System.Console.ReadLine();
            Categoria categoria = new Categoria(categId, categNome, categDescricao);
            produto.Add(new Produto(id, nome, valor, categoria));
        }

        public void CadastroCategoria()
        {
            int id = categoria.Count();
            System.Console.Write("\nNome: ");
            string nome = Validacao.ValidaStringEmBranco();
            System.Console.Write("\nDescrição: ");
            string descricao = Validacao.ValidaStringEmBranco();
            categoria.Add(new Categoria(id, nome, descricao));
        }

        public void ListagemP()
        {
            System.Console.WriteLine("\nProdutos cadastrados");
            System.Console.WriteLine("\n*********************************************************");
            foreach (var item in produto)
                {
                    System.Console.WriteLine($"\n\tNome do Produto: {item.Nome} \n\tID do Produto: {item.Id} \n\tDescrição do Produto: {item.Valor}");
                    System.Console.WriteLine("\n\tCategoria do Produto");
                    System.Console.WriteLine($"\n\tID Categoria: {item.categoria.Id}\n\tNome Categoria: {item.categoria.Nome}\n\tDescrição Categoria: {item.categoria.Descricao}");
                }
            System.Console.WriteLine("\n*********************************************************");
        }

        public void ListagemC()
        {
            System.Console.WriteLine("\nCategorias cadastrados");
            System.Console.WriteLine("\n*********************************************************");
            foreach (var item in categoria)
            {
                System.Console.WriteLine($"\n\tNome da categoria: {item.Nome} \n\tID da categoria: {item.Id} \n\tDescrição da categoria: {item.Descricao}");

            }
            System.Console.WriteLine("\n*********************************************************");
        }

    }
}
