using GestaoPagamento.ContentContext.Enum;

namespace GestaoPagamento.ContentContext{
    public class Empresa{

        public Empresa()
        {
            Enderecos = new List<Endereco>();
            Contatos =new List<Contato>();
        }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string IncricaoEstatual { get; set; }
        public EcontentCategoria Categoria { get; set; }
        public IList<Endereco> Enderecos {get; set;}
        public IList<Contato> Contatos{get; set;}

    }
}