using AutoMapper;
using Vunesp.Pagamento.Application.ViewModels;
using Vunesp.Pagamento.Domain.Models;

namespace Vunesp.Pagamento.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CandidatoProjetoPagamentoViewModel, CandidatoProjetoPagamento>()
                 .ConstructUsing(c => new CandidatoProjetoPagamento(c.PagamentoId, c.CandidatoId, c.Valor, c.Nome));
        }
    }
}
