using LuxuryProperties.API.Repository.IRepository;
using LuxuryProperties.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LuxuryProperties.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class PropertiesController(IPropertyRepository propertyRepository) : ControllerBase
    {
        private readonly IPropertyRepository _propertyRepository = propertyRepository;

        [HttpGet]
        public IActionResult GetProperties()
        {
            var properties = _propertyRepository.GetProperties().ToList();
            return Ok(properties);
        }

        [HttpGet("{id}")]
        public IActionResult GetPropertyById(int id)
        {
            var properties = _propertyRepository.GetPropertyById(id);
            if (properties == null) return NotFound();

            return Ok(properties);
        }

        [HttpGet("GetPropertyByName/{name}")]
        public IActionResult GetPropertyByName(string name)
        {
            if (string.IsNullOrEmpty(name)) return BadRequest();

            var properties = _propertyRepository.GetPropertyByName(name);
            if (properties == null) return NotFound();

            return Ok(properties);
        }

        [HttpGet("GetPropertyByCodeInternal/{id}")]
        public IActionResult GetPropertyByCodeInternal(int id)
        {
            var properties = _propertyRepository.GetPropertyByCodeInternal(id);
            if (properties == null) return NotFound();

            return Ok(properties);
        }

        [HttpGet("GetPropertyByYear/{id}")]
        public IActionResult GetPropertyByYear(int id)
        {
            var properties = _propertyRepository.GetPropertyByYear(id);
            if (properties == null) return NotFound();

            return Ok(properties);
        }

        [HttpGet("GetPropertyByIdOwner/{id}")]
        public IActionResult GetPropertyByIdOwner(int id)
        {
            var properties = _propertyRepository.GetPropertyByIdOwner(id);
            if (properties == null) return NotFound();

            return Ok(properties);
        }

        [HttpPost]
        public IActionResult CreateProperty(Property property)
        {
            if (!ModelState.IsValid) { return BadRequest(); }

            _propertyRepository.CreateProperty(property);
            return CreatedAtAction("CreateProperty", property.IdProperty, property);
        }

        [HttpPatch]
        public IActionResult ChangePriceProperty(Property property)
        {
            if (property == null) return NotFound();

            _propertyRepository.ChangePriceProperty(property);

            return Ok(property);
        }

        [HttpPut]
        public IActionResult UpdateProperty(Property property)
        {
            if (property == null) return NotFound();

            _propertyRepository.UpdateProperty(property);

            return Ok(property);
        }        

        [HttpDelete]
        public IActionResult DeleteProperty(Property property)
        {
            if (property == null) return NotFound();
            _propertyRepository.DeleteProperty(property);
            return NoContent();
        }

    }
}
