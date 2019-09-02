using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Models
{
    public class Contato
    {
        public int ContatoId { get; set; }
        public string InformacaoContato { get; set; }
        public short TipoContato { get; set; }
        public bool Ativo { get; set; }
    }
}
