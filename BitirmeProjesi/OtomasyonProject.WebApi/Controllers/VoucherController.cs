using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OtomasyonProject.BLL.Abstract;
using OtomasyonProject.EntityLayer.Concrete;

namespace OtomasyonProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly IVoucherService _voucherService;

        public VoucherController(IVoucherService voucherService)
        {
            _voucherService = voucherService;
        }
        [HttpGet]

        public IActionResult VoucherList()
        {
            var values = _voucherService.TGetList();
            return Ok(values);
        }

        [HttpPost]

        public IActionResult AddVoucher(Voucher voucher)
        {
            _voucherService.TInsert(voucher);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteVoucher(int id)
        {
            var values = _voucherService.TGetById(id);
            _voucherService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateVoucher(Voucher voucher)
        {
            _voucherService.TUpdate(voucher);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetVoucher(int id)
        {
            var values = _voucherService.TGetById(id);
            return Ok(values);
        }
    }
}
