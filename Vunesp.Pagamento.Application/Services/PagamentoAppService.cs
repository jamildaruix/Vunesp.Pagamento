using AutoMapper;
using System;
using System.Threading.Tasks;
using Vunesp.Pagamento.Application.Interfaces;
using Vunesp.Pagamento.Application.ViewModels;
using Vunesp.Pagamento.Domain.Core.Pagamento;
using Vunesp.Pagamento.Domain.Models;

namespace Vunesp.Pagamento.Application.Services
{
    public class PagamentoAppService : IPagamentoAppService
    {
        private readonly IMapper _mapper;
        private readonly IPagamentoCore _pagamentoCore;

        public PagamentoAppService(IMapper mapper, IPagamentoCore pagamentoCore)
        {
            _mapper = mapper;
            _pagamentoCore = pagamentoCore;
        }

        public async Task<CandidatoProjetoPagamentoViewModel> Credito(CandidatoProjetoPagamentoViewModel model)
        {
            var pagamento = _mapper.Map<CandidatoProjetoPagamento>(model);
            var returns = await _pagamentoCore.CartaoCredito(pagamento);

            var pagamentoViewModel = _mapper.Map<CandidatoProjetoPagamentoViewModel>(returns);

            return pagamentoViewModel;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}