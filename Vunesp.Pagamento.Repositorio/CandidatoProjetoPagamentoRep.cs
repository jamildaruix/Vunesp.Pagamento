using System;
using Vunesp.Pagamento.Model;

namespace Vunesp.Pagamento.Repositorio
{
    public class CandidatoProjetoPagamentoRep
    {
        public CandidatoProjetoPagamento Inserir(CandidatoProjetoPagamento model)
        {
            //Insere no banco
            return new CandidatoProjetoPagamento() { ID = 1 };
        }

        public CandidatoProjetoPagamento Buscar(int id)
        {            
            //Buscar no banco
            return new CandidatoProjetoPagamento() { ID = 1 };
        }
    }
}
