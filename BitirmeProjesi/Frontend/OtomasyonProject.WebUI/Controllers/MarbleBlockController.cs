using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OtomasyonProject.DAL.Absctract;
using OtomasyonProject.DAL.EntityFramework;
using OtomasyonProject.EntityLayer.Concrete;
using OtomasyonProject.WebUI.Models.MarbleBlock;
using System.Text;

namespace OtomasyonProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class MarbleBlockController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MarbleBlockController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client=_httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5213/api/MarbleBlock");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<MarbleBlockVM>>(jsonData);
                return View(values);

            }
            return View();
        }
        [HttpGet]
        public IActionResult AddMarbleBlock()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddMarbleBlock(AddMarbleBlockVM model)
        {

            var client = _httpClientFactory.CreateClient();
            var jsonData=JsonConvert.SerializeObject(model);
            StringContent stringContent=new StringContent(jsonData,Encoding.UTF8,"aplication/json");
            var responseMessage = await client.PostAsync("http://localhost:5213/api/MarbleBlock",stringContent);
            if(responseMessage.IsSuccessStatusCode )
            {
                return RedirectToAction("Index");
            }
            return View();

        }

        public async Task<IActionResult> DeleteMarbleBlock(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5213/api/MarbleBlock/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateMarbleBlock(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5213/api/MarbleBlock/{id}");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData=await responseMessage.Content.ReadAsStringAsync();
                var values=JsonConvert.DeserializeObject<UpdateMarbleBlockVM>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateMarbleBlock(UpdateMarbleBlockVM model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData=JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData,Encoding.UTF8,"aplication/json");
            var responseMessage = await client.PutAsync("http://localhost:5213/api/MarbleBlock/",stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        private readonly IMarbleBlockDAL _marbleBlockDAL;

        public MarbleBlockController(IMarbleBlockDAL marbleBlockDAL)
        {
            _marbleBlockDAL = marbleBlockDAL;
        }

        
        public ActionResult DetailMarbleBlock(int id)
        {
            
            var marbleBlock = _marbleBlockDAL.GetById(id);

            
            
            var viewModel = new MarbleBlockVM
            {
                MarbleBlockId = marbleBlock.MarbleBlockId,
                Width = marbleBlock.Width,
                Height = marbleBlock.Height,
                Thickness=marbleBlock.Thickness,
                PurchaseDate=marbleBlock.PurchaseDate,
                BlockCode= marbleBlock.BlockCode,
                WarehouseSection= marbleBlock.WarehouseSection
            };

            return View(viewModel);
        }
    }
    
}
