using MultApps.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Entities
{
    public class Categoria : EntidadeBase
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
