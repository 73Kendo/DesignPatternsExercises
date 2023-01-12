using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace SingletonWebApi.Controllers
{
    [ApiController]
    [Route("[controller].xml")]
    public class SitemapController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Content(SitemapConfiguration.LoadConfiguration(), new MediaTypeHeaderValue("application/xml"));
        }
    }
}
