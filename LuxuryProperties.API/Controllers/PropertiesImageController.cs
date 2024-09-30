using LuxuryProperties.API.DTOs;
using LuxuryProperties.API.Repository;
using LuxuryProperties.API.Repository.IRepository;
using LuxuryProperties.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LuxuryProperties.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class PropertiesImageController(IPropertyImageRepository propertyImageRepository, IPropertyRepository propertyRepository) : ControllerBase
    {
        private readonly IPropertyImageRepository _propertyImageRepository = propertyImageRepository;
        

        [HttpPost]
        public IActionResult AddImageProperty([FromForm] PropertyImageDTO propertyImageDto)
        {
            if(!ModelState.IsValid) { return BadRequest(ModelState); }

            if(propertyImageDto == null) { return BadRequest(ModelState); }

            var property = propertyRepository.GetPropertyById(propertyImageDto.IdProperty);
            if (property == null) { return NotFound($"No se encontro la propiedad con ID {propertyImageDto.IdProperty}"); }

            if (propertyImageDto.Imagen != null)
            {
                string nombreArchivo = propertyImageDto.IdPropertyImage + Guid.NewGuid().ToString() + Path.GetExtension(propertyImageDto.Imagen.FileName);
                string rutaArchivo = @"Image\Property\" + nombreArchivo;

                var ubicacionDirectorio = Path.Combine(Directory.GetCurrentDirectory(), rutaArchivo);

                FileInfo file = new FileInfo(ubicacionDirectorio);

                if (file.Exists)
                {
                    file.Delete();
                }

                using (var fileStream = new FileStream(ubicacionDirectorio, FileMode.Create))
                {
                    propertyImageDto.Imagen.CopyTo(fileStream);
                }
                propertyImageDto.File = rutaArchivo;
            }
            else
            {
                propertyImageDto.File = "https://placehold.co/600x400";
            }

            PropertyImage propertyImage = new PropertyImage();
            propertyImage.IdPropertyImage = propertyImageDto.IdPropertyImage;
            propertyImage.IdProperty = propertyImageDto.IdProperty;
            propertyImage.File = propertyImageDto.File;
            propertyImage.Enabled = propertyImageDto.Enabled;

            _propertyImageRepository.DisableOthersImageProperty();
            _propertyImageRepository.AddImageProperty(propertyImage);
            return Ok(propertyImage);
            
        }
    }
}
