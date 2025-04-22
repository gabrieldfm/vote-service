using Microsoft.AspNetCore.Mvc;

namespace VotingSystem.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ParticipantController : ControllerBase
{
    //[HttpPost]
    //public ActionResult Create([FromBody] CreateParticipantRequestModel request)
    //{
    //    //criar participante
    //    //retornar id participante e nome
    //    return Ok();
    //}

    [HttpGet]
    public ActionResult GetAll()
    {
        //retornar todos os participantes id e nome
        return Ok();
    }

    [HttpGet("{id}")]
    public ActionResult GetById([FromRoute] Guid id)
    {
        //retornar participante id e nome
        return Ok();
    }
}