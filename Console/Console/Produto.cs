using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Valor { get; set; }
        public Produto(int id, string nome, int valor)
        {
            this.Id = id;
            this.Nome = nome;
            this.Valor = valor;
        }
    }

}
