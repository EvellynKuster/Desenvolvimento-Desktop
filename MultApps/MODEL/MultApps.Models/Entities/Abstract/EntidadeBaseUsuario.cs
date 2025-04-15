using MultApps.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultApps.Models.Entities.Abstract
{
    public class EntidadeBaseUsuario
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAcesso { get; set; }
        public StatusEnum Status { get; set; }
    }
}
