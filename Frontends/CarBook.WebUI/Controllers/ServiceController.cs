using CarBook.Dto.ServiceDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers
{
    [AllowAnonymous]
    public class ServiceController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
    }
}
