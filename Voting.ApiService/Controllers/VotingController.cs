using Microsoft.AspNetCore.Mvc;
using Voting.ApiService.Models.Voting.Requests;

namespace Voting.ApiService.Controllers;

[ApiController]
[Route("[controller]")]
public class VotingController : ControllerBase
{

    [HttpPost]
    public ActionResult Create([FromBody] CreateVotigRequestModel request)
    {
        //validar se exite mais de 1 id diferente na lista 
        //validar se já existe votação ativa
        //criar votação
        //retornar id votação e participantes
        return Ok();
    }

    [HttpPost("vote")]
    public ActionResult Vote([FromBody] VoteRequestModel request)
    {
        //validar se existe votação e participante
        //publicar na fila
        //retornar voto computado
        return Ok();
    }

    [HttpPost("finish")]
    public ActionResult Finish()
    {
        //validar se já existe votação ativa
        //encerrar votação
        return Ok();
    }

    [HttpGet("parcial")]
    public ActionResult GetParcial()
    {
        //validar se já existe votação ativa
        //Buscar os dados da ultima votação ativa
        return Ok();
    }

    [HttpGet("{id}")]
    public ActionResult GetById([FromRoute] Guid id)
    {        
        //Buscar os dados da votação por id
        return Ok();
    }
}

