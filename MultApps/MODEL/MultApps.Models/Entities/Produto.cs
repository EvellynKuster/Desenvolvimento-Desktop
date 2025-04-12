using MultApps.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Entities
{
    internal class Produto : EntidadeBase
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }
       
    }
}
