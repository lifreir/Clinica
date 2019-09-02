namespace Clinica.Domain.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public long Cep { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Lougardouro { get; set; }
        public string Numero { get; set; }
        public string PontoReferencia { get; set; }
        public int PacienteId { get; set; }
    }
}
