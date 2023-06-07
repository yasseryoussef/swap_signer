using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using swap_signer;

CreateHostBuilder().Build().Run();

//CreateHostBuilder1().Build().Run();
static IHostBuilder CreateHostBuilder()
{
    return Host.CreateDefaultBuilder()
              .ConfigureWebHostDefaults(webHost =>
              {
                 
                  webHost.UseStartup<Startup>();
                  webHost.UseKestrel()
                   .UseUrls("http://localhost:5111");

              });
}
