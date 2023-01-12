using System.Xml.Linq;

namespace SingletonWebApi
{
    public class SitemapConfiguration
    {
        public static string LoadConfiguration()
        {
            var sitemap = XDocument.Load(Path.Combine(Directory.GetCurrentDirectory(), "sitemap.xml"));

            return sitemap.ToString();
        }
    }
}
