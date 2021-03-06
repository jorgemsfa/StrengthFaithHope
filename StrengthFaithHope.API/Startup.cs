using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StrengthFaithHope.Domain.Handlers;
using StrengthFaithHope.Domain.Handlers.Contracts;
using StrengthFaithHope.Domain.Queries;
using StrengthFaithHope.Domain.Repositories;
using StrengthFaithHope.Infra.Contexts;
using StrengthFaithHope.Infra.Repositories;

namespace StrengthFaithHope.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            ///services.AddCors();
            services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("Database"));

            services.AddTransient<IMessageRepository,MessageRepository>();
            services.AddTransient<ITypeRepository, TypeRepository>();
            services.AddTransient<ITypeQueries, TypeQueries>();
            services.AddTransient<IMessageQueries, MessageQueries>();


            services.AddTransient<CreateMessageHandler, CreateMessageHandler>();
            services.AddTransient<CreateTypeHandler, CreateTypeHandler>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
           
            //app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

    internal interface ICreateMessageHandler
    {
    }
}
