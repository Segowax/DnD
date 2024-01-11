using DnD.Application.Features.Race.Queries.GetAllRaces;
using DnD.Application.Features.Race.Queries.GetRaceDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DnD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaceController : ControllerBase
    {

        private readonly IMediator _mediator;

        public RaceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<RaceController>
        [HttpGet]
        public async Task<IEnumerable<GetAllRacesDto>> Get() =>
            await _mediator.Send(new GetAllRacesQuery());

        // GET api/<RaceController>//6962a553-a2af-42e6-90e4-7a415f2cfb31
        [HttpGet("{guid}")]
        public async Task<GetRaceDetailsDto> Get(Guid guid) =>
            await _mediator.Send(new GetRaceDetailsQuery(guid));

        // POST api/<RaceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RaceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RaceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
