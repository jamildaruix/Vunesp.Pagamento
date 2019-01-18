using System;
using System.Collections.Generic;
using System.Linq;
using Vunesp.Pagamento.Model;

namespace Vunesp.Pagamento.Repositorio
{
    public class CandidatoProjetoPagamentoRep
    {
        /// <summary>
        /// Simula a tabela
        /// </summary>
        public static List<CandidatoProjetoPagamentoModel> Tabela { get; set; } =
            new List<CandidatoProjetoPagamentoModel>()
            {
                new CandidatoProjetoPagamentoModel() { Id = 1, Nome = "João", Token = "123"},
                new CandidatoProjetoPagamentoModel() { Id = 2, Nome = "Maria", Token = "456"},
            };

        public CandidatoProjetoPagamentoModel Inserir(CandidatoProjetoPagamentoModel model)
        {
            // Insere no banco (...)            
            model.Id = Tabela.Last().Id + 1;
            Tabela.Add(model);

            return model;
        }

        public List<CandidatoProjetoPagamentoModel> Listar()
        {            
            // Retorna uma lista do banco (...)
            return Tabela;            
        }

        public CandidatoProjetoPagamentoModel Buscar(int id)
        {            
            //Buscar no banco (...)
            return Tabela.FirstOrDefault(c => c.Id == id);            
        }
    }    
}
