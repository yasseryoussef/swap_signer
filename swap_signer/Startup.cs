using Microsoft.AspNetCore.Authentication.Certificate;

namespace swap_signer
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //services.AddAuthentication(
            //    CertificateAuthenticationDefaults.AuthenticationScheme)
            //    .AddCertificate()
            //    // Adding an ICertificateValidationCache results in certificate auth caching the results.
            //    // The default implementation uses a memory cache.
            //    .AddCertificateCache();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
