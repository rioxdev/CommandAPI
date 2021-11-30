using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CommandAPI.Data;
using CommandAPI.Models;

namespace CommandAPI.AddControllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {

        private readonly ICommandAPIRepo _repository;

        public CommandsController(ICommandAPIRepo repo)
        {
            _repository = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAll()
        {
            var commands = _repository.GetAll();
            return Ok(commands);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetById(int id)
        {
            var command = _repository.GetById(id);
            return command != null ? Ok(command) : NotFound();
        }
    }
}