using System;
using System.Collections.Generic;
using Vunesp.Pagamento.Model;
using Vunesp.Pagamento.Repositorio;

namespace Vunesp.Pagamento.Domain
{
    public class CandidatoProjetoPagamentoDomain : ICandidatoProjetoPagamentoDomain
    {
        public CandidatoProjetoPagamentoModel Inserir(CandidatoProjetoPagamentoModel model)
        {
            // Valida...
            if (model == null)
                throw new ArgumentNullException("Objeto nulo");

            return new CandidatoProjetoPagamentoRep().Inserir(model);
        }

        public List<CandidatoProjetoPagamentoModel> Listar()
        {            
            return new CandidatoProjetoPagamentoRep().Listar();
        }

        public CandidatoProjetoPagamentoModel Buscar(int id)
        {
            // Valida...
            if (id <= 0)
                throw new ArgumentException($"Parâmetro inválido {nameof(id)}");

            var model = new CandidatoProjetoPagamentoRep().Buscar(id);

            // Se não existir retorna erro...
            if (model == null)
                throw new IndexOutOfRangeException($"{nameof(CandidatoProjetoPagamentoModel)} com [{nameof(id)} = {id}] não encontrado");

            return model;
        }
    }
}
