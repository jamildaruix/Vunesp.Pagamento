using System.Collections.Generic;
using System.Threading.Tasks;
using Vunesp.Pagamento.Domain.Models;

namespace Vunesp.Pagamento.Domain.Interfaces
{
    public interface IPagamentoRepository : IRepositoryDefault<CandidatoProjetoPagamento> 
    {
        Task<CandidatoProjetoPagamento> Buscar(int id);
        Task<List<CandidatoProjetoPagamento>> Listar();
        //Task<CandidatoProjetoPagamentoModel> Inserir(CandidatoProjetoPagamentoModel model);
    }
}