using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vunesp.Pagamento.Domain;
using Vunesp.Pagamento.Dto;
using Vunesp.Pagamento.Model;
using static AutoMapper.Mapper;

namespace Vunesp.Pagamento.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CandidatoProjetoPagamentoController : ControllerBase
    {
        private readonly ICandidatoProjetoPagamentoDomain _service;

        public CandidatoProjetoPagamentoController(ICandidatoProjetoPagamentoDomain service)
        {
            _service = service;
        }

        // Listar
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                // Chama o domínio e retorna a lista de model convertido para lista de dto
                return Ok(Map<List<CandidatoProjetoPagamentoDto>>(_service.Listar()));
            }
            catch (Exception ex)
            {
                return Ok(new { ex.Message });
            }
        }

        // Buscar
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                // Chama o domínio e retorna o model convertio para dto
                return Ok(Map<CandidatoProjetoPagamentoDto>(_service.Buscar(id)));
            }
            catch (Exception ex)
            {
                return Ok(new { ex.Message });
            }
        }

        // Inserir
        [HttpPost]
        public ActionResult Post([FromBody] CandidatoProjetoPagamentoDto dto)
        {
            try
            {
                // Chama o domínio passando o dto convertido para model
                return Ok(_service.Inserir(Map<CandidatoProjetoPagamentoModel>(dto)));
            }
            catch (Exception ex)
            {
                return Ok(new { ex.Message });
            }
        }
    }
}
