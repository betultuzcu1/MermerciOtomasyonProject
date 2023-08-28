using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OtomasyonProject.BLL.Abstract;
using OtomasyonProject.EntityLayer.Concrete;

namespace OtomasyonProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherItemController : ControllerBase
    {
        private readonly IVoucherItemService _voucherItemService;

        public VoucherItemController(IVoucherItemService voucherItemService)
        {
            _voucherItemService = voucherItemService;
        }
        [HttpGet]

        public IActionResult VoucherItemList()
        {
            var values = _voucherItemService.TGetList();
            return Ok(values);
        }

        [HttpPost]

        public IActionResult AddVoucherItem(VoucherItem voucherItem)
        {
            _voucherItemService.TInsert(voucherItem);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteVoucherItem(int id)
        {
            var values = _voucherItemService.TGetById(id);
            _voucherItemService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateVoucherItem(VoucherItem voucherItem)
        {
            _voucherItemService.TUpdate(voucherItem);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetVoucherItem(int id)
        {
            var values = _voucherItemService.TGetById(id);
            return Ok(values);
        }
    }
}
