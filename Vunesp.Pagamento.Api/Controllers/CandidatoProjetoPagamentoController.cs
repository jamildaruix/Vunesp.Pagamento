using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vunesp.Pagamento.Domain;
using Vunesp.Pagamento.Dto;
using Vunesp.Pagamento.Model;

namespace Vunesp.Pagamento.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoProjetoPagamentoController : ControllerBase
    {
        // GET api/CandidatoProjetoPagamento
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Funcionando";
        }

        // GET api/CandidatoProjetoPagamento/1
        [HttpGet("{id}")]
        public ActionResult<CandidatoProjetoPagamentoDto> Get(int id)
        {
            //Busca o model
            var model = new CandidatoProjetoPagamentoDomain().Buscar(id);

            //Retorna o dto convertido
            return Ok(new CandidatoProjetoPagamentoDto() { ID = model.ID });
        }

        // POST api/CandidatoProjetoPagamento
        [HttpPost]
        public ActionResult<CandidatoProjetoPagamentoDto> Post([FromBody] CandidatoProjetoPagamentoDto dto)
        {
            //Converte o dto para model
            var model = new CandidatoProjetoPagamento() { ID = dto.ID };
            
            //Insere o model
            var result = new CandidatoProjetoPagamentoDomain().Inserir(model);

            //Retorna o dto convertido
            return Ok(new CandidatoProjetoPagamentoDto() { ID = result.ID });
        }

        // PUT api/CandidatoProjetoPagamento/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/CandidatoProjetoPagamento/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
