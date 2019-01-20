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

        public async Task<CandidatoProjetoPagamento> Inserir(CandidatoProjetoPagamento obj)
        {
            return null;
        }

        public async Task<CandidatoProjetoPagamento> Atualizar(CandidatoProjetoPagamento obj, int key)
        {
            return null;
        }

        public async Task<CandidatoProjetoPagamento> Buscar(int id)
        {
            return null;
        }

        public async Task<List<CandidatoProjetoPagamento>> Listar()
        {
            return null;
        }

        ///// <summary>
        ///// Simula a tabela
        ///// </summary>
        //public static List<CandidatoProjetoPagamentoModel> Tabela { get; set; } =
        //    new List<CandidatoProjetoPagamentoModel>()
        //    {
        //        new CandidatoProjetoPagamentoModel() { Id = 1, Nome = "João", Token = "123"},
        //        new CandidatoProjetoPagamentoModel() { Id = 2, Nome = "Maria", Token = "456"},
        //    };

        //public CandidatoProjetoPagamentoModel Inserir(CandidatoProjetoPagamentoModel model)
        //{
        //    // Insere no banco (...)            
        //    model.Id = Tabela.Last().Id + 1;
        //    Tabela.Add(model);

        //    return model;
        //}

        //public List<CandidatoProjetoPagamentoModel> Listar()
        //{            
        //    // Retorna uma lista do banco (...)
        //    return Tabela;            
        //}

        //public CandidatoProjetoPagamentoModel Buscar(int id)
        //{            
        //    //Buscar no banco (...)
        //    return Tabela.FirstOrDefault(c => c.Id == id);            
        //}
    }
}
