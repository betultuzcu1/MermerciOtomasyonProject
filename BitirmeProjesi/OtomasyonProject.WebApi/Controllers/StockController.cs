using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OtomasyonProject.BLL.Abstract;
using OtomasyonProject.EntityLayer.Concrete;

namespace OtomasyonProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }
        [HttpGet]

        public IActionResult StockList()
        {
            var values = _stockService.TGetList();
            return Ok(values);
        }

        [HttpPost]

        public IActionResult AddStock(Stock stock)
        {
            _stockService.TInsert(stock);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteStock(int id)
        {
            var values = _stockService.TGetById(id);
            _stockService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStock(Stock stock)
        {
            _stockService.TUpdate(stock);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStock(int id)
        {
            var values = _stockService.TGetById(id);
            return Ok(values);
        }
    }
}
