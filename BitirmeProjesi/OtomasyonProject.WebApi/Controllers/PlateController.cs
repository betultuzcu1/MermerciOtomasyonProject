using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OtomasyonProject.BLL.Abstract;
using OtomasyonProject.EntityLayer.Concrete;

namespace OtomasyonProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlateController : ControllerBase
    {
        private readonly IPlateService _plateService;

        public PlateController(IPlateService plateService)
        {
            _plateService = plateService;
        }
        [HttpGet]

        public IActionResult plateList()
        {
            var values = _plateService.TGetList();
            return Ok(values);
        }
        [HttpPost]

        public IActionResult AddPlate(Plate plate)
        {
            _plateService.TInsert(plate);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeletePlate(int id)
        {
            var values = _plateService.TGetById(id);
            _plateService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdatePlate(Plate plate)
        {
            _plateService.TUpdate(plate);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetPlate(int id)
        {
            var values = _plateService.TGetById(id);
            return Ok(values);
        }
    }
}
