using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace SingletonWebApi.Controllers
{
    [ApiController]
    [Route("[controller].xml")]
    public class SitemapController : Controller
    {

        private readonly ISitemapConfiguration _configuration;
        public SitemapController(ISitemapConfiguration configuration)
        {
            _configuration = configuration;

        }
        [HttpGet]
        public IActionResult Get()
        {
            return Content(_configuration.SiteMap, new MediaTypeHeaderValue("application/xml"));
            //return Content(SitemapConfiLguration.LoadConfiguration(), new MediaTypeHeaderValue("application/xml"));
        }
    }
}
