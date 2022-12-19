using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using OrchardCore.Logging;

namespace HeyDanThomas.OrchardCore.Site
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseNLogWeb()
                .UseStartup<Startup>();
    }
}
