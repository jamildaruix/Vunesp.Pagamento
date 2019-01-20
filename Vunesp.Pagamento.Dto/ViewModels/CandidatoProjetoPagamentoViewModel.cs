using System;

namespace Vunesp.Pagamento.Application.ViewModels
{
    public class CandidatoProjetoPagamentoViewModel
    {
        public int PagamentoId { get; set; }

        public int CandidatoId { get; set; }

        public string Nome { get; set; }

        public decimal Valor { get; set; }
    }
}
