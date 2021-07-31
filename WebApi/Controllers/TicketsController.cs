using Core.Models;
using Microsoft.AspNetCore.Mvc;
// using PlatformDemo2.Filters;

namespace PlatformDemo2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        // [Route("api/tickets")]
        public IActionResult Get()
        {
            return Ok("Reading all tickets");
        }

        [HttpGet("{id}")]
        // [Route("api/tickets/{id}")]
        public IActionResult Get(int id)
        {
            return Ok($"Reading ticket: #{id}.");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Ticket ticket)
        {
            return Ok(ticket);
        }

        // [HttpPost]
        // [Route("/api/v2/tickets")]
        // [Ticket_EnsureEnteredDAte]
        // [Ticket_EnsureEnteredDateEarlierThanDueDate]
        // public IActionResult PostV2([FromBody] Ticket ticket)
        // {
        //     return Ok(ticket);
        // }

        [HttpPut]
        // [Route("api/tickets")]
        public IActionResult Put([FromBody] Ticket ticket)
        {
            return Ok(ticket);
        }

        [HttpDelete("{id}")]
        // [Route("api/tickets/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Delete ticket: {id}");
        }
    }
}