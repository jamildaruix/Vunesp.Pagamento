using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vunesp.Pagamento.Application.Interfaces;
using Vunesp.Pagamento.Application.ViewModels;
using Vunesp.Pagamento.Domain.Interfaces;
using Vunesp.Pagamento.Domain.Models;

namespace Vunesp.Pagamento.Application.Services
{
    public class PagamentoAppService : IPagamentoAppService
    {
        private readonly IMapper _mapper;
        private readonly IPagamentoRepository _pagamentoCandidatoRepository;

        public PagamentoAppService(IMapper mapper, IPagamentoRepository pagamentoCandidatoRepository)
        {
            _mapper = mapper;
            _pagamentoCandidatoRepository = pagamentoCandidatoRepository;
        }

        public async Task<bool> Credito(CandidatoProjetoPagamentoViewModel model)
        {
            var pagamento = _mapper.Map<CandidatoProjetoPagamento>(model);
            var returns = await _pagamentoCandidatoRepository.Inserir(pagamento);
            return true;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}