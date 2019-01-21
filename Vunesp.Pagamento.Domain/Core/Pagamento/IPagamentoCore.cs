using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vunesp.Pagamento.Domain.Models;

namespace Vunesp.Pagamento.Domain.Core.Pagamento
{
    public interface IPagamentoCore : IDisposable
    {
        Task<CandidatoProjetoPagamento> CartaoCredito(CandidatoProjetoPagamento model);
    }
}
