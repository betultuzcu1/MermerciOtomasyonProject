using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OtomasyonProject.DAL.Absctract;
using OtomasyonProject.WebUI.Models.MarbleBlock;
using OtomasyonProject.WebUI.Models.Plate;
using System.Text;

namespace OtomasyonProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class PlateController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PlateController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5213/api/Plate");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<PlateVM>>(jsonData);
                return View(values);

            }
            return View();
        }
        [HttpGet]
        public IActionResult AddPlate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPlate(AddPlateVM model)
        {

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "aplication/json");
            var responseMessage = await client.PostAsync("http://localhost:5213/api/Plate", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }

        public async Task<IActionResult> DeletePlate(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5213/api/Plate/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdatePlate(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5213/api/Plate/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdatePlateVM>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdatePlate(UpdatePlateVM model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "aplication/json");
            var responseMessage = await client.PutAsync("http://localhost:5213/api/Plate/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        private readonly IPlateDAL _plateDAL;

        public PlateController(IPlateDAL plateDAL)
        {
            _plateDAL = plateDAL;
        }


        public ActionResult DetailPlate(int id)
        {

            var plate = _plateDAL.GetById(id);



            var viewModel = new PlateVM
            {
                PlateId = plate.PlateId,
                Width = plate.Width,
                Height = plate.Height,
                Thickness = plate.Thickness,
               PlateCode = plate.PlateCode,
                WarehouseSection = plate.WarehouseSection
            };

            return View(viewModel);
        }
    }
}
