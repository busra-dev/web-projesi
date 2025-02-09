using deneme2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System.Diagnostics;

namespace deneme2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult edblar()
        {
            return View();
        }
        public IActionResult galeri()
        {
            return View();
        }
        public IActionResult hep_genc_kalacagim()
        {
            return View();
        }
        public IActionResult alinti()
        {
            return View();
        }
        public IActionResult butun_siirleri()
        {
            return View();
        }
        public IActionResult esirler()
        {
            return View();
        }
        public IActionResult canimAliye_ruhumFiliz()
        {
            return View();
        }
        public IActionResult icimizdeki_seytan()
        {
            return View();
        }
        public IActionResult madonna()
        {
            return View();
        }
        public IActionResult kuyucakli_yusuf()
        {
            return View();
        }
        public IActionResult sirca_kosk()
        {
            return View();
        }
        public IActionResult yeni_dunya()
        {
            return View();
        }
        public IActionResult ses()
        {
            return View();
        }
        public IActionResult kagni()
        {
            return View();
        }
        public IActionResult degirmen()
        {
            return View();
        }
        public IActionResult dön_yansima()
        {
            return View();
        }
        public IActionResult tr_modern_edb()
        {
            return View();
        }
        public IActionResult tr_edb()
        {
            return View();
        }
        public IActionResult cumhuriyet()
        {
            return View();
        }
        public IActionResult etki()
        {
            return View();
        }
        public IActionResult siir()
        {
            return View();
        }
        public IActionResult tiyatro()
        {
            return View();
        }
        public IActionResult mektup()
        {
            return View();
        }
        public IActionResult roman()
        {
            return View();
        }
        public IActionResult biyografi()
        {
            return View();
        }
        public IActionResult eserleri()
        {
            return View();
        }
        public IActionResult Oykuler()
        {
            return View();
        }
        public IActionResult iletisim()
        {
            return View();
        }
        [HttpPost]
        public IActionResult form(string ad, string email,string konu,string ileti)
        {
            var form_bilgi = new formbil();
            form_bilgi.ad = ad;
            form_bilgi.konu = konu;
            form_bilgi.email = email;
            form_bilgi.ileti = ileti;
            return View(form_bilgi);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}