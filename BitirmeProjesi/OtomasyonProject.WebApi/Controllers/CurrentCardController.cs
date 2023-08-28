using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OtomasyonProject.BLL.Abstract;
using OtomasyonProject.EntityLayer.Concrete;

namespace OtomasyonProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrentCardController : ControllerBase
    {
        private readonly ICurrentCardService _currentCardService;

        public CurrentCardController(ICurrentCardService currentCardService)
        {
            _currentCardService = currentCardService;
        }
        [HttpGet]

        public IActionResult CurrentCardList()
        {
            var values = _currentCardService.TGetList();
            return Ok(values);
        }
        [HttpPost]

        public IActionResult AddCurrentCard(CurrentCard currentCard)
        {
            _currentCardService.TInsert(currentCard);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteCurrentCard(int id)
        {
            var values = _currentCardService.TGetById(id);
            _currentCardService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateCurrentCard(CurrentCard currentCard)
        {
            _currentCardService.TUpdate(currentCard);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCurrentCard(int id)
        {
            var values = _currentCardService.TGetById(id);
            return Ok(values);
        }
    }
}
