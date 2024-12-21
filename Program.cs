using GestaoPagamento.ContentContext;

namespace GestaoPagamento {
    class Program{
        static void Main(string[] args){
            var empresas = new List<Empresa>();
            var contatos = new List<Contato>();
            empresas.Add(new Empresa("Empresa 01", "Empresa Fantasia 01", "1201201202", "000000222"));
            contatos.Add(new Contato("3050-5050"));
            foreach(var empresa in empresas){
                Console.WriteLine(empresa.RazaoSocial);
                Console.WriteLine(empresa.NomeFantasia);
                Console.WriteLine(empresa.Cnpj);
                Console.WriteLine(empresa.IncricaoEstatual);
                Console.WriteLine(Contato);
            }
        }
    }
}