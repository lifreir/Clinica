using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Domain.Models
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public string NomePaciente { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public IEnumerable<Contato>Contatos { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

    }
}
