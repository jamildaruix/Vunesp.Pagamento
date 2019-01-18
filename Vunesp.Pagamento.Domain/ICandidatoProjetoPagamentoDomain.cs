using System.Collections.Generic;
using Vunesp.Pagamento.Model;

namespace Vunesp.Pagamento.Domain
{
    public interface ICandidatoProjetoPagamentoDomain
    {
        List<CandidatoProjetoPagamentoModel> Listar();
        CandidatoProjetoPagamentoModel Buscar(int id);
        CandidatoProjetoPagamentoModel Inserir(CandidatoProjetoPagamentoModel model);
    }
}