using Microsoft.AspNetCore.Mvc;

namespace hometask_15.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
            =>View();

        public string Detail(int id)
            =>"About Detail Section"+" Id: " + id;
    }
}
