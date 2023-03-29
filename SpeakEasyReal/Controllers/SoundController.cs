using Microsoft.AspNetCore.Mvc;

namespace SpeakEasyReal.Controllers
{
    public class SoundController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
