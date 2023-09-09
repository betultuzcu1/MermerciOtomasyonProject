using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OtomasyonProject.DAL.Absctract;
using OtomasyonProject.DAL.EntityFramework;
using OtomasyonProject.WebUI.Models.Voucher;
using System.Text;

namespace OtomasyonProject.WebUI.Controllers
{
    [AllowAnonymous]
    public class VoucherController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IVoucherDAL _voucherDAL;

        public VoucherController(IHttpClientFactory httpClientFactory, IVoucherDAL voucherDAL)
        {
            _httpClientFactory = httpClientFactory;
            _voucherDAL = voucherDAL;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5213/api/Voucher");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<VoucherVM>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public IActionResult AddVoucher()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddVoucher(AddVoucherVM model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("http://localhost:5213/api/Voucher", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteVoucher(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"http://localhost:5213/api/Voucher/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateVoucher(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"http://localhost:5213/api/Voucher/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateVoucherVM>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateVoucher(UpdateVoucherVM model)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(model);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("http://localhost:5213/api/Voucher/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult DetailVoucher(int id)
        {
            var voucher = _voucherDAL.GetById(id);
            var viewModel = new VoucherVM
            {
                VoucherId = voucher.VoucherId,
                VoucherType = voucher.VoucherType,
                VoucherDate = voucher.VoucherDate,
                CurrentCardId= voucher.CurrentCardId,
                CreationDate= voucher.CreationDate,
            };
            return View(viewModel);
        }
    }
}
