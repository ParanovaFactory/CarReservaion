﻿using CarBook.Dto.PricingDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("Admin/AdminPricing")]
    public class AdminPricingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminPricingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var token = User.Claims.FirstOrDefault(x => x.Type == "carbooktoken")?.Value;
            if (token != null)
            {
                var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var responseMessage = await client.GetAsync("https://localhost:44365/api/Pricings");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultPricingDto>>(jsonData);
                    return View(values);
                }
            }
            return View();
        }

        [HttpGet]
        [Route("CreatePricing")]
        public IActionResult CreatePricing()
        {
            return View();
        }

        [HttpPost]
        [Route("CreatePricing")]
        public async Task<IActionResult> CreatePricing(CreatePricingDto createPricingDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createPricingDto);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:44365/api/Pricings", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminPricing", new { area = "Admin" });
            }
            return View();
        }

        [HttpGet]
        [Route("UpdatePricing/{id}")]
        public async Task<IActionResult> UpdatePricing(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44365/api/Pricings/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdatePricingDto>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        [Route("UpdatePricing/{id}")]
        public async Task<IActionResult> UpdatePricing(UpdatePricingDto updatePricingDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updatePricingDto);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync($"https://localhost:44365/api/Pricings/", content);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminPricing", new { area = "Admin" });
            }
            return View();
        }

        [Route("DeletePricing/{id}")]
        public async Task<IActionResult> DeletePricing(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:44365/api/Pricings/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "AdminPricing", new { area = "Admin" });
            }
            return View();
        }
    }
}
