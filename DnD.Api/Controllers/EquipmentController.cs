using DnD.Application.Features.Equipment.Commands.CreateEquipment;
using DnD.Application.Features.Equipment.Queries.GetAllEquipments;
using DnD.Application.Features.Equipment.Queries.GetEquipmentDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DnD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentController : ControllerBase
    {

        private readonly IMediator _mediator;

        public EquipmentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<EquipmentController>
        [HttpGet]
        public async Task<IEnumerable<GetAllEquipmentsDto>> Get() =>
            await _mediator.Send(new GetAllEquipmentsQuery());

        // GET api/<EquipmentController>/6962a553-a2af-42e6-90e4-7a415f2cfb31
        [HttpGet("{guid}")]
        public async Task<GetEquipmentDetailsDto> Get(Guid guid) =>
            await _mediator.Send(new GetEquipmentDetailsQuery(guid));

        // POST api/<EquipmentController>
        [HttpPost]
        public async Task Post([FromBody] CreateEquipmentCommand value) =>
            await _mediator.Send(value);

        // PUT api/<EquipmentController>/6962a553-a2af-42e6-90e4-7a415f2cfb31
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EquipmentController>/6962a553-a2af-42e6-90e4-7a415f2cfb31
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
