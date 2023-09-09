using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OtomasyonProject.BLL.Abstract;
using OtomasyonProject.DAL.Absctract;
using OtomasyonProject.EntityLayer.Concrete;

namespace OtomasyonProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarbleBlockController : ControllerBase
    {
        
        private readonly IMarbleBlockDAL _marbleBlockDAL;
        private readonly IMarbleBlockService _marbleBlockService;

        public MarbleBlockController(IMarbleBlockService marbleBlockService, IMarbleBlockDAL marbleBlockDAL)
        {
            _marbleBlockService = marbleBlockService;
            _marbleBlockDAL = marbleBlockDAL;
        }
        [HttpGet]

        public IActionResult MarbleBlockList()
        {
            var values = _marbleBlockService.TGetList();
            return Ok(values);
        }

        [HttpPost]

        public IActionResult AddMarbleBlock(MarbleBlock marbleBlock)
        {
            _marbleBlockService.TInsert(marbleBlock);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMarbleBlock(int id)
        {
            var values = _marbleBlockService.TGetById(id);
            _marbleBlockService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateMarbleBlock(MarbleBlock marbleBlock)
        {
            _marbleBlockService.TUpdate(marbleBlock);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetMarbleBlock(int id)
        {
            var values = _marbleBlockService.TGetById(id);
            return Ok(values);
        }
    }
}
