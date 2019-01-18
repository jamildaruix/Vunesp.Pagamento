using System;
using Vunesp.Pagamento.Model;
using Vunesp.Pagamento.Repositorio;

namespace Vunesp.Pagamento.Domain
{
    public class CandidatoProjetoPagamentoDomain
    {
        public CandidatoProjetoPagamento Inserir(CandidatoProjetoPagamento model)
        {        
            // Valida...
            if (model == null)
                throw new ArgumentNullException("Objeto nulo");

            return new CandidatoProjetoPagamentoRep().Inserir(model);
        }

        public CandidatoProjetoPagamento Buscar(int id)
        {   
            // Valida...
            if (id <= 0)
                throw new ArgumentException($"Parâmetro inválido {nameof(id)}");

            return new CandidatoProjetoPagamentoRep().Buscar(id);
        }
    }
}
