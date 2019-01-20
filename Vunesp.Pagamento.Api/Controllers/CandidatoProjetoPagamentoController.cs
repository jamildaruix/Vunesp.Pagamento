using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vunesp.Pagamento.Application.Interfaces;
using Vunesp.Pagamento.Application.ViewModels;
using static AutoMapper.Mapper;

namespace Vunesp.Pagamento.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        private readonly IPagamentoAppService _pagamentoAppService;

        public PagamentoController(IPagamentoAppService pagamentoAppService)
        {
            _pagamentoAppService = pagamentoAppService;
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CandidatoProjetoPagamentoViewModel model)
        {
            var returns = await _pagamentoAppService.Credito(model);
            return Ok(returns);
        }
    }
}
