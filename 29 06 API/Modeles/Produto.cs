using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _29_06_API.Modeles
{
    public class Produto
    {
        public int Id { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public Categoria categoria { get; set; }

    }
}
