using System;

namespace Vunesp.Pagamento.Model
{
    public class CandidatoProjetoPagamentoModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        /// <summary>
        /// Exemplo de campo que não deve ser exposto na API
        /// </summary>
        public string Token { get; set; }
    }
}
