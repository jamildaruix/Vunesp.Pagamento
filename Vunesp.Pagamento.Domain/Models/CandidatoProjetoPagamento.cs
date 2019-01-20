using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Vunesp.Pagamento.Domain.Models
{
    [Table("CandidatoProjetoPagamento")]
    public class CandidatoProjetoPagamento
    {
        public CandidatoProjetoPagamento(int pagamentoId, int candidatoId, decimal valor, string nome)
        {
            PagamentoId = pagamentoId;
            CandidatoId = candidatoId;
            Valor = valor;
            Nome = nome;
        }

        [Key]
        public int PagamentoId { get; private set; }

        public int CandidatoId { get; private set; }

        public decimal Valor { get; private set; }

        public string Nome { get; set; }

    }
}
