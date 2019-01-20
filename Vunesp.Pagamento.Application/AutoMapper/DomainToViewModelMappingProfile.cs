using AutoMapper;
using Vunesp.Pagamento.Application.ViewModels;
using Vunesp.Pagamento.Domain.Models;

namespace Vunesp.Pagamento.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<CandidatoProjetoPagamento, CandidatoProjetoPagamentoViewModel>();
        }
    }
}
