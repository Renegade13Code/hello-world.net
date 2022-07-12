using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld
{
    [Route(".well-known/pki-validation/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public string Index()
        {
            return "B1E3BC186832A4EE80457EBF4BADD3B93D8574A3ABE59C898C83B0E8D690F65E\nssl.com\n20220711";
        }
    }
}
