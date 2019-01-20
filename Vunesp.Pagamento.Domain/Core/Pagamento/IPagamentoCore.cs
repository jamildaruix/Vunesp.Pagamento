using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Vunesp.Pagamento.Domain.Core.Pagamento
{
    public interface IPagamentoCore : IDisposable
    {
        Task<bool> CartaoCredito();
    }
}
