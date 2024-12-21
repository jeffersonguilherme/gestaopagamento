namespace GestaoPagamento.ContentContext{
    public class Contato {
        public Contato(
            string telefonePrincipal,
            string telefoneSecundario,
            string email,
            string nomeResponsavel
        )
        {
         TelefonePrincipal = telefonePrincipal;   
        }
        public string TelefonePrincipal { get; set; }
        public string TelefoneSecundario { get; set; }
        public string Email { get; set; }
        public string NomeResponsavel { get; set; }
    }
}