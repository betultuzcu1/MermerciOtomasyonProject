using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OtomasyonProject.DAL.Absctract;
using OtomasyonProject.WebUI.Models.CurrentCard;
using System.Text;

namespace OtomasyonProject.WebUI.Controllers
{
    public class CurrentCardController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CurrentCardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5213/api/MarbleBlock");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<CurrentCardVM>>(jsonData);
                return View(values);

            }
            return View();
        }
        [HttpGet]
        public IActionResult AddCurrentCard()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCurrentCard(AddCurrentCardVM model)
        {

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "aplication/json");
            var responseMessage = await client.PostAsync("http://localhost:5213/api/CurrentCard", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }

        public async Task<IActionResult> DeleteCurrentCard(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5213/api/CurrentCard/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateCurrentCard(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5213/api/CurrentCard/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateCurrentCardVM>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateMarbleBlock(UpdateCurrentCardVM model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "aplication/json");
            var responseMessage = await client.PutAsync("http://localhost:5213/api/CurrentCard/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        private readonly ICurrentDAL _currentDAL;

        public CurrentCardController(ICurrentDAL currentDAL)
        {
            _currentDAL = currentDAL;
        }


        public ActionResult DetailICurrentDAL(int id)
        {

            var currentCard = _currentDAL.GetById(id);



            var viewModel = new CurrentCardVM
            {
                CurrentCardId = currentCard.CurrentCardId,
                CurrentTitle =currentCard.CurrentTitle,
                CurrentOwner=currentCard.CurrentOwner,
                PhoneNumber=currentCard.PhoneNumber,
                Address=currentCard.Address,
                City=currentCard.City,
                Region=currentCard.Region,
                Mail=currentCard.Mail
            };

            return View(viewModel);
        }
    }
}
