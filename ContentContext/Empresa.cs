using GestaoPagamento.ContentContext.Enum;

namespace GestaoPagamento.ContentContext{
    public class Empresa{

        public Empresa(
            string razaoSocial,
            string nomeFantasia,
            string cnpj,
            string incricaoEstatual)
        {
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
            IncricaoEstatual = incricaoEstatual;
        }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string IncricaoEstatual { get; set; }


    }
}