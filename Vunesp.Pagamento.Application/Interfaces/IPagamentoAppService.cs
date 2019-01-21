using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vunesp.Pagamento.Application.ViewModels;

namespace Vunesp.Pagamento.Application.Interfaces
{
    public interface IPagamentoAppService : IDisposable
    {
        Task<CandidatoProjetoPagamentoViewModel> Credito(CandidatoProjetoPagamentoViewModel model);
    }
}
