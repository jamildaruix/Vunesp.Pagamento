using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vunesp.Pagamento.Data.Context;
using Vunesp.Pagamento.Domain.Interfaces;
using Vunesp.Pagamento.Domain.Models;

namespace Vunesp.Pagamento.Data.Repository
{
    public class PagamentoCandidatoRepository : RepositoryDefault<CandidatoProjetoPagamento>, IPagamentoRepository
    {
        public PagamentoCandidatoRepository(ContextEF context) : base(context)
        {
        }

        public async Task<CandidatoProjetoPagamento> Buscar(int id)
        {
            return null;
        }

        public async Task<List<CandidatoProjetoPagamento>> Listar()
        {
            return null;
        }
    }
}
