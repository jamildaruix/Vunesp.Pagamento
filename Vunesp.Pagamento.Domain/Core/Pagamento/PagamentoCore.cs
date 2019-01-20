using System;
using System.Threading.Tasks;
using Vunesp.Pagamento.Domain.Core.Pagamento;
using Vunesp.Pagamento.Domain.Interfaces;

namespace Vunesp.Pagamento.Domain.Core
{
    public class PagamentoCore : IPagamentoCore
    {
        private readonly IPagamentoRepository _pagamentoRepository;

        public PagamentoCore(IPagamentoRepository pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
        }

        public Task<bool> CartaoCredito()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

        //public CandidatoProjetoPagamentoModel Inserir(CandidatoProjetoPagamentoModel model)
        //{
        //    // Valida...
        //    if (model == null)
        //        throw new ArgumentNullException("Objeto nulo");

        //    return new CandidatoProjetoPagamentoRep().Inserir(model);
        //}

        //public List<CandidatoProjetoPagamentoModel> Listar()
        //{            
        //    return new CandidatoProjetoPagamentoRep().Listar();
        //}

        //public CandidatoProjetoPagamentoModel Buscar(int id)
        //{
        //    // Valida...
        //    if (id <= 0)
        //        throw new ArgumentException($"Parâmetro inválido {nameof(id)}");

        //    var model = new CandidatoProjetoPagamentoRep().Buscar(id);

        //    // Se não existir retorna erro...
        //    if (model == null)
        //        throw new IndexOutOfRangeException($"{nameof(CandidatoProjetoPagamentoModel)} com [{nameof(id)} = {id}] não encontrado");

        //    return model;
        //}
    }
}