using System.Globalization;
using System.Xml.Linq;

namespace SingletonWebApi
{

    public class SitemapConfiguration : ISitemapConfiguration
    {
        public SitemapConfiguration()
        {
            SiteMap = LoadConfiguration();
        }
        public string SiteMap { get; }
        public string LoadConfiguration()
        {
            var sitemap = XDocument.Load(Path.Combine(Directory.GetCurrentDirectory(), "sitemap.xml"));

            return sitemap.ToString();
        }
    }
    public interface ISitemapConfiguration
    {
        string LoadConfiguration();
        string SiteMap { get; }

    }
}
