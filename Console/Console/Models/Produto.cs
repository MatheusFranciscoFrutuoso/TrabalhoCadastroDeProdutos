using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Models
{
    class Produto: BaseModel
    {
        public decimal Valor { get; set; }
        public Categoria categoria { get; set; }
        public Produto(int id, string nome, decimal valor, Categoria categoria)
        {
            this.Id = id;
            this.Nome = nome;
            this.Valor = valor;
            this.categoria = categoria;
        }


    }

}
