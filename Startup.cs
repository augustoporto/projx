using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using projx.Data;
using projx.Repositories;

namespace projx
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(option => option.EnableEndpointRouting = false)
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddNewtonsoftJson(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
            services.AddResponseCompression();
            services.AddScoped<MovimentacaoDataContext, MovimentacaoDataContext>();
            services.AddTransient<CategoriaMovimentacaoRepository, CategoriaMovimentacaoRepository>();
            services.AddTransient<ContaRepository, ContaRepository>();
            services.AddTransient<UsuarioRepository, UsuarioRepository>();
            services.AddTransient<AgendamentoRepository, AgendamentoRepository>();
            services.AddTransient<MovimentacaoRepository, MovimentacaoRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseMvc();
        }
    }
}
