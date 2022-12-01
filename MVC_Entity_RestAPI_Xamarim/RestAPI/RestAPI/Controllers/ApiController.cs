using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPI.DataModels;

namespace RestAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class ApiController : ControllerBase
    {
        [HttpGet("nome")]
        public string RetornaNome()
        {
            return "Henrique";
        }

        [HttpGet("idade")]
        public int RetornaIdade()
        {
            return 23;
        }

        [HttpPost("nome/{palavra}")]
        public string RecebeNomeRetornaNome([FromRoute] string palavra)
        {
            //return $"{palavra}";
            return palavra;
        }

        [HttpPost("nomeIdade/{nome}/{idade}")]
        public string RecebeNomeIdadeRetornaNomeIdate([FromRoute] string nome, [FromRoute] int idade)
        {
            if (idade > 18)
            {
                return "Nome: " + nome + " é maior de idade";
            }
            else
            {
                return "Nome: " + nome + " é menor de idade";
            }
        }

        [HttpGet]
        [Route("pessoas")]
        public async Task<IActionResult> getAllAsync(
            [FromServices] Contexto contexto)
        {
            var pessoas = await contexto
                .Pessoas
                .AsNoTracking()//só pode ser utilizado em consultas - altamente recomendado por questões de desempenho
                .ToListAsync();

            return pessoas == null ? NotFound() : Ok(pessoas);
        }

        [HttpGet]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> getByIdAsync(
            [FromServices] Contexto contexto,
            [FromRoute] int id)
        {
            var pessoa = await contexto
                .Pessoas.AsNoTracking()//só pode ser utilizado em consultas - altamente recomendado por questões de desempenho
                .FirstOrDefaultAsync(p => p.Id == id);

            return pessoa == null ? NotFound() : Ok(pessoa);
        }

        [HttpPost]
        [Route("pessoas")]
        public async Task<IActionResult> PostAsync(
            [FromServices] Contexto contexto,
            [FromBody] Pessoa pessoa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                await contexto.Pessoas.AddAsync(pessoa);
                await contexto.SaveChangesAsync();
                return Created("$api/pessoas/{pessoa.id}", pessoa);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return pessoa == null ? NotFound() : Ok(pessoa);
        }

        [HttpPut]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] Contexto contexto,
            [FromBody] Pessoa pessoa,
            [FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest("Model Inválida");

            var p = await contexto.Pessoas
                .FirstOrDefaultAsync(x => x.Id == id);

            if (p == null)
                return NotFound("Pessoa não encontrada!");
            try
            {
                p.Nome = pessoa.Nome;
                contexto.Pessoas.Update(p);
                await contexto.SaveChangesAsync();
                return Ok(p);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromServices] Contexto contexto,
            [FromRoute] int id)
            {
            try
            {
                var p = await contexto.Pessoas.FirstOrDefaultAsync(x => x.Id == id);
                contexto.Pessoas.Remove(p);
                await contexto.SaveChangesAsync();
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }     
        }
            
    }
}