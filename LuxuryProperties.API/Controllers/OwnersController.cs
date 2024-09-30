using LuxuryProperties.API.Repository.IRepository;
using LuxuryProperties.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LuxuryProperties.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class OwnersController(IOwnerRepository ownerRepository) : ControllerBase
    {
        private readonly IOwnerRepository _ownerRepository = ownerRepository;

        [HttpGet]
        public IActionResult GetOwners()
        {
            var owners = _ownerRepository.GetOwners().ToList();
            return Ok(owners);
        }

        [HttpGet("{id}")]
        public IActionResult GetOwner(int id)
        {
            var owner = _ownerRepository.GetOwner(id);
            if (owner == null) return NotFound();

            return Ok(owner);
        }

        [HttpPost]
        public IActionResult CreateOwner(Owner owner)
        {
            if(!ModelState.IsValid) { return BadRequest(); }

            _ownerRepository.CreateOwner(owner);
            return CreatedAtAction("CreateOwner", owner.IdOwner, owner);
        }

        [HttpDelete]
        public IActionResult DeleteOwner(Owner owner)
        {
            if (owner == null) return NotFound();
            _ownerRepository.DeleteOwner(owner);
            return NoContent();
        }    
    }
}
