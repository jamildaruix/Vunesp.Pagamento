using System;
using System.Threading.Tasks;
using Vunesp.Pagamento.Domain.Core.Pagamento;
using Vunesp.Pagamento.Domain.Interfaces;
using Vunesp.Pagamento.Domain.Models;

namespace Vunesp.Pagamento.Domain.Core
{
    /// <summary>
    /// Aplicação da regra de negócio
    /// </summary>
    public class PagamentoCore : IPagamentoCore
    {
        private readonly IPagamentoRepository _pagamentoRepository;

        public PagamentoCore(IPagamentoRepository pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
        }


        /// <summary>
        /// Método da regra de negócio
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<bool> CartaoCredito(CandidatoProjetoPagamento model)
        {
            var returns = await _pagamentoRepository.Inserir(model);
            return true;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}